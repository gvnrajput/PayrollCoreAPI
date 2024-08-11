using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using WebAPI.Common;
using BAL.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize] // Uncomment if you want to require authorization
    public class SettingsCountriesController : ControllerBase
    {
        private readonly ISettingsCountryRepository _repository;

        public SettingsCountriesController(ISettingsCountryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<SuccessResponse<IEnumerable<SettingsCountry>>>> GetSettingsCountries()
        {
            try
            {
                var countries = await _repository.GetAllAsync();
                return Ok(new SuccessResponse<IEnumerable<SettingsCountry>>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    countries));
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
        public async Task<ActionResult<SuccessResponse<SettingsCountry>>> GetSettingsCountry(int id)
        {
            try
            {
                var country = await _repository.GetByIdAsync(id);

                if (country == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                return Ok(new SuccessResponse<SettingsCountry>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    country));
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
        public async Task<ActionResult<SuccessResponse<SettingsCountry>>> PutSettingsCountry(int id, SettingsCountry country)
        {
            if (id != country.CountryId)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.IdMismatch));
            }

            try
            {
                await _repository.UpdateAsync(country);

                var updatedCountry = await _repository.GetByIdAsync(id);
                return Ok(new SuccessResponse<SettingsCountry>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataUpdatedSuccessfully,
                    updatedCountry));
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
        public async Task<ActionResult<SuccessResponse<SettingsCountry>>> PostSettingsCountry(SettingsCountry country)
        {
            try
            {               
                if (await _repository.ExistsAsync(country.CountryName ?? string.Empty))
                {
                    return Conflict(new ErrorResponse(
                        StatusCodes.Status409Conflict,
                        ResponseMessages.AlreadyExists));
                }

                await _repository.AddAsync(country);

                return CreatedAtAction("GetSettingsCountry", new { id = country.CountryId },
                    new SuccessResponse<SettingsCountry>(
                        StatusCodes.Status201Created,
                        ResponseMessages.CreatedSuccessfully,
                        country));
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
        public async Task<ActionResult<SuccessResponse<SettingsCountry>>> DeleteSettingsCountry(int id)
        {
            try
            {
                var country = await _repository.GetByIdAsync(id);
                if (country == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                await _repository.DeleteAsync(id);

                return Ok(new SuccessResponse<SettingsCountry>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataDeletedSuccessfully,
                    country));
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
