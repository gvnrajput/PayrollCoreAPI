using Microsoft.AspNetCore.Mvc;
using BAL.Interfaces;
using DAL.Models;
using WebAPI.Common;
using WebAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
        public async Task<ActionResult<SuccessResponse<SettingsCompany>>> PostSettingsCompany(SettingsCompanyModel companyModel)
        {
            try
            {
                if (await _repository.ExistsAsync(companyModel.CompanyName ?? string.Empty))
                {
                    return Conflict(new ErrorResponse(
                        StatusCodes.Status409Conflict,
                        ResponseMessages.AlreadyExists));
                }

                var company = new SettingsCompany
                {
                    CompanyGroupId = companyModel.CompanyGroupId,
                    CompanyName = companyModel.CompanyName,
                    CompanyAddress = companyModel.CompanyAddress,
                    CityId = companyModel.CityId,
                    StateId = companyModel.StateId,
                    CountryId = companyModel.CountryId,
                    PhoneNo = companyModel.PhoneNo,
                    Fax = companyModel.Fax,
                    EmailId = companyModel.EmailId,
                    Website = companyModel.Website,
                    CompanyImgUrl = companyModel.CompanyImgUrl,
                    CompanyLogo = companyModel.CompanyLogo,
                    Description = companyModel.Description,
                    CompanyActive = companyModel.CompanyActive,
                    RegNo = companyModel.RegNo,
                    PanNo = companyModel.PanNo,
                    TinNo = companyModel.TinNo,
                    EccNo = companyModel.EccNo,
                    CstNo = companyModel.CstNo,
                    Collectorate = companyModel.Collectorate,
                    Hgstno = companyModel.Hgstno,
                    ServiceTaxNo = companyModel.ServiceTaxNo,
                    ExciseRange = companyModel.ExciseRange,
                    ExciseAddress = companyModel.ExciseAddress,
                    ExciseDiv = companyModel.ExciseDiv,
                    CompanyLicNo = companyModel.CompanyLicNo,
                    PrimaryOwner = companyModel.PrimaryOwner
                };

                await _repository.AddAsync(company);
                return CreatedAtAction(nameof(GetSettingsCompany), new { id = company.CompanyId },
                    new SuccessResponse<SettingsCompany>(
                        StatusCodes.Status201Created,
                        ResponseMessages.CreatedSuccessfully,
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

        [HttpPut("{id}")]
        public async Task<ActionResult<SuccessResponse<SettingsCompany>>> PutSettingsCompany(int id, SettingsCompanyModel companyModel)
        {
            if (id <= 0)
            {
                return BadRequest(new ErrorResponse(
                    StatusCodes.Status400BadRequest,
                    ResponseMessages.InvalidID));
            }

            try
            {
                var existingCompany = await _repository.GetByIdAsync(id);
                if (existingCompany == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                existingCompany.CompanyGroupId = companyModel.CompanyGroupId;
                existingCompany.CompanyName = companyModel.CompanyName;
                existingCompany.CompanyAddress = companyModel.CompanyAddress;
                existingCompany.CityId = companyModel.CityId;
                existingCompany.StateId = companyModel.StateId;
                existingCompany.CountryId = companyModel.CountryId;
                existingCompany.PhoneNo = companyModel.PhoneNo;
                existingCompany.Fax = companyModel.Fax;
                existingCompany.EmailId = companyModel.EmailId;
                existingCompany.Website = companyModel.Website;
                existingCompany.CompanyImgUrl = companyModel.CompanyImgUrl;
                existingCompany.CompanyLogo = companyModel.CompanyLogo;
                existingCompany.Description = companyModel.Description;
                existingCompany.CompanyActive = companyModel.CompanyActive;
                existingCompany.RegNo = companyModel.RegNo;
                existingCompany.PanNo = companyModel.PanNo;
                existingCompany.TinNo = companyModel.TinNo;
                existingCompany.EccNo = companyModel.EccNo;
                existingCompany.CstNo = companyModel.CstNo;
                existingCompany.Collectorate = companyModel.Collectorate;
                existingCompany.Hgstno = companyModel.Hgstno;
                existingCompany.ServiceTaxNo = companyModel.ServiceTaxNo;
                existingCompany.ExciseRange = companyModel.ExciseRange;
                existingCompany.ExciseAddress = companyModel.ExciseAddress;
                existingCompany.ExciseDiv = companyModel.ExciseDiv;
                existingCompany.CompanyLicNo = companyModel.CompanyLicNo;
                existingCompany.PrimaryOwner = companyModel.PrimaryOwner;

                await _repository.UpdateAsync(existingCompany);
                return Ok(new SuccessResponse<SettingsCompany>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataUpdatedSuccessfully,
                    existingCompany));
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
                var company = await _repository.GetByIdAsync(id);
                if (company == null)
                {
                    return NotFound(new ErrorResponse(
                        StatusCodes.Status404NotFound,
                        ResponseMessages.NotFound));
                }

                await _repository.DeleteAsync(id);
                return Ok(new SuccessResponse<SettingsCompany>(
                    StatusCodes.Status200OK,
                    ResponseMessages.DataDeletedSuccessfully,
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
    }
}
