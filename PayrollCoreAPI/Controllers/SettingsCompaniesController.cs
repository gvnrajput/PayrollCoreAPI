using Microsoft.AspNetCore.Mvc;
using BAL.Interfaces;
using DAL.Models;
using WebAPI.Common;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsCompaniesController : ControllerBase
    {
        private readonly ISettingsCompanyRepository _repository;

        public SettingsCompaniesController(ISettingsCompanyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<SuccessResponse<IEnumerable<SettingsCompany>>>> GetSettingsCompanies()
        {
            try
            {
                var companies = await _repository.GetAllAsync();
                return Ok(new SuccessResponse<IEnumerable<SettingsCompany>>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    companies));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompany>>> GetSettingsCompany(int id)
        {
            try
            {
                var company = await _repository.GetByIdAsync(id);
                if (company == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                return Ok(new SuccessResponse<SettingsCompany>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    company));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompany>>> PostSettingsCompany(SettingsCompany settingsCompany)
        {
            try
            {                
                if (await _repository.ExistsAsync(settingsCompany.CompanyName))
                {
                    return Conflict(new ErrorResponse(
                        StatusCodes.Status409Conflict,
                        ResponseMessages.AlreadyExists)); 
                }

                await _repository.AddAsync(settingsCompany);
                return CreatedAtAction(nameof(GetSettingsCompany), new { id = settingsCompany.CompanyId },
                    new SuccessResponse<SettingsCompany>(
                        StatusCodes.Status201Created,
                        ResponseMessages.CreatedSuccessfully,
                        settingsCompany));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompany>>> PutSettingsCompany(int id, SettingsCompany settingsCompany)
        {
            if (id != settingsCompany.CompanyId)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.IdMismatch));
            }

            try
            {
                await _repository.UpdateAsync(settingsCompany);
                return Ok(new SuccessResponse<SettingsCompany>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataUpdatedSuccessfully,
                    settingsCompany));
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
        public async Task<ActionResult<SuccessResponse<SettingsCompany>>> DeleteSettingsCompany(int id)
        {
            try
            {
                await _repository.DeleteAsync(id);
                return Ok(new SuccessResponse<SettingsCompany>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataDeletedSuccessfully,
                    null));
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
