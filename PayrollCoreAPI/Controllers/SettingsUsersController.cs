using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using WebAPI.Common;
using BAL.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SettingsUsersController : ControllerBase
    {
        private readonly ISettingsUserRepository _repository;
        EncryptDecryptPassword encryptDecryptPassword = new EncryptDecryptPassword();
        public SettingsUsersController(ISettingsUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<SuccessResponse<IEnumerable<SettingsUser>>>> GetSettingsUsers()
        {
            try
            {
                var users = await _repository.GetAllUsersAsync();
                return Ok(new SuccessResponse<IEnumerable<SettingsUser>>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    users));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new ErrorResponse(
                        StatusCodes.Status500InternalServerError,
                        ResponseMessages.InternalServerError,
                        ResponseMessages.GetErrorDetails(ex)));
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessResponse<SettingsUser>>> GetSettingsUser(int id)
        {
            try
            {
                var user = await _repository.GetUserByIdAsync(id);

                if (user == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                return Ok(new SuccessResponse<SettingsUser>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    user));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new ErrorResponse(
                        StatusCodes.Status500InternalServerError,
                        ResponseMessages.InternalServerError,
                        ResponseMessages.GetErrorDetails(ex)));
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SuccessResponse<SettingsUser>>> PutSettingsUser(int id, SettingsUserModel userModel)
        {
            if (id <= 0)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.InvalidID));
            }

            try
            {
                var existingUser = await _repository.GetUserByIdAsync(id);
                if (existingUser == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                existingUser.UserGroupId = userModel.UserGroupId;
                existingUser.CompanyId = userModel.CompanyId;
                existingUser.LocationId = userModel.LocationId;
                existingUser.EmployeeId = userModel.EmployeeId;
                existingUser.UserName = userModel.UserName;
                existingUser.Password = encryptDecryptPassword.encrypt(userModel.Password);
                existingUser.ExpiryDate = userModel.ExpiryDate;
                existingUser.UserActive = userModel.UserActive;

                await _repository.UpdateUserAsync(existingUser);

                var updatedUser = await _repository.GetUserByIdAsync(id);
                return Ok(new SuccessResponse<SettingsUser>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataUpdatedSuccessfully,
                    updatedUser));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new ErrorResponse(
                        StatusCodes.Status500InternalServerError,
                        ResponseMessages.InternalServerError,
                        ResponseMessages.GetErrorDetails(ex)));
            }
        }

        [HttpPost]
        public async Task<ActionResult<SuccessResponse<SettingsUser>>> PostSettingsUser(SettingsUserModel userModel)
        {
            try
            {
                if (await _repository.UserExistsAsync(userModel.UserName))
                {
                    return Conflict(new ErrorResponse(
                        StatusCodes.Status409Conflict,
                        ResponseMessages.AlreadyExists));
                }

                var user = new SettingsUser
                {
                    UserGroupId = userModel.UserGroupId,
                    CompanyId = userModel.CompanyId,
                    LocationId = userModel.LocationId,
                    EmployeeId = userModel.EmployeeId,
                    UserName = userModel.UserName,
                    Password = encryptDecryptPassword.encrypt(userModel.Password),
                    ExpiryDate = userModel.ExpiryDate,
                    UserActive = userModel.UserActive
                };

                await _repository.AddUserAsync(user);

                return CreatedAtAction("GetSettingsUser", new { id = user.UserId },
                    new SuccessResponse<SettingsUser>(
                        StatusCodes.Status201Created,
                        ResponseMessages.CreatedSuccessfully,
                        user));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new ErrorResponse(
                        StatusCodes.Status500InternalServerError,
                        ResponseMessages.InternalServerError,
                        ResponseMessages.GetErrorDetails(ex)));
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SuccessResponse<SettingsUser>>> DeleteSettingsUser(int id)
        {
            try
            {
                var user = await _repository.GetUserByIdAsync(id);
                if (user == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                await _repository.DeleteUserAsync(id);

                return Ok(new SuccessResponse<SettingsUser>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataDeletedSuccessfully,
                    user));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new ErrorResponse(
                        StatusCodes.Status500InternalServerError,
                        ResponseMessages.InternalServerError,
                        ResponseMessages.GetErrorDetails(ex)));
            }
        }
    }
}
