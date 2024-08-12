using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using WebAPI.Common;
using BAL.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
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
                var companyGroup = await _repository.GetByIdAsync(id);

                if (companyGroup == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                return Ok(new SuccessResponse<SettingsCompanyGroup>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    companyGroup));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> PutSettingsCompanyGroup(int id, SettingsCompanyGroupModel companyGroupModel)
        {
            if (id <= 0)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.InvalidID));
            }

            try
            {
                var existingCompanyGroup = await _repository.GetByIdAsync(id);
                if (existingCompanyGroup == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                existingCompanyGroup.CompanyGroupName = companyGroupModel.CompanyGroupName;
                existingCompanyGroup.CompanyGroupActive = companyGroupModel.CompanyGroupActive;

                await _repository.UpdateAsync(existingCompanyGroup);

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
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> PostSettingsCompanyGroup(SettingsCompanyGroupModel companyGroupModel)
        {
            try
            {
                if (await _repository.ExistsAsync(companyGroupModel.CompanyGroupName ?? string.Empty))
                {
                    return Conflict(new ErrorResponse(
                        StatusCodes.Status409Conflict,
                        ResponseMessages.AlreadyExists));
                }

                var companyGroup = new SettingsCompanyGroup
                {
                    CompanyGroupName = companyGroupModel.CompanyGroupName,
                    CompanyGroupActive = companyGroupModel.CompanyGroupActive
                };

                await _repository.AddAsync(companyGroup);

                return CreatedAtAction("GetSettingsCompanyGroup", new { id = companyGroup.CompanyGroupId },
                    new SuccessResponse<SettingsCompanyGroup>(
                        StatusCodes.Status201Created,
                        ResponseMessages.CreatedSuccessfully,
                        companyGroup));
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
                var companyGroup = await _repository.GetByIdAsync(id);
                if (companyGroup == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                await _repository.DeleteAsync(id);

                return Ok(new SuccessResponse<SettingsCompanyGroup>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataDeletedSuccessfully,
                    companyGroup));
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
