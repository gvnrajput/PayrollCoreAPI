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
    public class SettingsLocationsController : ControllerBase
    {
        private readonly ISettingsLocationRepository _repository;

        public SettingsLocationsController(ISettingsLocationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<SuccessResponse<IEnumerable<SettingsLocation>>>> GetSettingsLocations()
        {
            try
            {
                var locations = await _repository.GetAllAsync();
                return Ok(new SuccessResponse<IEnumerable<SettingsLocation>>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    locations));
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
        public async Task<ActionResult<SuccessResponse<SettingsLocation>>> GetSettingsLocation(int id)
        {
            try
            {
                var location = await _repository.GetByIdAsync(id);

                if (location == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                return Ok(new SuccessResponse<SettingsLocation>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    location));
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
        public async Task<ActionResult<SuccessResponse<SettingsLocation>>> PutSettingsLocation(int id, SettingsLocation location)
        {
            if (id != location.LocationId)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.IdMismatch));
            }

            try
            {
                await _repository.UpdateAsync(location);

                var updatedLocation = await _repository.GetByIdAsync(id);
                return Ok(new SuccessResponse<SettingsLocation>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataUpdatedSuccessfully,
                    updatedLocation));
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
        public async Task<ActionResult<SuccessResponse<SettingsLocation>>> PostSettingsLocation(SettingsLocation location)
        {
            try
            {
                // Check if a location with the same name already exists and is active
                if (await _repository.ExistsAsync(location.LocationName ?? string.Empty))
                {
                    return Conflict(new ErrorResponse(
                        StatusCodes.Status409Conflict,
                        ResponseMessages.AlreadyExists));
                }

                await _repository.AddAsync(location);

                return CreatedAtAction("GetSettingsLocation", new { id = location.LocationId },
                    new SuccessResponse<SettingsLocation>(
                        StatusCodes.Status201Created,
                        ResponseMessages.CreatedSuccessfully,
                        location));
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
        public async Task<ActionResult<SuccessResponse<SettingsLocation>>> DeleteSettingsLocation(int id)
        {
            try
            {
                var location = await _repository.GetByIdAsync(id);
                if (location == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                await _repository.DeleteAsync(id);

                return Ok(new SuccessResponse<SettingsLocation>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataDeletedSuccessfully,
                    location));
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
