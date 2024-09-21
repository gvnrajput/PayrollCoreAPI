using BAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Common;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SettingsStatesController : ControllerBase
    {
        private readonly ISettingsStateRepository _repository;

        public SettingsStatesController(ISettingsStateRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<SuccessResponse<IQueryable<SettingsState>>>> GetStates()
        {
            try
            {
                var states = _repository.GetAll();
                return Ok(new SuccessResponse<IQueryable<SettingsState>>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    states));
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
        public async Task<ActionResult<SuccessResponse<SettingsState>>> GetState(int id)
        {
            try
            {
                var state = await _repository.GetByIdAsync(id);
                if (state == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                return Ok(new SuccessResponse<SettingsState>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataRetrievedSuccessfully,
                    state));
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
        public async Task<ActionResult<SuccessResponse<SettingsState>>> PostState([FromBody] SettingsState state)
        {
            try
            {
                await _repository.AddAsync(state);
                return CreatedAtAction(nameof(GetState), new { id = state.StateId },
                    new SuccessResponse<SettingsState>(
                        StatusCodes.Status201Created,
                        ResponseMessages.CreatedSuccessfully,
                        state));
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
        public async Task<ActionResult<SuccessResponse<SettingsState>>> PutState(int id, [FromBody] SettingsState state)
        {
            if (id <= 0)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.InvalidID));
            }

            try
            {
                var existingState = await _repository.GetByIdAsync(id);
                if (existingState == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                existingState.StateName = state.StateName;
                existingState.CountryId = state.CountryId;
                existingState.StateActive = state.StateActive;

                await _repository.UpdateAsync(existingState);
                return Ok(new SuccessResponse<SettingsState>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataUpdatedSuccessfully,
                    existingState));
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
        public async Task<IActionResult> DeleteState(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.InvalidID));
            }

            try
            {
                var existingState = await _repository.GetByIdAsync(id);
                if (existingState == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                await _repository.DeleteAsync(id);
                return NoContent();
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
        
        //[HttpGet("with-country")]
        //public async Task<ActionResult<SuccessResponse<List<SettingsStateWithCountry>>>> GetStatesWithCountry()
        //{
        //    try
        //    {
        //        // Get the data as IEnumerable
        //        var statesWithCountry = await _repository.GetAllStatesWithCountryAsync();

        //        // Convert IEnumerable to List
        //        var statesWithCountryList = statesWithCountry.ToList();

        //        // Return success response with List
        //        return Ok(new SuccessResponse<List<SettingsStateWithCountry>>(
        //            StatusCodes.Status200OK,
        //            ResponseMessages.DataRetrievedSuccessfully,
        //            statesWithCountry));
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            new ErrorResponse(
        //                StatusCodes.Status500InternalServerError,
        //                ResponseMessages.InternalServerError,
        //                ResponseMessages.GetErrorDetails(ex)));
        //    }
        //}

    }
}
