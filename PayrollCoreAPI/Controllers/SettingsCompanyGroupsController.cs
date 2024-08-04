using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Common;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  // [Authorize]
    public class SettingsCompanyGroupsController : ControllerBase
    {
        private readonly PayrollDbContext _context;

        public SettingsCompanyGroupsController(PayrollDbContext context)
        {
            _context = context;
        }

        // GET: api/SettingsCompanyGroups
        [HttpGet]
        public async Task<ActionResult<SuccessResponse<IEnumerable<SettingsCompanyGroup>>>> GetSettingsCompanyGroups()
        {
            try
            {
                var companyGroups = await _context.SettingsCompanyGroups.ToListAsync();
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

        // GET: api/SettingsCompanyGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> GetSettingsCompanyGroup(int id)
        {
            try
            {
                var settingsCompanyGroup = await _context.SettingsCompanyGroups.FindAsync(id);

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

        // PUT: api/SettingsCompanyGroups/5
        [HttpPut("{id}")]
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> PutSettingsCompanyGroup(int id, SettingsCompanyGroup settingsCompanyGroup)
        {
            if (id != settingsCompanyGroup.CompanyGroupId)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.IdMismatch));
            }

            _context.Entry(settingsCompanyGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                // Retrieve the updated resource to return in the response
                var updatedCompanyGroup = await _context.SettingsCompanyGroups.FindAsync(id);

                // Return success response with a message
                return Ok(new SuccessResponse<SettingsCompanyGroup>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataUpdatedSuccessfully, // Use the centralized success message
                    updatedCompanyGroup));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SettingsCompanyGroupExists(id))
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }
                else
                {
                    throw;
                }
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

        // POST: api/SettingsCompanyGroups
        [HttpPost]
        public async Task<ActionResult<SuccessResponse<SettingsCompanyGroup>>> PostSettingsCompanyGroup(SettingsCompanyGroup settingsCompanyGroup)
        {
            try
            {
                _context.SettingsCompanyGroups.Add(settingsCompanyGroup);
                await _context.SaveChangesAsync();

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

        // DELETE: api/SettingsCompanyGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SuccessResponse<object>>> DeleteSettingsCompanyGroup(int id)
        {
            try
            {
                var settingsCompanyGroup = await _context.SettingsCompanyGroups.FindAsync(id);
                if (settingsCompanyGroup == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                _context.SettingsCompanyGroups.Remove(settingsCompanyGroup);
                await _context.SaveChangesAsync();

                // Return success response with a message
                return Ok(new SuccessResponse<object>(
                    StatusCodes.Status200OK, // Status code 200 OK because a response message is sent
                    ResponseMessages.DataDeletedSuccessfully));
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

        private bool SettingsCompanyGroupExists(int id)
        {
            return _context.SettingsCompanyGroups.Any(e => e.CompanyGroupId == id);
        }
    }
}
