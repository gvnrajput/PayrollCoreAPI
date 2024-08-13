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
        public async Task<ActionResult<SuccessResponse<SettingsLocation>>> PutSettingsLocation(int id, SettingsLocationModel locationModel)
        {
            if (id <= 0)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.InvalidID));
            }

            try
            {
                var existingLocation = await _repository.GetByIdAsync(id);
                if (existingLocation == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }
                
                existingLocation.CompanyId = locationModel.CompanyId;
                existingLocation.LocationName = locationModel.LocationName;
                existingLocation.LocationAddress = locationModel.LocationAddress;
                existingLocation.CityId = locationModel.CityId;
                existingLocation.StateId = locationModel.StateId;
                existingLocation.CountryId = locationModel.CountryId;
                existingLocation.PhoneNo = locationModel.PhoneNo;
                existingLocation.Fax = locationModel.Fax;
                existingLocation.EmailId = locationModel.EmailId;
                existingLocation.Description = locationModel.Description;
                existingLocation.LocationActive = locationModel.LocationActive;

                await _repository.UpdateAsync(existingLocation);

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
        public async Task<ActionResult<SuccessResponse<SettingsLocation>>> PostSettingsLocation(SettingsLocationModel locationModel)
        {
            try
            {
                if (await _repository.ExistsAsync(locationModel.LocationName ?? string.Empty))
                {
                    return Conflict(new ErrorResponse(
                        StatusCodes.Status409Conflict,
                        ResponseMessages.AlreadyExists));
                }

                var location = new SettingsLocation
                {
                    CompanyId = locationModel.CompanyId,
                    LocationName = locationModel.LocationName,
                    LocationAddress = locationModel.LocationAddress,
                    CityId = locationModel.CityId,
                    StateId = locationModel.StateId,
                    CountryId = locationModel.CountryId,
                    PhoneNo = locationModel.PhoneNo,
                    Fax = locationModel.Fax,
                    EmailId = locationModel.EmailId,
                    Description = locationModel.Description,
                    LocationActive = locationModel.LocationActive
                };

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
