using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DAL.Models; // Adjust namespace for your DAL models
using WebAPI.Common;
using BAL.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize] // Uncomment if you want to require authorization
    public class SettingsCompanyGroupsController : ControllerBase
    {
        private readonly ISettingsCompanyGroupRepository _repository;

        public SettingsCompanyGroupsController(ISettingsCompanyGroupRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<SuccessResponse<IEnumerable<SettingsCompanyGroup>>>> GetSettingsCompanyGroups()
        {
            try
            {
                var companyGroups = await _repository.GetAllAsync();
                return Ok(new SuccessResponse<IEnumerable<SettingsCompanyGroup>>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    companyGroups));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> GetSettingsCompanyGroup(int id)
        {
            try
            {
                var settingsCompanyGroup = await _repository.GetByIdAsync(id);

                if (settingsCompanyGroup == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                return Ok(new SuccessResponse<SettingsCompanyGroup>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    settingsCompanyGroup));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> PutSettingsCompanyGroup(int id, SettingsCompanyGroup settingsCompanyGroup)
        {
            if (id != settingsCompanyGroup.CompanyGroupId)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.IdMismatch));
            }

            try
            {
                await _repository.UpdateAsync(settingsCompanyGroup);

                var updatedCompanyGroup = await _repository.GetByIdAsync(id);
                return Ok(new SuccessResponse<SettingsCompanyGroup>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataUpdatedSuccessfully,
                    updatedCompanyGroup));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> PostSettingsCompanyGroup(SettingsCompanyGroup settingsCompanyGroup)
        {
            try
            {
                await _repository.AddAsync(settingsCompanyGroup);

                return CreatedAtAction("GetSettingsCompanyGroup", new { id = settingsCompanyGroup.CompanyGroupId },
                    new SuccessResponse<SettingsCompanyGroup>(
                        StatusCodes.Status201Created,
                        ResponseMessages.CreatedSuccessfully,
                        settingsCompanyGroup));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> DeleteSettingsCompanyGroup(int id)
        {
            try
            {
                var settingsCompanyGroup = await _repository.GetByIdAsync(id);
                if (settingsCompanyGroup == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                await _repository.DeleteAsync(id);

                return Ok(new SuccessResponse<SettingsCompanyGroup>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataDeletedSuccessfully,
                    settingsCompanyGroup));
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
