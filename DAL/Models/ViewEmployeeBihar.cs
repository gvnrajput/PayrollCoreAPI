using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ViewEmployeeBihar
{
    public string? EmployeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? CardNumber { get; set; }

    public string? FatherName { get; set; }

    public string? SpouseName { get; set; }

    public string? Dob { get; set; }

    public string? Gender { get; set; }

    public string? PhoneNo { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? PanNo { get; set; }

    public string? DepartmentName { get; set; }

    public string? DesignationName { get; set; }

    public string? SalaryGradeName { get; set; }

    public string? EmployeeStatus { get; set; }

    public string? MaritalStatusName { get; set; }

    public string? BloodGroupName { get; set; }

    public string? JoiningDate { get; set; }

    public int? ProbationPeriod { get; set; }

    public string? ConfirmationDate { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public string? Ifsccode { get; set; }

    public string? AccountNo { get; set; }

    public string? PaymentType { get; set; }

    public string? AadharEnrollmentNo { get; set; }

    public string? AadharNo { get; set; }

    public string? PfjoinDate { get; set; }

    public string? Pfscheme { get; set; }

    public string? Pfnumber { get; set; }

    public string? Esino { get; set; }

    public DateTime? ResignSubmitted { get; set; }

    public string NoticeRequired { get; set; } = null!;

    public string NoticeServed { get; set; } = null!;

    public int? NoticePeriod { get; set; }

    public string? DemiseDate { get; set; }

    public string? RetireDate { get; set; }

    public string? LeavingDate { get; set; }

    public string? EmployeeFeedback { get; set; }

    public string? FinalSettelementdate { get; set; }

    public string? RelieveDate { get; set; }

    public string? PassportNo { get; set; }

    public string? ValidUpto { get; set; }

    public string? VisaNo { get; set; }

    public string? VisaType { get; set; }

    public string HasLeft { get; set; } = null!;

    public string? NomineeName { get; set; }

    public decimal? Pfuannumber { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }
}
