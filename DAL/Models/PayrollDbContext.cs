using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class PayrollDbContext : DbContext
{
    public PayrollDbContext()
    {
    }

    public PayrollDbContext(DbContextOptions<PayrollDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AttendanceEss> AttendanceEsses { get; set; }

    public virtual DbSet<AttendanceLogBiometric> AttendanceLogBiometrics { get; set; }

    public virtual DbSet<AttendanceLogBrowser> AttendanceLogBrowsers { get; set; }

    public virtual DbSet<AttendanceManaul> AttendanceManauls { get; set; }

    public virtual DbSet<AttendanceManaulFullAndFinal> AttendanceManaulFullAndFinals { get; set; }

    public virtual DbSet<AttendanceShift> AttendanceShifts { get; set; }

    public virtual DbSet<AttendanceShiftDetail> AttendanceShiftDetails { get; set; }

    public virtual DbSet<AttendanceTimeFrame> AttendanceTimeFrames { get; set; }

    public virtual DbSet<AttendenceDetailBiometric> AttendenceDetailBiometrics { get; set; }

    public virtual DbSet<AttendenceDetailBrowser> AttendenceDetailBrowsers { get; set; }

    public virtual DbSet<AuditEmployeeRoster> AuditEmployeeRosters { get; set; }

    public virtual DbSet<AuditEmployeeSalaryHeadDetail> AuditEmployeeSalaryHeadDetails { get; set; }

    public virtual DbSet<Candidate> Candidates { get; set; }

    public virtual DbSet<CvrepositoryCvtype> CvrepositoryCvtypes { get; set; }

    public virtual DbSet<CvrepositoryCvupload> CvrepositoryCvuploads { get; set; }

    public virtual DbSet<CvrepositoryCvupload1> CvrepositoryCvupload1s { get; set; }

    public virtual DbSet<CvrepositoryDirectInterview> CvrepositoryDirectInterviews { get; set; }

    public virtual DbSet<DataLog> DataLogs { get; set; }

    public virtual DbSet<EmailHistory> EmailHistories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeAadharRequest> EmployeeAadharRequests { get; set; }

    public virtual DbSet<EmployeeAddressDetail> EmployeeAddressDetails { get; set; }

    public virtual DbSet<EmployeeAppreciation> EmployeeAppreciations { get; set; }

    public virtual DbSet<EmployeeAssetDetail> EmployeeAssetDetails { get; set; }

    public virtual DbSet<EmployeeAssetDetail1> EmployeeAssetDetails1 { get; set; }

    public virtual DbSet<EmployeeDocument> EmployeeDocuments { get; set; }

    public virtual DbSet<EmployeeDocumentRequest> EmployeeDocumentRequests { get; set; }

    public virtual DbSet<EmployeeExitInterview> EmployeeExitInterviews { get; set; }

    public virtual DbSet<EmployeeFullAndFinal> EmployeeFullAndFinals { get; set; }

    public virtual DbSet<EmployeeHasLeftDetail> EmployeeHasLeftDetails { get; set; }

    public virtual DbSet<EmployeeInfoEditRequest> EmployeeInfoEditRequests { get; set; }

    public virtual DbSet<EmployeePassportRequest> EmployeePassportRequests { get; set; }

    public virtual DbSet<EmployeePreviousDetail> EmployeePreviousDetails { get; set; }

    public virtual DbSet<EmployeePreviousDetailRequest> EmployeePreviousDetailRequests { get; set; }

    public virtual DbSet<EmployeeProjectDetail> EmployeeProjectDetails { get; set; }

    public virtual DbSet<EmployeePromotion> EmployeePromotions { get; set; }

    public virtual DbSet<EmployeeQualificationDetail> EmployeeQualificationDetails { get; set; }

    public virtual DbSet<EmployeeQualificationDetailRequest> EmployeeQualificationDetailRequests { get; set; }

    public virtual DbSet<EmployeeReferenceCheck> EmployeeReferenceChecks { get; set; }

    public virtual DbSet<EmployeeReimbursmentHeadDetail> EmployeeReimbursmentHeadDetails { get; set; }

    public virtual DbSet<EmployeeRelieving> EmployeeRelievings { get; set; }

    public virtual DbSet<EmployeeResignationRequest> EmployeeResignationRequests { get; set; }

    public virtual DbSet<EmployeeRoster> EmployeeRosters { get; set; }

    public virtual DbSet<EmployeeSalaryHeadDetail> EmployeeSalaryHeadDetails { get; set; }

    public virtual DbSet<EmployeeTdsdetail> EmployeeTdsdetails { get; set; }

    public virtual DbSet<EmployeeToDoStatusLog> EmployeeToDoStatusLogs { get; set; }

    public virtual DbSet<EmployeeToDoTaskMst> EmployeeToDoTaskMsts { get; set; }

    public virtual DbSet<EmployeeVigilance> EmployeeVigilances { get; set; }

    public virtual DbSet<EmployeeWarning> EmployeeWarnings { get; set; }

    public virtual DbSet<ErrorCv> ErrorCvs { get; set; }

    public virtual DbSet<ErrorEmployee> ErrorEmployees { get; set; }

    public virtual DbSet<ErrorSalaryDetail> ErrorSalaryDetails { get; set; }

    public virtual DbSet<EsicemployerContribution> EsicemployerContributions { get; set; }

    public virtual DbSet<EssSetting> EssSettings { get; set; }

    public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }

    public virtual DbSet<HrAppointmentLetter> HrAppointmentLetters { get; set; }

    public virtual DbSet<HrCandiateAddressDetail> HrCandiateAddressDetails { get; set; }

    public virtual DbSet<HrCandidatDocument> HrCandidatDocuments { get; set; }

    public virtual DbSet<HrCandidateAddressDetail> HrCandidateAddressDetails { get; set; }

    public virtual DbSet<HrCandidateExtraCurricular> HrCandidateExtraCurriculars { get; set; }

    public virtual DbSet<HrCandidateFaimlyDetail> HrCandidateFaimlyDetails { get; set; }

    public virtual DbSet<HrCandidateInterviewSchedule> HrCandidateInterviewSchedules { get; set; }

    public virtual DbSet<HrCandidateMiscellaneou> HrCandidateMiscellaneous { get; set; }

    public virtual DbSet<HrCandidateOfferLetter> HrCandidateOfferLetters { get; set; }

    public virtual DbSet<HrCandidatePreviousDetail> HrCandidatePreviousDetails { get; set; }

    public virtual DbSet<HrCandidateQualificationDetail> HrCandidateQualificationDetails { get; set; }

    public virtual DbSet<HrCandidateSalaryHeadDetail> HrCandidateSalaryHeadDetails { get; set; }

    public virtual DbSet<HrCandidateTraineQualification> HrCandidateTraineQualifications { get; set; }

    public virtual DbSet<HrCandidateTraineeAddressDetail> HrCandidateTraineeAddressDetails { get; set; }

    public virtual DbSet<HrCandidateTraineeClass> HrCandidateTraineeClasses { get; set; }

    public virtual DbSet<HrCandidateinfo> HrCandidateinfos { get; set; }

    public virtual DbSet<HrEmployeeTransfer> HrEmployeeTransfers { get; set; }

    public virtual DbSet<HrInterviewDetail> HrInterviewDetails { get; set; }

    public virtual DbSet<HrInterviewSchedule> HrInterviewSchedules { get; set; }

    public virtual DbSet<HrInterviewerSchedule> HrInterviewerSchedules { get; set; }

    public virtual DbSet<HrJobOrderByCv> HrJobOrderByCvs { get; set; }

    public virtual DbSet<HrJobOrderByCvdetail> HrJobOrderByCvdetails { get; set; }

    public virtual DbSet<HrLetterofIntent> HrLetterofIntents { get; set; }

    public virtual DbSet<HrManpowerRequisation> HrManpowerRequisations { get; set; }

    public virtual DbSet<HrSelectedCandidate> HrSelectedCandidates { get; set; }

    public virtual DbSet<HrSelectedCandidateDetail> HrSelectedCandidateDetails { get; set; }

    public virtual DbSet<ImportManpowerrequisation> ImportManpowerrequisations { get; set; }

    public virtual DbSet<ImportOrgTree> ImportOrgTrees { get; set; }

    public virtual DbSet<ImportTblCandidateWalkin> ImportTblCandidateWalkins { get; set; }

    public virtual DbSet<ImportTblCvnew> ImportTblCvnews { get; set; }

    public virtual DbSet<ImportTblDirectInterview> ImportTblDirectInterviews { get; set; }

    public virtual DbSet<ImportTblEmployeeHasLeft> ImportTblEmployeeHasLefts { get; set; }

    public virtual DbSet<ImportTblEmployeeMaster> ImportTblEmployeeMasters { get; set; }

    public virtual DbSet<ImportTblEmployeeMaster1> ImportTblEmployeeMaster1s { get; set; }

    public virtual DbSet<ImportTblEmployeeResigned> ImportTblEmployeeResigneds { get; set; }

    public virtual DbSet<ImportTblEmployeeSalary> ImportTblEmployeeSalaries { get; set; }

    public virtual DbSet<ImportedAttendance> ImportedAttendances { get; set; }

    public virtual DbSet<Kraform> Kraforms { get; set; }

    public virtual DbSet<LeaveApplication> LeaveApplications { get; set; }

    public virtual DbSet<LeaveConfiguration> LeaveConfigurations { get; set; }

    public virtual DbSet<LeaveOpening> LeaveOpenings { get; set; }

    public virtual DbSet<LeaveSetting> LeaveSettings { get; set; }

    public virtual DbSet<LoanHeader> LoanHeaders { get; set; }

    public virtual DbSet<LoginDetail> LoginDetails { get; set; }

    public virtual DbSet<MstChecklist> MstChecklists { get; set; }

    public virtual DbSet<MstEmployeeRating> MstEmployeeRatings { get; set; }

    public virtual DbSet<MstPermission> MstPermissions { get; set; }

    public virtual DbSet<MstRatingParameter> MstRatingParameters { get; set; }

    public virtual DbSet<MstRembursementType> MstRembursementTypes { get; set; }

    public virtual DbSet<MstSequence> MstSequences { get; set; }

    public virtual DbSet<MstStatusClaim> MstStatusClaims { get; set; }

    public virtual DbSet<MstTemplateType> MstTemplateTypes { get; set; }

    public virtual DbSet<MstWorkflowType> MstWorkflowTypes { get; set; }

    public virtual DbSet<NotImportOrgTree> NotImportOrgTrees { get; set; }

    public virtual DbSet<OnDutySlip> OnDutySlips { get; set; }

    public virtual DbSet<OrganisationTree> OrganisationTrees { get; set; }

    public virtual DbSet<PayrollAttendance> PayrollAttendances { get; set; }

    public virtual DbSet<PayrollAttendanceDetail> PayrollAttendanceDetails { get; set; }

    public virtual DbSet<PayrollAttendanceDetailFaf> PayrollAttendanceDetailFafs { get; set; }

    public virtual DbSet<PayrollAttendanceFaf> PayrollAttendanceFafs { get; set; }

    public virtual DbSet<PayrollCategoryType> PayrollCategoryTypes { get; set; }

    public virtual DbSet<PayrollElencashment> PayrollElencashments { get; set; }

    public virtual DbSet<PayrollEmployeeForm16Detail> PayrollEmployeeForm16Details { get; set; }

    public virtual DbSet<PayrollEmployeePerquisitesDetail> PayrollEmployeePerquisitesDetails { get; set; }

    public virtual DbSet<PayrollEsicsetting> PayrollEsicsettings { get; set; }

    public virtual DbSet<PayrollForm16Head> PayrollForm16Heads { get; set; }

    public virtual DbSet<PayrollIncentiveTranfer> PayrollIncentiveTranfers { get; set; }

    public virtual DbSet<PayrollLateDeduction> PayrollLateDeductions { get; set; }

    public virtual DbSet<PayrollLoanApplication> PayrollLoanApplications { get; set; }

    public virtual DbSet<PayrollLoanDetail> PayrollLoanDetails { get; set; }

    public virtual DbSet<PayrollOtherEntitlementDetail> PayrollOtherEntitlementDetails { get; set; }

    public virtual DbSet<PayrollOtherEntitlementDetailFaf> PayrollOtherEntitlementDetailFafs { get; set; }

    public virtual DbSet<PayrollPerquisitesDetail> PayrollPerquisitesDetails { get; set; }

    public virtual DbSet<PayrollPfsetting> PayrollPfsettings { get; set; }

    public virtual DbSet<PayrollProfessionalTax> PayrollProfessionalTaxes { get; set; }

    public virtual DbSet<PayrollRembursementDetail> PayrollRembursementDetails { get; set; }

    public virtual DbSet<PayrollSalaryDetail> PayrollSalaryDetails { get; set; }

    public virtual DbSet<PayrollSalaryDetailFaf> PayrollSalaryDetailFafs { get; set; }

    public virtual DbSet<PayrollSalaryHeader> PayrollSalaryHeaders { get; set; }

    public virtual DbSet<PayrollSalaryHeaderFaf> PayrollSalaryHeaderFafs { get; set; }

    public virtual DbSet<PayrollSalaryHold> PayrollSalaryHolds { get; set; }

    public virtual DbSet<PayrollSalaryIncrement> PayrollSalaryIncrements { get; set; }

    public virtual DbSet<PayrollSalaryStructure> PayrollSalaryStructures { get; set; }

    public virtual DbSet<PayrollSalaryTranfer> PayrollSalaryTranfers { get; set; }

    public virtual DbSet<PayrollTdsadjustmentDetail> PayrollTdsadjustmentDetails { get; set; }

    public virtual DbSet<PayrollTdsclaim> PayrollTdsclaims { get; set; }

    public virtual DbSet<PayrollTdsclaimDetail> PayrollTdsclaimDetails { get; set; }

    public virtual DbSet<PayrollTdsform16> PayrollTdsform16s { get; set; }

    public virtual DbSet<PayrollTdspriorInvestment> PayrollTdspriorInvestments { get; set; }

    public virtual DbSet<PayrollTdssetting> PayrollTdssettings { get; set; }

    public virtual DbSet<PayrollTdstype> PayrollTdstypes { get; set; }

    public virtual DbSet<PfemployerContribution> PfemployerContributions { get; set; }

    public virtual DbSet<RecruitmentResourceType> RecruitmentResourceTypes { get; set; }

    public virtual DbSet<RecruitmentTradeCategoryType> RecruitmentTradeCategoryTypes { get; set; }

    public virtual DbSet<RembursementClaim> RembursementClaims { get; set; }

    public virtual DbSet<RembursementClaimDetail> RembursementClaimDetails { get; set; }

    public virtual DbSet<SequenceMaster> SequenceMasters { get; set; }

    public virtual DbSet<SettingBulletinBoard> SettingBulletinBoards { get; set; }

    public virtual DbSet<SettingEmployeeOfTheMonth> SettingEmployeeOfTheMonths { get; set; }

    public virtual DbSet<SettingLoanType> SettingLoanTypes { get; set; }

    public virtual DbSet<SettingSm> SettingSms { get; set; }

    public virtual DbSet<SettingSmsaccount> SettingSmsaccounts { get; set; }

    public virtual DbSet<SettingsAlertRemainder> SettingsAlertRemainders { get; set; }

    public virtual DbSet<SettingsAsset> SettingsAssets { get; set; }

    public virtual DbSet<SettingsAttendanceSchedule> SettingsAttendanceSchedules { get; set; }

    public virtual DbSet<SettingsBank> SettingsBanks { get; set; }

    public virtual DbSet<SettingsBankBranch> SettingsBankBranches { get; set; }

    public virtual DbSet<SettingsBloodGroup> SettingsBloodGroups { get; set; }

    public virtual DbSet<SettingsCity> SettingsCities { get; set; }

    public virtual DbSet<SettingsCompany> SettingsCompanies { get; set; }

    public virtual DbSet<SettingsCompanyAccount> SettingsCompanyAccounts { get; set; }

    public virtual DbSet<SettingsCompanyGroup> SettingsCompanyGroups { get; set; }

    public virtual DbSet<SettingsCountry> SettingsCountries { get; set; }

    public virtual DbSet<SettingsCourse> SettingsCourses { get; set; }

    public virtual DbSet<SettingsCurrency> SettingsCurrencies { get; set; }

    public virtual DbSet<SettingsDepartment> SettingsDepartments { get; set; }

    public virtual DbSet<SettingsDesignation> SettingsDesignations { get; set; }

    public virtual DbSet<SettingsDocumentType> SettingsDocumentTypes { get; set; }

    public virtual DbSet<SettingsEmail> SettingsEmails { get; set; }

    public virtual DbSet<SettingsEmployeeStatus> SettingsEmployeeStatuses { get; set; }

    public virtual DbSet<SettingsExperience> SettingsExperiences { get; set; }

    public virtual DbSet<SettingsFinancialYear> SettingsFinancialYears { get; set; }

    public virtual DbSet<SettingsForm> SettingsForms { get; set; }

    public virtual DbSet<SettingsGrade> SettingsGrades { get; set; }

    public virtual DbSet<SettingsHoliday> SettingsHolidays { get; set; }

    public virtual DbSet<SettingsIuserRole> SettingsIuserRoles { get; set; }

    public virtual DbSet<SettingsLeaveType> SettingsLeaveTypes { get; set; }

    public virtual DbSet<SettingsLeavingReason> SettingsLeavingReasons { get; set; }

    public virtual DbSet<SettingsLoan> SettingsLoans { get; set; }

    public virtual DbSet<SettingsLocation> SettingsLocations { get; set; }

    public virtual DbSet<SettingsMachineConfiguration> SettingsMachineConfigurations { get; set; }

    public virtual DbSet<SettingsMaritalStatus> SettingsMaritalStatuses { get; set; }

    public virtual DbSet<SettingsModule> SettingsModules { get; set; }

    public virtual DbSet<SettingsMonth> SettingsMonths { get; set; }

    public virtual DbSet<SettingsNationaity> SettingsNationaities { get; set; }

    public virtual DbSet<SettingsPftype> SettingsPftypes { get; set; }

    public virtual DbSet<SettingsPolicyDetail> SettingsPolicyDetails { get; set; }

    public virtual DbSet<SettingsQualification> SettingsQualifications { get; set; }

    public virtual DbSet<SettingsQuerry> SettingsQuerries { get; set; }

    public virtual DbSet<SettingsReference> SettingsReferences { get; set; }

    public virtual DbSet<SettingsRelationShip> SettingsRelationShips { get; set; }

    public virtual DbSet<SettingsReligion> SettingsReligions { get; set; }

    public virtual DbSet<SettingsReportAccordianName> SettingsReportAccordianNames { get; set; }

    public virtual DbSet<SettingsReportPermission> SettingsReportPermissions { get; set; }

    public virtual DbSet<SettingsRestrictedInterview> SettingsRestrictedInterviews { get; set; }

    public virtual DbSet<SettingsSalaryCycle> SettingsSalaryCycles { get; set; }

    public virtual DbSet<SettingsSalaryHead> SettingsSalaryHeads { get; set; }

    public virtual DbSet<SettingsSalaryHeadType> SettingsSalaryHeadTypes { get; set; }

    public virtual DbSet<SettingsSalaryMode> SettingsSalaryModes { get; set; }

    public virtual DbSet<SettingsState> SettingsStates { get; set; }

    public virtual DbSet<SettingsTemplate> SettingsTemplates { get; set; }

    public virtual DbSet<SettingsUser> SettingsUsers { get; set; }

    public virtual DbSet<SettingsUserGroup> SettingsUserGroups { get; set; }

    public virtual DbSet<SettingsUserRole> SettingsUserRoles { get; set; }

    public virtual DbSet<SettingsVigilance> SettingsVigilances { get; set; }

    public virtual DbSet<SettingsVisaType> SettingsVisaTypes { get; set; }

    public virtual DbSet<SettingsZone> SettingsZones { get; set; }

    public virtual DbSet<Smshistory> Smshistories { get; set; }

    public virtual DbSet<Smssetting> Smssettings { get; set; }

    public virtual DbSet<TblDeviceToken> TblDeviceTokens { get; set; }

    public virtual DbSet<TblDeviceToken1> TblDeviceTokens1 { get; set; }

    public virtual DbSet<TblEmployeeHasLeft> TblEmployeeHasLefts { get; set; }

    public virtual DbSet<TblEmployeeOfTheMonth> TblEmployeeOfTheMonths { get; set; }

    public virtual DbSet<TblEmployeeRating> TblEmployeeRatings { get; set; }

    public virtual DbSet<TblResignedEmployee> TblResignedEmployees { get; set; }

    public virtual DbSet<TblTaskAssignment> TblTaskAssignments { get; set; }

    public virtual DbSet<TblTaskAssignmentDisapproved> TblTaskAssignmentDisapproveds { get; set; }

    public virtual DbSet<TblTroubleTicket> TblTroubleTickets { get; set; }

    public virtual DbSet<TblWish> TblWishes { get; set; }

    public virtual DbSet<TbluserEnroll> TbluserEnrolls { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<Tempdatum> Tempdata { get; set; }

    public virtual DbSet<ViewEmployeeBihar> ViewEmployeeBihars { get; set; }

    public virtual DbSet<ViewEmployeeDehradoon> ViewEmployeeDehradoons { get; set; }

    public virtual DbSet<ViewEmployeeDetailsBihar> ViewEmployeeDetailsBihars { get; set; }

    public virtual DbSet<ViewEmployeeDetailsDehradoon> ViewEmployeeDetailsDehradoons { get; set; }

    public virtual DbSet<ViewEmployeeDetailsRanchi> ViewEmployeeDetailsRanchis { get; set; }

    public virtual DbSet<ViewEmployeeLeaveDetailsBihar> ViewEmployeeLeaveDetailsBihars { get; set; }

    public virtual DbSet<ViewEmployeeLeaveDetailsDehradoon> ViewEmployeeLeaveDetailsDehradoons { get; set; }

    public virtual DbSet<ViewEmployeeLeaveDetailsRanchi> ViewEmployeeLeaveDetailsRanchis { get; set; }

    public virtual DbSet<ViewEmployeeRanchi> ViewEmployeeRanchis { get; set; }

    public virtual DbSet<ViewEmployeeSalaryViewBihar> ViewEmployeeSalaryViewBihars { get; set; }

    public virtual DbSet<ViewEmployeeSalaryViewDehradoon> ViewEmployeeSalaryViewDehradoons { get; set; }

    public virtual DbSet<ViewEmployeeSalaryViewRanchi> ViewEmployeeSalaryViewRanchis { get; set; }

    public virtual DbSet<ViewEmployeeWiseSalaryBihar> ViewEmployeeWiseSalaryBihars { get; set; }

    public virtual DbSet<ViewEmployeeWiseSalaryDehradoon> ViewEmployeeWiseSalaryDehradoons { get; set; }

    public virtual DbSet<ViewEmployeeWiseSalaryRanchi> ViewEmployeeWiseSalaryRanchis { get; set; }

    public virtual DbSet<ViewMonthWiseSalaryBihar> ViewMonthWiseSalaryBihars { get; set; }

    public virtual DbSet<ViewMonthWiseSalaryDehradoon> ViewMonthWiseSalaryDehradoons { get; set; }

    public virtual DbSet<ViewMonthWiseSalaryRanchi> ViewMonthWiseSalaryRanchis { get; set; }

    public virtual DbSet<ViewResignedEmployeeBihar> ViewResignedEmployeeBihars { get; set; }

    public virtual DbSet<ViewResignedEmployeeDehradoon> ViewResignedEmployeeDehradoons { get; set; }

    public virtual DbSet<ViewResignedEmployeeRanchi> ViewResignedEmployeeRanchis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-F2DABSE;Database=Payroll_ERP;Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AttendanceEss>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_ESS");

            entity.Property(e => e.AttendanceEssid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AttendanceESSID");
            entity.Property(e => e.AttendanceIn).HasColumnType("datetime");
            entity.Property(e => e.AttendanceOut).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LunchIn).HasColumnType("datetime");
            entity.Property(e => e.LunchOut).HasColumnType("datetime");
            entity.Property(e => e.Pcname)
                .HasMaxLength(50)
                .HasColumnName("PCName");
            entity.Property(e => e.Presence).HasMaxLength(25);
            entity.Property(e => e.Reason).HasMaxLength(200);
        });

        modelBuilder.Entity<AttendanceLogBiometric>(entity =>
        {
            entity.HasKey(e => e.AttendanceBiometricsId).HasName("PK__Attendan__4F52605D1CC7330E");

            entity.ToTable("AttendanceLog_Biometrics");

            entity.Property(e => e.AttendanceBiometricsId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AttendanceBiometricsID");
            entity.Property(e => e.AttendanceTime).HasColumnType("datetime");
            entity.Property(e => e.CardNo).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Iomode).HasColumnName("IOMode");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Presence).HasMaxLength(25);
            entity.Property(e => e.Reason).HasMaxLength(500);
        });

        modelBuilder.Entity<AttendanceLogBrowser>(entity =>
        {
            entity.HasKey(e => e.AttendanceBrowserId).HasName("PK__Attendan__3FE49CA9450A2E92");

            entity.ToTable("AttendanceLog_Browser");

            entity.Property(e => e.AttendanceBrowserId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AttendanceBrowserID");
            entity.Property(e => e.AttendanceIn).HasColumnType("datetime");
            entity.Property(e => e.AttendanceOut).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LunchIn).HasColumnType("datetime");
            entity.Property(e => e.LunchOut).HasColumnType("datetime");
            entity.Property(e => e.Pcname)
                .HasMaxLength(50)
                .HasColumnName("PCName");
            entity.Property(e => e.Presence).HasMaxLength(25);
            entity.Property(e => e.Reason).HasMaxLength(200);
        });

        modelBuilder.Entity<AttendanceManaul>(entity =>
        {
            entity.HasKey(e => e.ManaulAttendanceId).HasName("PK__Attendan__B1976606761CE537");

            entity.ToTable("Attendance_Manaul");

            entity.Property(e => e.ManaulAttendanceId).HasColumnName("ManaulAttendanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Lop)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOP");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.SalaryDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeeklyOff).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AttendanceManaulFullAndFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_ManaulFullAndFinal");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FafmanaulAttendanceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FAFManaulAttendanceID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Lop)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOP");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.SalaryDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeeklyOff).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AttendanceShift>(entity =>
        {
            entity.HasKey(e => e.ShiftId).HasName("PK__Attendan__C0A838E1A36B0D87");

            entity.ToTable("Attendance_Shift");

            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LunchIn).HasMaxLength(50);
            entity.Property(e => e.LunchOut).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.ShiftFrom).HasMaxLength(50);
            entity.Property(e => e.ShiftName).HasMaxLength(100);
            entity.Property(e => e.ShiftTo).HasMaxLength(50);
            entity.Property(e => e.TotalHours).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMinutes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeeklyOffOnFri).HasColumnName("weeklyOffOnFri");
            entity.Property(e => e.WeeklyOffOnMon).HasColumnName("weeklyOffOnMon");
            entity.Property(e => e.WeeklyOffOnSat).HasColumnName("weeklyOffOnSat");
            entity.Property(e => e.WeeklyOffOnSun).HasColumnName("weeklyOffOnSun");
            entity.Property(e => e.WeeklyOffOnThu).HasColumnName("weeklyOffOnThu");
            entity.Property(e => e.WeeklyOffOnTue).HasColumnName("weeklyOffOnTue");
            entity.Property(e => e.WeeklyOffOnWed).HasColumnName("weeklyOffOnWed");
        });

        modelBuilder.Entity<AttendanceShiftDetail>(entity =>
        {
            entity.HasKey(e => e.ShiftDetailId).HasName("PK__Attendan__337A925E442B18F2");

            entity.ToTable("Attendance_ShiftDetail");

            entity.Property(e => e.ShiftDetailId).HasColumnName("ShiftDetailID");
            entity.Property(e => e.FromTime).HasMaxLength(50);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ToTime).HasMaxLength(50);
            entity.Property(e => e.VDayName)
                .HasMaxLength(50)
                .HasColumnName("vDayName");
            entity.Property(e => e.VsatDayStatus).HasColumnName("VSatDayStatus");
        });

        modelBuilder.Entity<AttendanceTimeFrame>(entity =>
        {
            entity.HasKey(e => e.TimeFrameId).HasName("PK__Attendan__F918F43B382ACCA1");

            entity.ToTable("Attendance_TimeFrame");

            entity.Property(e => e.TimeFrameId).HasColumnName("TimeFrameID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PercOfDeduct).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.TimeAfter).HasMaxLength(50);
            entity.Property(e => e.TimeBefore).HasMaxLength(50);
            entity.Property(e => e.TimeStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<AttendenceDetailBiometric>(entity =>
        {
            entity.HasKey(e => e.AttendenceDetailId).HasName("PK__Attenden__81A78132E3A1EF86");

            entity.ToTable("AttendenceDetail_Biometrics");

            entity.Property(e => e.AttendenceDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AttendenceDetailID");
            entity.Property(e => e.ActualInTime).HasColumnType("datetime");
            entity.Property(e => e.ActualOutTime).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.InTime).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LunchIn).HasColumnType("datetime");
            entity.Property(e => e.LunchOut).HasColumnType("datetime");
            entity.Property(e => e.OutTime).HasColumnType("datetime");
            entity.Property(e => e.OverTimeMinute).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Presence).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Smsstatus).HasColumnName("SMSStatus");
            entity.Property(e => e.StayedOn).HasMaxLength(25);
        });

        modelBuilder.Entity<AttendenceDetailBrowser>(entity =>
        {
            entity.HasKey(e => e.AttendenceDetailId).HasName("PK__Attenden__81A7813248DABF76");

            entity.ToTable("AttendenceDetail_Browser");

            entity.Property(e => e.AttendenceDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AttendenceDetailID");
            entity.Property(e => e.ActualInTime).HasColumnType("datetime");
            entity.Property(e => e.ActualOutTime).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.InTime).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LunchIn).HasColumnType("datetime");
            entity.Property(e => e.LunchOut).HasColumnType("datetime");
            entity.Property(e => e.OutTime).HasColumnType("datetime");
            entity.Property(e => e.OverTimeMinute).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Pcname)
                .HasMaxLength(50)
                .HasColumnName("PCName");
            entity.Property(e => e.Presence).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Smsstatus).HasColumnName("SMSStatus");
            entity.Property(e => e.StayedOn).HasMaxLength(25);
        });

        modelBuilder.Entity<AuditEmployeeRoster>(entity =>
        {
            entity.HasKey(e => e.AuditRosterId).HasName("PK__Audit_Em__B26001C1F04E6DAF");

            entity.ToTable("Audit_EmployeeRoster");

            entity.Property(e => e.AuditRosterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.AuditAction).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SchDate).HasColumnType("datetime");
            entity.Property(e => e.Scheduling).HasMaxLength(50);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
        });

        modelBuilder.Entity<AuditEmployeeSalaryHeadDetail>(entity =>
        {
            entity.HasKey(e => e.ImportsSalaryHeadDetailId).HasName("PK__Audit_Em__0B3DDE95622C1503");

            entity.ToTable("Audit_EmployeeSalaryHeadDetail");

            entity.Property(e => e.ImportsSalaryHeadDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ImportsSalaryHeadDetailID");
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AuditAction)
                .HasMaxLength(50)
                .HasColumnName("Audit_action");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Remarks).HasMaxLength(50);
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SalaryHeadDetailId).HasColumnName("SalaryHeadDetailID");
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
            entity.Property(e => e.SalaryStructureId).HasColumnName("SalaryStructureID");
        });

        modelBuilder.Entity<Candidate>(entity =>
        {
            entity.HasKey(e => e.CandidateId).HasName("PK__Candidat__DF539BFC0C7BBCAC");

            entity.ToTable("Candidate");

            entity.Property(e => e.CandidateId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CandidateID");
            entity.Property(e => e.AppliedDate).HasColumnType("datetime");
            entity.Property(e => e.CandDependents).HasMaxLength(50);
            entity.Property(e => e.CandHealth).HasMaxLength(25);
            entity.Property(e => e.CandIllness).HasMaxLength(25);
            entity.Property(e => e.CandParticulars).HasMaxLength(10);
            entity.Property(e => e.CandPhysicalProblems)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CandidateCode).HasMaxLength(50);
            entity.Property(e => e.CandidateName).HasMaxLength(250);
            entity.Property(e => e.Category).HasMaxLength(20);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FathHusbName).HasMaxLength(250);
            entity.Property(e => e.Fittness).HasMaxLength(15);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Height).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IsCancel).HasColumnName("isCancel");
            entity.Property(e => e.IsSelected).HasColumnName("isSelected");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MobileNo).HasMaxLength(25);
            entity.Property(e => e.MotherName).HasMaxLength(500);
            entity.Property(e => e.NationaityId).HasColumnName("NationaityID");
            entity.Property(e => e.Profession).HasMaxLength(200);
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TelNo).HasMaxLength(20);
            entity.Property(e => e.Weight).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<CvrepositoryCvtype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVRepository_CVType");

            entity.Property(e => e.Cvdescription)
                .HasMaxLength(100)
                .HasColumnName("CVDescription");
            entity.Property(e => e.Cvtype)
                .HasMaxLength(250)
                .HasColumnName("CVType");
            entity.Property(e => e.CvtypeActive).HasColumnName("CVTypeActive");
            entity.Property(e => e.CvtypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CVTypeID");
        });

        modelBuilder.Entity<CvrepositoryCvupload>(entity =>
        {
            entity.HasKey(e => e.CvuploadId).HasName("PK_CVUploadID");

            entity.ToTable("CVRepository_CVUpload");

            entity.Property(e => e.CvuploadId).HasColumnName("CVUploadID");
            entity.Property(e => e.CandidateName).HasMaxLength(200);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Cvstatus).HasColumnName("CVStatus");
            entity.Property(e => e.CvtypeId).HasColumnName("CVTypeID");
            entity.Property(e => e.CvuploadActive).HasColumnName("CVUploadActive");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(50);
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<CvrepositoryCvupload1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVRepository_CVUpload1");

            entity.Property(e => e.CandidateName).HasMaxLength(200);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Cvstatus).HasColumnName("CVStatus");
            entity.Property(e => e.CvtypeId).HasColumnName("CVTypeID");
            entity.Property(e => e.CvuploadActive).HasColumnName("CVUploadActive");
            entity.Property(e => e.CvuploadId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CVUploadID");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EntryType).HasMaxLength(50);
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.ExperienceI).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(50);
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<CvrepositoryDirectInterview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CVRepository_DirectInterview");

            entity.Property(e => e.CandidateName).HasMaxLength(200);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Cvstatus).HasColumnName("CVStatus");
            entity.Property(e => e.CvtypeId).HasColumnName("CVTypeID");
            entity.Property(e => e.CvuploadActive).HasColumnName("CVUploadActive");
            entity.Property(e => e.CvuploadId).HasColumnName("CVUploadID");
            entity.Property(e => e.DirectInterviewCode).HasMaxLength(50);
            entity.Property(e => e.DirectInterviewId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DirectInterviewID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.InterviewDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ManpowerRequisationId).HasColumnName("ManpowerRequisationID");
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(50);
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<DataLog>(entity =>
        {
            entity.HasKey(e => e.DataLogId).HasName("PK__DataLog__22BFD8061DE57479");

            entity.ToTable("DataLog");

            entity.Property(e => e.DataLogId).HasColumnName("DataLogID");
            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.ActionDescription).HasMaxLength(100);
            entity.Property(e => e.ClassName).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.IpAdress).HasMaxLength(150);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PkId).HasColumnName("PkID");
            entity.Property(e => e.TableName).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<EmailHistory>(entity =>
        {
            entity.HasKey(e => e.EmailHistoryId).HasName("PK__EmailHis__0A04E12CF62C8822");

            entity.ToTable("EmailHistory");

            entity.Property(e => e.EmailHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmailId).HasMaxLength(200);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Status).HasMaxLength(200);
            entity.Property(e => e.TemplateType).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");
            entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BloodGroup).HasMaxLength(50);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.ChangedNoticeDays).HasDefaultValue(0);
            entity.Property(e => e.CofirLetterDate).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");
            entity.Property(e => e.DdpayableAt)
                .HasMaxLength(250)
                .HasColumnName("DDPayableAt");
            entity.Property(e => e.DemiseDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.EmployeeStatusId).HasColumnName("EmployeeStatusID");
            entity.Property(e => e.EntryType).HasMaxLength(50);
            entity.Property(e => e.EpfexcessContribution).HasColumnName("EPFExcessContribution");
            entity.Property(e => e.EpsexcessContribution).HasColumnName("EPSExcessContribution");
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.ExitInterviewDate).HasColumnType("datetime");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(100)
                .HasColumnName("ImageURL");
            entity.Property(e => e.IncludedInEsischeme).HasColumnName("IncludedInESIScheme");
            entity.Property(e => e.IncludedInPfscheme).HasColumnName("IncludedInPFScheme");
            entity.Property(e => e.IqamaNo).HasMaxLength(150);
            entity.Property(e => e.IssuedAppointmentLatter).HasDefaultValue(0);
            entity.Property(e => e.JoiningDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingReasonId).HasColumnName("LeavingReasonID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NameAsPerAadhar).HasMaxLength(150);
            entity.Property(e => e.NameAsPerBank).HasMaxLength(150);
            entity.Property(e => e.NomineeName).HasMaxLength(100);
            entity.Property(e => e.OfferLetterId).HasColumnName("OfferLetterID");
            entity.Property(e => e.OtherBranch).HasMaxLength(200);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasColumnType("datetime")
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.Pfuannumber)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PFUANNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.PtincludeInSalary)
                .HasDefaultValue(true)
                .HasColumnName("PTIncludeInSalary");
            entity.Property(e => e.RelationShip).HasMaxLength(50);
            entity.Property(e => e.RelieveDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasColumnType("datetime");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.TdsincludeInSalary)
                .HasDefaultValue(true)
                .HasColumnName("TDSIncludeInSalary");
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.ValidUpto).HasColumnType("datetime");
            entity.Property(e => e.VerifyStatus).HasDefaultValue(true);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
        });

        modelBuilder.Entity<EmployeeAadharRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeAadharRequest");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.NameAsPerAadhar).HasMaxLength(150);
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EmployeeAddressDetail>(entity =>
        {
            entity.HasKey(e => e.AddressDetailId).HasName("PK__Employee__CC29661D6D1CC086");

            entity.ToTable("EmployeeAddressDetail");

            entity.Property(e => e.AddressDetailId).HasColumnName("AddressDetailID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Ext).HasMaxLength(10);
            entity.Property(e => e.FaxNo).HasMaxLength(20);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.PinCode).HasMaxLength(10);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.VerifyStatus).HasDefaultValue(true);
        });

        modelBuilder.Entity<EmployeeAppreciation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeAppreciation");

            entity.Property(e => e.Appreciation).ValueGeneratedOnAdd();
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DepartMentId).HasColumnName("DepartMentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinYearId).HasColumnName("FinYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PrevSalary).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<EmployeeAssetDetail>(entity =>
        {
            entity.HasKey(e => e.EmployeeAssetId).HasName("PK__Employee__0028F4210EAEBEBD");

            entity.ToTable("Employee_AssetDetails");

            entity.Property(e => e.EmployeeAssetId).HasColumnName("EmployeeAssetID");
            entity.Property(e => e.AssetCode).HasMaxLength(100);
            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeAssetDetail1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeAssetDetails");

            entity.Property(e => e.AssetDetailsId).ValueGeneratedOnAdd();
            entity.Property(e => e.AssetRemarks).HasMaxLength(200);
            entity.Property(e => e.AssetValidUpto).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<EmployeeDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeDocument");

            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DocumentID");
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.VerifyStatus).HasDefaultValue(true);
        });

        modelBuilder.Entity<EmployeeDocumentRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeDocumentRequest");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EmployeeExitInterview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Employee_ExitInterview");

            entity.Property(e => e.CanYouOfferAnyOtherCommentsThatWillEnableUsToUnderstandAndWhatWeCanDoToBecomeABetterCompany).HasColumnName("Can_you_offer_any_other_comments_that_will_enable_us_to_understand_and_what_we_can_do_to_become_a_better_company");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DescribeTheQualitiesAndCharacteristicsOfThePersonWhoIsMostLikelyToSucceedInThisCompany).HasColumnName("Describe_the_qualities_and_characteristics_of_the_person_who_is_most_likely_to_succeed_in_this_company");
            entity.Property(e => e.DescribeYourExperienceOfTheCompanysCommitmentToQualityCustomerService).HasColumnName("Describe_your_experience_of_the_companys_commitment_to_quality_customer_service");
            entity.Property(e => e.DidTheManagementOfTheCompanyCareAboutYouAndHelpYouAccomplishYourGoals).HasColumnName("Did_the_management_of_the_company_care_about_you_and_help_you_accomplish_your__goals");
            entity.Property(e => e.DidYouClearlyUnderstandAndFeelAPartOfTheAccomplishmentOfTheCompanyMissionAndGoals).HasColumnName("Did_you_clearly_understand_and_feel_a_part_of_the_accomplishment_of_the_company_mission_and_goals");
            entity.Property(e => e.DidYouHaveClearGoalsAndKnowWhatWasExpectedOfYouInYourJob).HasColumnName("Did_you_have_clear_goals_and_know_what_was_expected_of_you_in_your_job");
            entity.Property(e => e.DidYouReceiveAdequateFeedbackAboutYourPerformanceDayDayAndInThePerformanceDevelopmentPlanningProcess).HasColumnName("Did_you_receive_adequate_feedback_about_your_performance_day_day_and_in_the_performance_development_planning_process");
            entity.Property(e => e.DoThePoliciesAndProceduresOfTheCompanyHelpCreateAWellmanagedConsistentAndFairAreClearlyDefined).HasColumnName("Do_the_policies_and_procedures_of_the_company_help_create_a_wellmanaged_consistent_and_fair_are_clearly_defined");
            entity.Property(e => e.EmployeeExitId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EmployeeExitID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.HaveYouSharedYourConcernsWithAnyoneInTheCompanyPriorToDecidingToLeaveWhatWasTheResponse).HasColumnName("Have_you_shared_your_concerns_with_anyone_in_the_company_prior_to_deciding_to_leave_What_was_the_response");
            entity.Property(e => e.JobSupportNecessaryIfNotWhatWasMissing).HasColumnName("Job_support_necessary_If_not_what_was_missing");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.RecommendationsRegardingOurCompensationBenefitsAndOtherRewardAndRecognitionEfforts).HasColumnName("recommendations_regarding_our_compensation_benefits_and_other_reward_and_recognition_efforts");
            entity.Property(e => e.TheQualityOfSupervisionIsImportantToMostPeopleAtWorkHowWasYourRelationshipWithYourManager).HasColumnName("The_quality_of_supervision_is_important_to_most_people_at_work_How_was_your_relationship_with_your_manager");
            entity.Property(e => e.WasASingleEventResponsibleForYourDecisionToLeave).HasColumnName("Was_a_single_event_responsible_for_your_decision_to_leave");
            entity.Property(e => e.WeTryToBeAnEmployeeOrientedMoraleAndMotivationMoraleAndMotivationInTheCompany).HasColumnName("We_try_to_be_an_employee_oriented_morale_and_motivation__morale_and_motivation_in_the_company");
            entity.Property(e => e.WereYourJobResponsibilitiesCharacterizedCorrectlyDuringTheInterviewProcessAndOrientation).HasColumnName("Were_your_job_responsibilities_characterized_correctly_during_the_interview_process_and_orientation");
            entity.Property(e => e.WhatAreTheKeyQualitiesAndSkillsWeShouldSeekInYourReplacement).HasColumnName("What_are_the_key_qualities_and_skills_we_should_seek_in_your_replacement");
            entity.Property(e => e.WhatAreYourViewsAboutManagementAndLeadershipInGeneralInTheCompany).HasColumnName("What_are_your_views_about_management_and_leadership_in_general_in_the_company");
            entity.Property(e => e.WhatCouldYourSupervisorDoToImproveHisOrHerManagementStyleAndSkill).HasColumnName("What_could_your_supervisor_do_to_improve_his_or_her_management_style_and_skill");
            entity.Property(e => e.WhatDidYouDislikeAboutTheCompany).HasColumnName("What_did_you_dislike_about_the_company");
            entity.Property(e => e.WhatDidYouDislikeAboutYourJobWhatWouldYouChangeAboutYourJob).HasColumnName("What_did_you_dislike_about_your_job_What_would_you_change_about_your_job");
            entity.Property(e => e.WhatDidYouLikeMostAboutYourJob).HasColumnName("What_did_you_like_most_about_your_job");
            entity.Property(e => e.WhatDoYouValueAboutTheCompany).HasColumnName("What_do_you_value_about_the_company");
            entity.Property(e => e.WhatDoesYourNewCompanyOfferThatEncouragedYouToAcceptTheirOfferAndLeaveThisCompany).HasColumnName("What_does_your_new_company_offer_that_encouraged_you_to_accept_their_offer_and_leave_this_company");
            entity.Property(e => e.WhatWouldMakeYouConsiderWorkingForThisCompanyAgainInTheFuture).HasColumnName("What_would_make_you_consider_working_for_this_company_again_in_the_future");
            entity.Property(e => e.WhatWouldYouRecommendToHelpUsCreateABetterWorkplace).HasColumnName("What_would_you_recommend_to_help_us_create_a_better_workplace");
            entity.Property(e => e.WhyHaveYouDecidedToLeaveTheCompany).HasColumnName("Why_have_you_decided_to_leave_the_company");
            entity.Property(e => e.WouldYouRecommendTheCompanyToYourFriendsAndFamily).HasColumnName("Would_you_recommend_the_company__to_your_friends_and_family");
        });

        modelBuilder.Entity<EmployeeFullAndFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeFullAndFinal");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FullAndFinalId)
                .ValueGeneratedOnAdd()
                .HasColumnName("fullAndFinalID");
            entity.Property(e => e.Hrreview).HasColumnName("HRReview");
            entity.Property(e => e.ReleasedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeHasLeftDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeHasLeftDetail");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BloodGroup).HasMaxLength(50);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");
            entity.Property(e => e.DdpayableAt)
                .HasMaxLength(250)
                .HasColumnName("DDPayableAt");
            entity.Property(e => e.DemiseDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.EmployeeStatusId).HasColumnName("EmployeeStatusID");
            entity.Property(e => e.EntryType).HasMaxLength(50);
            entity.Property(e => e.EpfexcessContribution).HasColumnName("EPFExcessContribution");
            entity.Property(e => e.EpsexcessContribution).HasColumnName("EPSExcessContribution");
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.ExitInterviewDate).HasColumnType("datetime");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(5);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(100)
                .HasColumnName("ImageURL");
            entity.Property(e => e.IncludedInEsischeme).HasColumnName("IncludedInESIScheme");
            entity.Property(e => e.IncludedInPfscheme).HasColumnName("IncludedInPFScheme");
            entity.Property(e => e.IqamaNo).HasMaxLength(150);
            entity.Property(e => e.JoiningDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingReasonId).HasColumnName("LeavingReasonID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NameAsPerAadhar).HasMaxLength(150);
            entity.Property(e => e.NameAsPerBank).HasMaxLength(150);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasColumnType("datetime")
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RelationShip).HasMaxLength(50);
            entity.Property(e => e.RelieveDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasColumnType("datetime");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.ValidUpto).HasColumnType("datetime");
            entity.Property(e => e.VisaNo).HasMaxLength(100);
        });

        modelBuilder.Entity<EmployeeInfoEditRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeInfoEditRequest");

            entity.Property(e => e.BloodGroup).HasMaxLength(25);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId).HasMaxLength(50);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.ImgUrl)
                .HasMaxLength(500)
                .HasColumnName("imgUrl");
            entity.Property(e => e.MaritalStatus).HasMaxLength(20);
            entity.Property(e => e.MobileNo).HasMaxLength(15);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PermanentAddress).HasMaxLength(250);
            entity.Property(e => e.PrresentAddress).HasMaxLength(250);
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EmployeePassportRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeePassportRequest");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IqamaNo).HasMaxLength(150);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
            entity.Property(e => e.ValidUpto).HasColumnType("datetime");
            entity.Property(e => e.VisaNo).HasMaxLength(100);
        });

        modelBuilder.Entity<EmployeePreviousDetail>(entity =>
        {
            entity.HasKey(e => e.PreviousDetailId).HasName("PK__Employee__1F478958F759F0B5");

            entity.ToTable("EmployeePreviousDetail");

            entity.Property(e => e.PreviousDetailId).HasColumnName("PreviousDetailID");
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingReason).HasMaxLength(250);
            entity.Property(e => e.NatureOfDuties).HasMaxLength(500);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.VerifyStatus).HasDefaultValue(true);
        });

        modelBuilder.Entity<EmployeePreviousDetailRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeePreviousDetailRequest");

            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingReason).HasMaxLength(250);
            entity.Property(e => e.NatureOfDuties).HasMaxLength(500);
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeProjectDetail>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__Employee__761ABEF070EFF08B");

            entity.ToTable("EmployeeProjectDetail");

            entity.Property(e => e.ApproxEndDate).HasColumnType("datetime");
            entity.Property(e => e.Party).HasMaxLength(200);
            entity.Property(e => e.ProjectName).HasMaxLength(200);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeePromotion>(entity =>
        {
            entity.HasKey(e => e.PromotionId).HasName("PK__Employee__52C42F2FEAB7A0FC");

            entity.ToTable("EmployeePromotion");

            entity.Property(e => e.PromotionId).HasColumnName("PromotionID");
            entity.Property(e => e.ChangeDesignationId).HasColumnName("ChangeDesignationID");
            entity.Property(e => e.ChangedDepartmentId).HasColumnName("ChangedDepartmentID");
            entity.Property(e => e.ChangedSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinYearId).HasColumnName("FinYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PrevDepartmentId).HasColumnName("PrevDepartmentID");
            entity.Property(e => e.PrevDesignationId).HasColumnName("PrevDesignationID");
            entity.Property(e => e.PrevSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PromotionDate).HasColumnType("datetime");
            entity.Property(e => e.PromotionStatus).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeQualificationDetail>(entity =>
        {
            entity.HasKey(e => e.QualificationDetailId).HasName("PK__Employee__666D37E3B94F4868");

            entity.ToTable("EmployeeQualificationDetail");

            entity.Property(e => e.QualificationDetailId).HasColumnName("QualificationDetailID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.InstituteName).HasMaxLength(250);
            entity.Property(e => e.PassingYear).HasMaxLength(50);
            entity.Property(e => e.QualificationArea).HasMaxLength(150);
            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.UniversityName).HasMaxLength(250);
            entity.Property(e => e.VerifyStatus).HasDefaultValue(true);
        });

        modelBuilder.Entity<EmployeeQualificationDetailRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeQualificationDetailRequest");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.InstituteName).HasMaxLength(250);
            entity.Property(e => e.PassingYear).HasMaxLength(50);
            entity.Property(e => e.QualificationArea).HasMaxLength(150);
            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
            entity.Property(e => e.UniversityName).HasMaxLength(250);
        });

        modelBuilder.Entity<EmployeeReferenceCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeReferenceCheck");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ReferenceCheckDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceCheckId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ReferenceCheckID");
            entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");
            entity.Property(e => e.VerifyStatus).HasDefaultValue(true);
        });

        modelBuilder.Entity<EmployeeReimbursmentHeadDetail>(entity =>
        {
            entity.HasKey(e => e.ReimbursmentHeadDetailId).HasName("PK__Employee__9BA81A827C262C81");

            entity.ToTable("EmployeeReimbursmentHeadDetail");

            entity.Property(e => e.ReimbursmentHeadDetailId).HasColumnName("ReimbursmentHeadDetailID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.RembursementHeadId).HasColumnName("RembursementHeadID");
        });

        modelBuilder.Entity<EmployeeRelieving>(entity =>
        {
            entity.HasKey(e => e.RelievingId).HasName("PK__Employee__8F4B0C568138C4E7");

            entity.ToTable("EmployeeRelieving");

            entity.Property(e => e.RelievingId).HasColumnName("RelievingID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartMentId).HasColumnName("DepartMentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinYearId).HasColumnName("FinYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PrevSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RelievingDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeResignationRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeResignationRequest");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LeavingReasonId).HasColumnName("LeavingReasonID");
            entity.Property(e => e.ManagerAccepted).HasDefaultValue(false);
            entity.Property(e => e.ManagerAcceptedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeRoster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeRoster");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeRosterId).ValueGeneratedOnAdd();
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SchDate).HasColumnType("datetime");
            entity.Property(e => e.Scheduling).HasMaxLength(50);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
        });

        modelBuilder.Entity<EmployeeSalaryHeadDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryHeadDetailId).HasName("PK__Employee__380F73FD9A2B36A2");

            entity.ToTable("EmployeeSalaryHeadDetail");

            entity.Property(e => e.SalaryHeadDetailId).HasColumnName("SalaryHeadDetailID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Remarks).HasMaxLength(50);
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
            entity.Property(e => e.SalaryStructureId).HasColumnName("SalaryStructureID");
        });

        modelBuilder.Entity<EmployeeTdsdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeTDSDetails");

            entity.Property(e => e.AmountPerMonth).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountPerYear).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeTdsdetails)
                .ValueGeneratedOnAdd()
                .HasColumnName("EmployeeTDSDetails");
            entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PercentageAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tdsslab)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDSSlab");
        });

        modelBuilder.Entity<EmployeeToDoStatusLog>(entity =>
        {
            entity.HasKey(e => e.EmployeeToDoStatusId).HasName("PK__Employee__025119D539E418A6");

            entity.ToTable("EmployeeToDoStatusLog");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeToDoTaskMst>(entity =>
        {
            entity.HasKey(e => e.EmployeeToDoId).HasName("PK__Employee__33DA2C9D88230C0F");

            entity.ToTable("EmployeeToDoTaskMst");

            entity.Property(e => e.AllocatedTime).HasMaxLength(20);
            entity.Property(e => e.AllocationDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeVigilance>(entity =>
        {
            entity.HasKey(e => e.EmployeeVigillanceId).HasName("PK__Employee__F189B03DBF0E5C10");

            entity.ToTable("Employee_Vigilance");

            entity.Property(e => e.EmployeeVigillanceId).HasColumnName("EmployeeVigillanceID");
            entity.Property(e => e.ActionType).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DocPath).HasMaxLength(500);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MistakeDate).HasColumnType("datetime");
            entity.Property(e => e.MistakePlace).HasMaxLength(200);
            entity.Property(e => e.VigilanceId).HasColumnName("VigilanceID");
            entity.Property(e => e.WarningDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeWarning>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeWarning");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DepartMentId).HasColumnName("DepartMentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinYearId).HasColumnName("FinYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PrevSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WarningId)
                .ValueGeneratedOnAdd()
                .HasColumnName("WarningID");
        });

        modelBuilder.Entity<ErrorCv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ErrorCV");

            entity.Property(e => e.CandidateName).HasMaxLength(100);
            entity.Property(e => e.PassportNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ErrorEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ErrorEmployee");

            entity.Property(e => e.Department).HasMaxLength(200);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeeName).HasMaxLength(250);
            entity.Property(e => e.Remarks).HasMaxLength(500);
        });

        modelBuilder.Entity<ErrorSalaryDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeeName).HasMaxLength(250);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SalaryGrade).HasMaxLength(50);
        });

        modelBuilder.Entity<EsicemployerContribution>(entity =>
        {
            entity.HasKey(e => e.Esicecid).HasName("PK__ESICEmpl__0349FE87131949B4");

            entity.ToTable("ESICEmployerContribution");

            entity.Property(e => e.Esicecid).HasColumnName("ESICECID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Esicecactive).HasColumnName("ESICECActive");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
        });

        modelBuilder.Entity<EssSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EssSetti__3214EC27950B30FC");

            entity.ToTable("EssSetting");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EmailId)
                .HasMaxLength(200)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActiveStaus).HasColumnName("isActiveStaus");
            entity.Property(e => e.UpateDate).HasColumnType("datetime");
            entity.Property(e => e.UpatedBy).HasMaxLength(50);
            entity.Property(e => e.WorkFlow).HasMaxLength(50);
        });

        modelBuilder.Entity<ExceptionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Exceptio__3214EC07BB828D02");

            entity.Property(e => e.DateOccurred).HasColumnType("datetime");
            entity.Property(e => e.ExceptionType).HasMaxLength(256);
        });

        modelBuilder.Entity<HrAppointmentLetter>(entity =>
        {
            entity.HasKey(e => e.AppointmentLetterId).HasName("PK__HR_Appoi__01E6EE5BC1AE8398");

            entity.ToTable("HR_AppointmentLetter");

            entity.Property(e => e.AppointmentLetterId).HasColumnName("AppointmentLetterID");
            entity.Property(e => e.AppointmentLetterCode).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CvuploadId).HasColumnName("CVUploadID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FromTime).HasMaxLength(50);
            entity.Property(e => e.IssuDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PrintDate).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ToTime).HasMaxLength(50);
            entity.Property(e => e.WorkingHours).HasMaxLength(50);
        });

        modelBuilder.Entity<HrCandiateAddressDetail>(entity =>
        {
            entity.HasKey(e => e.AddressDetailId).HasName("PK__HR_candi__CC29661D754D759A");

            entity.ToTable("HR_candiateAddressDetail");

            entity.Property(e => e.AddressDetailId).HasColumnName("AddressDetailID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.CandidateNo).HasColumnName("Candidate_no");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("EmailID");
            entity.Property(e => e.Ext).HasMaxLength(10);
            entity.Property(e => e.FaxNo).HasMaxLength(20);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.PinCode).HasMaxLength(10);
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<HrCandidatDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__HR_Candi__1ABEEF6FCE7D55F6");

            entity.ToTable("HR_CandidatDocument");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
        });

        modelBuilder.Entity<HrCandidateAddressDetail>(entity =>
        {
            entity.HasKey(e => e.AddressDetailId).HasName("PK__HR_Candi__CC29661D33C65F9B");

            entity.ToTable("HR_CandidateAddressDetail");

            entity.Property(e => e.AddressDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AddressDetailID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.CandidateId).HasColumnName("CandidateID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("EmailID");
            entity.Property(e => e.FaxNo).HasMaxLength(20);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<HrCandidateExtraCurricular>(entity =>
        {
            entity.HasKey(e => e.ExtraCurricularId).HasName("PK__HR_Candi__EB7349144F2C90A8");

            entity.ToTable("HR_CandidateExtraCurricular");

            entity.Property(e => e.ExtraCurricularId).HasColumnName("ExtraCurricularID");
            entity.Property(e => e.Activities).HasMaxLength(500);
            entity.Property(e => e.CandidateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CandidateID");
            entity.Property(e => e.InstitutionName).HasMaxLength(500);
            entity.Property(e => e.PositionOfficeHeld).HasMaxLength(100);
        });

        modelBuilder.Entity<HrCandidateFaimlyDetail>(entity =>
        {
            entity.HasKey(e => e.FaimlyDetailId).HasName("PK__HR_Candi__41BFA2A35A97FEC9");

            entity.ToTable("HR_CandidateFaimlyDetail");

            entity.Property(e => e.FaimlyDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("FaimlyDetailID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.AgeYear).HasColumnName("Age_Year");
            entity.Property(e => e.CandidateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CandidateID");
            entity.Property(e => e.ContactNo).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Profession).HasMaxLength(100);
            entity.Property(e => e.RelationShip).HasMaxLength(100);
        });

        modelBuilder.Entity<HrCandidateInterviewSchedule>(entity =>
        {
            entity.HasKey(e => e.CandidateInterviewScheduleId).HasName("PK__HR_Candi__7376E18D037C6257");

            entity.ToTable("HR_CandidateInterviewSchedule");

            entity.Property(e => e.CandidateInterviewScheduleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CandidateInterviewScheduleID");
            entity.Property(e => e.CandidateStatus).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CvuploadId).HasColumnName("CVUploadID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.InterviewDate).HasColumnType("datetime");
            entity.Property(e => e.InterviewerScheduleId).HasColumnName("InterviewerScheduleID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Rating).HasMaxLength(50);
            entity.Property(e => e.SelectionStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<HrCandidateMiscellaneou>(entity =>
        {
            entity.HasKey(e => e.MiscellaneousId).HasName("PK__HR_Candi__F0614609235F2204");

            entity.ToTable("HR_CandidateMiscellaneous");

            entity.Property(e => e.MiscellaneousId).HasColumnName("MiscellaneousID");
            entity.Property(e => e.Abroad).HasMaxLength(10);
            entity.Property(e => e.CandPreviousEmployment).HasMaxLength(10);
            entity.Property(e => e.CandServe).HasMaxLength(10);
            entity.Property(e => e.CandidateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CandidateID");
            entity.Property(e => e.CourtCase).HasMaxLength(10);
            entity.Property(e => e.CourtCaseDetails).HasMaxLength(100);
            entity.Property(e => e.Drive).HasMaxLength(10);
            entity.Property(e => e.DriveDetail).HasMaxLength(100);
            entity.Property(e => e.Licence).HasMaxLength(10);
            entity.Property(e => e.LicenceDetails).HasMaxLength(100);
            entity.Property(e => e.Membership).HasMaxLength(50);
            entity.Property(e => e.Ncc)
                .HasMaxLength(10)
                .HasColumnName("NCC");
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.Recreation).HasMaxLength(100);
            entity.Property(e => e.RefDepartmentId).HasColumnName("RefDepartmentID");
            entity.Property(e => e.ReferncePerson).HasMaxLength(50);
            entity.Property(e => e.RefrenceEmployeeId).HasColumnName("RefrenceEmployeeID");
            entity.Property(e => e.SpentTime).HasMaxLength(50);
            entity.Property(e => e.Vehicle).HasMaxLength(10);
            entity.Property(e => e.Visit).HasMaxLength(100);
            entity.Property(e => e.WhichVehicle).HasMaxLength(50);
        });

        modelBuilder.Entity<HrCandidateOfferLetter>(entity =>
        {
            entity.HasKey(e => e.OfferLetterId).HasName("PK__HR_Candi__94C85067C84F4CAB");

            entity.ToTable("HR_CandidateOfferLetter");

            entity.Property(e => e.OfferLetterId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OfferLetterID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CandidateInterviewScheduleId).HasColumnName("CandidateInterviewScheduleID");
            entity.Property(e => e.CandidateName).HasMaxLength(250);
            entity.Property(e => e.CandidateType).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FathHusbName).HasMaxLength(250);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.JoiningDate).HasColumnType("datetime");
            entity.Property(e => e.JoiningStatus).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MobileNo).HasMaxLength(25);
            entity.Property(e => e.MotherName).HasMaxLength(500);
            entity.Property(e => e.OfferLetterCode).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.TelNo).HasMaxLength(20);
            entity.Property(e => e.ValidDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrCandidatePreviousDetail>(entity =>
        {
            entity.HasKey(e => e.PreviousDetailId).HasName("PK__HR_Candi__1F478958D94EA9D6");

            entity.ToTable("HR_CandidatePreviousDetail");

            entity.Property(e => e.PreviousDetailId).HasColumnName("PreviousDetailID");
            entity.Property(e => e.CandidateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CandidateID");
            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingReason).HasMaxLength(250);
            entity.Property(e => e.NatureOfDuties).HasMaxLength(500);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrCandidateQualificationDetail>(entity =>
        {
            entity.HasKey(e => e.QualificationDetailId).HasName("PK__HR_Candi__666D37E3EADAA064");

            entity.ToTable("HR_CandidateQualificationDetail");

            entity.Property(e => e.QualificationDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QualificationDetailID");
            entity.Property(e => e.CandidateId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CandidateID");
            entity.Property(e => e.InstituteName).HasMaxLength(250);
            entity.Property(e => e.PassingYear).HasMaxLength(50);
            entity.Property(e => e.QualificationArea).HasMaxLength(150);
            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.UniversityName).HasMaxLength(250);
        });

        modelBuilder.Entity<HrCandidateSalaryHeadDetail>(entity =>
        {
            entity.HasKey(e => e.CandidateSalaryHeadDetailId).HasName("PK__HR_Candi__5699EC51FC5B6A91");

            entity.ToTable("HR_CandidateSalaryHeadDetail");

            entity.Property(e => e.CandidateSalaryHeadDetailId).HasColumnName("CandidateSalaryHeadDetailID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OfferLetterId).HasColumnName("OfferLetterID");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
            entity.Property(e => e.SalaryStructureId).HasColumnName("SalaryStructureID");
        });

        modelBuilder.Entity<HrCandidateTraineQualification>(entity =>
        {
            entity.HasKey(e => e.QualificationDetailId);

            entity.ToTable("Hr_CandidateTraineQualification");

            entity.Property(e => e.QualificationDetailId).HasColumnName("QualificationDetailID");
            entity.Property(e => e.CandidateNo).HasColumnName("Candidate_no");
            entity.Property(e => e.InstituteName).HasMaxLength(250);
            entity.Property(e => e.PassingYear).HasMaxLength(50);
            entity.Property(e => e.QualificationArea).HasMaxLength(250);
            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.UniversityName).HasMaxLength(250);
        });

        modelBuilder.Entity<HrCandidateTraineeAddressDetail>(entity =>
        {
            entity.HasKey(e => e.AddressDetailId);

            entity.ToTable("HR_CandidateTraineeAddressDetail");

            entity.Property(e => e.AddressDetailId).HasColumnName("AddressDetailID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.CandidateNo).HasColumnName("Candidate_no");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("EmailID");
            entity.Property(e => e.Ext).HasMaxLength(10);
            entity.Property(e => e.FaxNo).HasMaxLength(20);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.PinCode).HasMaxLength(10);
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<HrCandidateTraineeClass>(entity =>
        {
            entity.HasKey(e => e.ClassDetailId);

            entity.ToTable("Hr_candidateTrainee_Class");

            entity.Property(e => e.ClassDetailId).HasColumnName("ClassDetailID");
            entity.Property(e => e.AppliedCourse)
                .HasMaxLength(100)
                .HasColumnName("Applied_Course");
            entity.Property(e => e.CandidateNo).HasColumnName("Candidate_no");
            entity.Property(e => e.ClassEndDate)
                .HasColumnType("datetime")
                .HasColumnName("classEnd_Date");
            entity.Property(e => e.ClassStartDate)
                .HasColumnType("datetime")
                .HasColumnName("classStart_Date");
            entity.Property(e => e.CourseAmount)
                .HasMaxLength(50)
                .HasColumnName("Course_Amount");
            entity.Property(e => e.Department).HasColumnName("department");
            entity.Property(e => e.Discription).HasMaxLength(200);
            entity.Property(e => e.Faculty).HasMaxLength(50);
            entity.Property(e => e.NoOfClass).HasColumnName("No_ofClass");
            entity.Property(e => e.NoOfStudent).HasColumnName("No_ofStudent");
            entity.Property(e => e.Skills).HasMaxLength(150);
        });

        modelBuilder.Entity<HrCandidateinfo>(entity =>
        {
            entity.HasKey(e => e.CandidateNo);

            entity.ToTable("HR_Candidateinfo");

            entity.Property(e => e.CandidateNo).HasColumnName("Candidate_no");
            entity.Property(e => e.Applied).HasMaxLength(50);
            entity.Property(e => e.AppliedDate)
                .HasColumnType("datetime")
                .HasColumnName("Applied_date");
            entity.Property(e => e.CandidateCode).HasMaxLength(100);
            entity.Property(e => e.Category).HasMaxLength(10);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(150)
                .HasColumnName("father_name");
            entity.Property(e => e.Gender).HasMaxLength(5);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(100)
                .HasColumnName("imageURL");
            entity.Property(e => e.Intstitute).HasColumnName("intstitute");
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.MotherName)
                .HasMaxLength(150)
                .HasColumnName("Mother_name");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.PhysicalChallenge)
                .HasMaxLength(5)
                .HasColumnName("Physical_challenge");
            entity.Property(e => e.PhysicalType)
                .HasMaxLength(50)
                .HasColumnName("Physical_type");
            entity.Property(e => e.PlaceBirth)
                .HasMaxLength(50)
                .HasColumnName("Place_Birth");
            entity.Property(e => e.Purpose).HasMaxLength(50);
            entity.Property(e => e.RefEmail)
                .HasMaxLength(20)
                .HasColumnName("Ref_Email");
            entity.Property(e => e.RefMobile)
                .HasMaxLength(20)
                .HasColumnName("Ref_Mobile");
            entity.Property(e => e.RefereceName)
                .HasMaxLength(150)
                .HasColumnName("Referece_name");
            entity.Property(e => e.Skill).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
        });

        modelBuilder.Entity<HrEmployeeTransfer>(entity =>
        {
            entity.HasKey(e => e.EmployeeTransferId).HasName("PK__HR_Emplo__0AB6D6B852C3A74C");

            entity.ToTable("HR_EmployeeTransfer");

            entity.Property(e => e.EmployeeTransferId).HasColumnName("EmployeeTransferID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.FromLocationId).HasColumnName("FromLocationID");
            entity.Property(e => e.FromSalaryGradeId).HasColumnName("FromSalaryGradeID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.TolocationId).HasColumnName("TOLocationID");
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrInterviewDetail>(entity =>
        {
            entity.HasKey(e => e.InterviewDetails).HasName("PK__HR_Inter__E1E51CF3ED78FE50");

            entity.ToTable("HR_InterviewDetails");

            entity.Property(e => e.InterviewDetails)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CvuploadId).HasColumnName("CVUploadID");
            entity.Property(e => e.InterviewScheduleId).HasColumnName("InterviewScheduleID");
            entity.Property(e => e.InterviewStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<HrInterviewSchedule>(entity =>
        {
            entity.HasKey(e => e.InterviewScheduleId).HasName("PK__HR_Inter__A9EEDAB528828645");

            entity.ToTable("HR_InterviewSchedule");

            entity.Property(e => e.InterviewScheduleId).HasColumnName("InterviewScheduleID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.InterviewSchedule).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<HrInterviewerSchedule>(entity =>
        {
            entity.HasKey(e => e.InterviewerScheduleId).HasName("PK__HR_Inter__16B3466478FED3E4");

            entity.ToTable("HR_InterviewerSchedule");

            entity.Property(e => e.InterviewerScheduleId).HasColumnName("InterviewerScheduleID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.ForwardeToEmployeeId).HasColumnName("ForwardeToEmployeeID");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.FromTime).HasColumnType("datetime");
            entity.Property(e => e.IntDepartmentId)
                .HasMaxLength(150)
                .HasColumnName("Int_DepartmentID");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ReferenceCode).HasMaxLength(100);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.ToTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrJobOrderByCv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_JobOrderByCV");

            entity.Property(e => e.JobOrderByCvactive).HasColumnName("JobOrderByCVActive");
            entity.Property(e => e.JobOrderByCvid)
                .ValueGeneratedOnAdd()
                .HasColumnName("JobOrderByCVId");
            entity.Property(e => e.ManpowerRequisationId).HasColumnName("ManpowerRequisationID");
        });

        modelBuilder.Entity<HrJobOrderByCvdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_JobOrderByCVDetails");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CvuploadId).HasColumnName("CVUploadID");
            entity.Property(e => e.JobOrderByCvdetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JobOrderByCVDetailsId");
            entity.Property(e => e.JobOrderByCvid).HasColumnName("JobOrderByCVId");
        });

        modelBuilder.Entity<HrLetterofIntent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_LetterofIntent");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CvuploadId).HasColumnName("CVUploadID");
            entity.Property(e => e.FromTime).HasMaxLength(50);
            entity.Property(e => e.IssuDate).HasColumnType("datetime");
            entity.Property(e => e.LetterofIntentCode).HasMaxLength(50);
            entity.Property(e => e.LetterofIntentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LetterofIntentID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ManpowerRequisationId).HasColumnName("ManpowerRequisationID");
            entity.Property(e => e.PrintDate).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ToTime).HasMaxLength(50);
            entity.Property(e => e.WorkingHours).HasMaxLength(50);
        });

        modelBuilder.Entity<HrManpowerRequisation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_ManpowerRequisation");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.Jdpath).HasColumnName("JDPath");
            entity.Property(e => e.JobCode).HasMaxLength(30);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ManpowerRequisationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ManpowerRequisationID");
            entity.Property(e => e.Salary).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.VerifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrSelectedCandidate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_SelectedCandidate");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.InterviewerName).HasMaxLength(500);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SelectedCandidateId).ValueGeneratedOnAdd();
            entity.Property(e => e.SelectedDate).HasColumnType("datetime");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrSelectedCandidateDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_SelectedCandidateDetails");

            entity.Property(e => e.CanidateName).HasMaxLength(500);
            entity.Property(e => e.CvuploadId).HasColumnName("CVUploadID");
            entity.Property(e => e.DateOfJoining).HasColumnType("datetime");
            entity.Property(e => e.InterviewStatus).HasMaxLength(100);
            entity.Property(e => e.IssueedLoi).HasColumnName("IssueedLOI");
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SelectedCandidateDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SelectedCandidateDetailID");
        });

        modelBuilder.Entity<ImportManpowerrequisation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportManpowerrequisation");

            entity.Property(e => e.Department).HasMaxLength(500);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(50);
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.Jdpath).HasColumnName("JDPath");
            entity.Property(e => e.JobCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ImportOrgTree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportOrgTree");

            entity.Property(e => e.EmployeeName).HasMaxLength(100);
            entity.Property(e => e.ManagerName).HasMaxLength(100);
        });

        modelBuilder.Entity<ImportTblCandidateWalkin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportTblCandidateWalkin");

            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.Cvtype)
                .HasMaxLength(50)
                .HasColumnName("CVType ");
            entity.Property(e => e.DirectInterviewCode).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(50);
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.Specialisation).HasMaxLength(100);
            entity.Property(e => e.StateName).HasMaxLength(50);
        });

        modelBuilder.Entity<ImportTblCvnew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportTblCVNew");

            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.Cvtype)
                .HasMaxLength(500)
                .HasColumnName("CVType ");
            entity.Property(e => e.Experience).HasMaxLength(500);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(500);
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.Specialisation).HasMaxLength(1000);
            entity.Property(e => e.StateName).HasMaxLength(50);
        });

        modelBuilder.Entity<ImportTblDirectInterview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportTblDirectInterview");

            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CountryName).HasMaxLength(50);
            entity.Property(e => e.Cvtype)
                .HasMaxLength(50)
                .HasColumnName("CVType ");
            entity.Property(e => e.Experience).HasMaxLength(50);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(50);
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.Specialisation).HasMaxLength(100);
            entity.Property(e => e.StateName).HasMaxLength(50);
            entity.Property(e => e.TokenNo).HasMaxLength(50);
        });

        modelBuilder.Entity<ImportTblEmployeeHasLeft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportTblEmployeeHasLeft");

            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeName).HasMaxLength(200);
            entity.Property(e => e.ResignationDate).HasMaxLength(100);
        });

        modelBuilder.Entity<ImportTblEmployeeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportTblEmployeeMaster");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(100);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BloodGroup).HasMaxLength(25);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(150);
            entity.Property(e => e.DateOfBirth).HasMaxLength(100);
            entity.Property(e => e.Department).HasMaxLength(200);
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EmpAddress).HasMaxLength(500);
            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
            entity.Property(e => e.Esino)
                .HasMaxLength(100)
                .HasColumnName("ESINo");
            entity.Property(e => e.FatherName).HasMaxLength(200);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.IqamaNo).HasMaxLength(150);
            entity.Property(e => e.JoiningDt).HasMaxLength(100);
            entity.Property(e => e.Married).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(100);
            entity.Property(e => e.ProbationPeriod).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SalaryGrade)
                .HasMaxLength(50)
                .HasColumnName("salaryGrade");
            entity.Property(e => e.SalaryMode).HasMaxLength(50);
            entity.Property(e => e.SpouseName).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.ValidUpto).HasMaxLength(150);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<ImportTblEmployeeMaster1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportTblEmployeeMaster1");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(100);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BloodGroup).HasMaxLength(25);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(150);
            entity.Property(e => e.Conveyance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DateOfBirth).HasMaxLength(100);
            entity.Property(e => e.Department).HasMaxLength(200);
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EmpAddress).HasMaxLength(500);
            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
            entity.Property(e => e.Esic)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESIC");
            entity.Property(e => e.Esicemployer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESICEmployer");
            entity.Property(e => e.Esino)
                .HasMaxLength(100)
                .HasColumnName("ESINo");
            entity.Property(e => e.FatherName).HasMaxLength(200);
            entity.Property(e => e.Gender).HasMaxLength(100);
            entity.Property(e => e.Gratuity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HRA");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.IqamaNo).HasMaxLength(150);
            entity.Property(e => e.JoiningDt).HasMaxLength(100);
            entity.Property(e => e.Married).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.Pf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PF");
            entity.Property(e => e.Pfemployer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PFEmployer");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(100);
            entity.Property(e => e.ProbationPeriod).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SalaryGrade)
                .HasMaxLength(50)
                .HasColumnName("salaryGrade");
            entity.Property(e => e.SalaryMode).HasMaxLength(50);
            entity.Property(e => e.SpecialAllowance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SpouseName).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.ValidUpto).HasMaxLength(150);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<ImportTblEmployeeResigned>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportTblEmployeeResigned");

            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeName).HasMaxLength(200);
            entity.Property(e => e.ResignationDate).HasMaxLength(100);
        });

        modelBuilder.Entity<ImportTblEmployeeSalary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportTblEmployeeSalary");

            entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Conveyance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.Esic)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESIC");
            entity.Property(e => e.Esicemployer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ESICEmployer");
            entity.Property(e => e.Gratuity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HRA");
            entity.Property(e => e.Pf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PF");
            entity.Property(e => e.Pfemployer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PFEmployer");
            entity.Property(e => e.SpecialAllowance).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ImportedAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImportedAttendance");

            entity.Property(e => e.AttendanceTime).HasColumnType("datetime");
            entity.Property(e => e.CardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CurDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Iomode).HasColumnName("IOMode");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PunchingStatusType).HasMaxLength(20);
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Sno).HasColumnName("SNo");
        });

        modelBuilder.Entity<Kraform>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KRAForm");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentHead).HasMaxLength(250);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.JscasualTask).HasColumnName("JSCasualTask");
            entity.Property(e => e.Jsresposibilities).HasColumnName("JSResposibilities");
            entity.Property(e => e.KraFormId).ValueGeneratedOnAdd();
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LeaveApplication>(entity =>
        {
            entity.HasKey(e => e.LeaveApplicationId).HasName("PK__LeaveApp__038EC20D7226EDCC");

            entity.ToTable("LeaveApplication");

            entity.Property(e => e.LeaveApplicationId).HasColumnName("LeaveApplicationID");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FromHalfDay).HasMaxLength(50);
            entity.Property(e => e.Hrremarks).HasColumnName("HRRemarks");
            entity.Property(e => e.LeaveFrom).HasColumnType("datetime");
            entity.Property(e => e.LeaveTo).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.NoOfLeaveApplied).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NoOfLeaveSanction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RecommendedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.SanctionFrom).HasColumnType("datetime");
            entity.Property(e => e.SanctionFromHalfDay).HasMaxLength(50);
            entity.Property(e => e.SanctionTo).HasColumnType("datetime");
            entity.Property(e => e.SanctionToHalfDay).HasMaxLength(50);
            entity.Property(e => e.ToHalfDay).HasMaxLength(50);
        });

        modelBuilder.Entity<LeaveConfiguration>(entity =>
        {
            entity.HasKey(e => e.LeaveConfigurationId).HasName("PK__LeaveCon__A7A9E2E07D98A078");

            entity.ToTable("LeaveConfiguration");

            entity.Property(e => e.LeaveConfigurationId).HasColumnName("LeaveConfigurationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.GenderType).HasMaxLength(50);
            entity.Property(e => e.LeaveApplicableAfter).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LeaveTypeDeatils).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MaxCarryForward).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxLeave).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxconsecutiveLeave).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinimumLeave).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
        });

        modelBuilder.Entity<LeaveOpening>(entity =>
        {
            entity.HasKey(e => e.LeaveOpeningId).HasName("PK__LeaveOpe__D946A1D075F77EB0");

            entity.ToTable("LeaveOpening");

            entity.Property(e => e.LeaveOpeningId).HasColumnName("LeaveOpeningID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ElencashmentStatus).HasColumnName("ELEncashmentStatus");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LeaveOpening1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LeaveOpening");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.YearlyAnnounceLeave).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<LeaveSetting>(entity =>
        {
            entity.HasKey(e => e.LeaveSettingId).HasName("PK__LeaveSet__14D2F02C0499E8B0");

            entity.ToTable("LeaveSetting");

            entity.Property(e => e.LeaveSettingId).HasColumnName("LeaveSettingID");
            entity.Property(e => e.LeaveApplicableOn).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanHeader>(entity =>
        {
            entity.HasKey(e => e.LoanCode);

            entity.ToTable("LoanHeader");

            entity.Property(e => e.LoanCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AppInstDate).HasColumnType("datetime");
            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");
            entity.Property(e => e.BalanceAmount).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ClearedDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.InsAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsGranted).HasColumnName("isGranted");
            entity.Property(e => e.IsPaid).HasColumnName("isPaid");
            entity.Property(e => e.LoanAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.LoanId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LoanReason)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.LoanStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoanType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDetailsBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfInst).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.SanInstDate).HasColumnType("datetime");
            entity.Property(e => e.SanctionAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SanctionAmountC).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SanctionInsAmount).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<LoginDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoginDetail");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.IpAdress).HasMaxLength(150);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LogInTime).HasColumnName("LogIn_Time");
            entity.Property(e => e.LogOutTime).HasColumnName("LogOut_Time");
            entity.Property(e => e.LogStatus).HasMaxLength(50);
            entity.Property(e => e.LoginId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstChecklist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstChecklist");

            entity.Property(e => e.CheckListId).ValueGeneratedOnAdd();
            entity.Property(e => e.GenerateSequence).HasMaxLength(10);
            entity.Property(e => e.Head).HasMaxLength(200);
            entity.Property(e => e.Sid).HasColumnName("SID");
        });

        modelBuilder.Entity<MstEmployeeRating>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstEmployeeRating");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Finyear).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            entity.Property(e => e.RatingId).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId);

            entity.ToTable("mstPermission");

            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
        });

        modelBuilder.Entity<MstRatingParameter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstRatingParameter");

            entity.Property(e => e.ParameterId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MstRembursementType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mstRembursementType");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CreatedBY");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.RembursementTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RembursementTypeID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstSequence>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK_SID");

            entity.ToTable("MstSequence");

            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.Head).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsFinYear).HasColumnName("isFinYear");
            entity.Property(e => e.IscodeSeparator).HasColumnName("iscodeSeparator");
            entity.Property(e => e.LastValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LastValueUpdate).HasColumnType("numeric(19, 0)");
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.Separator).HasMaxLength(50);
            entity.Property(e => e.Start).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Value).HasMaxLength(10);
        });

        modelBuilder.Entity<MstStatusClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mstStatusClaim");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CreatedBY");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.StatusClaimId)
                .ValueGeneratedOnAdd()
                .HasColumnName("StatusClaimID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstTemplateType>(entity =>
        {
            entity.HasKey(e => e.TemplateId);

            entity.ToTable("MstTemplateType");

            entity.Property(e => e.TemplateType).HasMaxLength(50);
        });

        modelBuilder.Entity<MstWorkflowType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mstWorkflowType");

            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.WorkflowId).ValueGeneratedOnAdd();
            entity.Property(e => e.WorkflowType).HasMaxLength(50);
        });

        modelBuilder.Entity<NotImportOrgTree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("not_ImportOrgTree");

            entity.Property(e => e.EmployeeName).HasMaxLength(100);
            entity.Property(e => e.ManagerName).HasMaxLength(100);
        });

        modelBuilder.Entity<OnDutySlip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OnDutySlip");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerVisited).HasMaxLength(100);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.OnDutySlipId).ValueGeneratedOnAdd();
            entity.Property(e => e.TimeInOffice).HasMaxLength(50);
            entity.Property(e => e.TimeOfVisit).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrganisationTree>(entity =>
        {
            entity.HasKey(e => e.OrgTreeId).HasName("PK__Organisa__886C734384F9387B");

            entity.ToTable("OrganisationTree");

            entity.Property(e => e.OrgTreeId).HasColumnName("OrgTreeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
        });

        modelBuilder.Entity<PayrollAttendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("PK__Payroll___8B69263C5F7E2DAC");

            entity.ToTable("Payroll_Attendance");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.AttendanceStatus).HasMaxLength(10);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.SalaryCycleId).HasColumnName("SalaryCycleID");
        });

        modelBuilder.Entity<PayrollAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.AttendanceDetailId).HasName("PK__Payroll___77B34025634EBE90");

            entity.ToTable("Payroll_AttendanceDetail");

            entity.Property(e => e.AttendanceDetailId).HasColumnName("AttendanceDetailID");
            entity.Property(e => e.AbsentDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LateDeductionDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PresentDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalaryDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalLateDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeeklyOff).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PayrollAttendanceDetailFaf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_AttendanceDetailFAF");

            entity.Property(e => e.AbsentDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AttendanceDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AttendanceDetailID");
            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LateDeductionDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PresentDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalaryDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalLateDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WeeklyOff).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PayrollAttendanceFaf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_AttendanceFAF");

            entity.Property(e => e.AttendanceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AttendanceID");
            entity.Property(e => e.AttendanceStatus).HasMaxLength(10);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.SalaryCycleId).HasColumnName("SalaryCycleID");
        });

        modelBuilder.Entity<PayrollCategoryType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_CategoryType");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        modelBuilder.Entity<PayrollElencashment>(entity =>
        {
            entity.HasKey(e => e.ElencashmentId).HasName("PK__Payroll___ACAEDF1FB6DB61CD");

            entity.ToTable("Payroll_ELEncashment");

            entity.Property(e => e.ElencashmentId).HasColumnName("ELEncashmentID");
            entity.Property(e => e.BalanceLeave).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CurrentYearLeave).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ElencashmentActive).HasColumnName("ELEncashmentActive");
            entity.Property(e => e.Elopeninig)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ELOpeninig");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EncashAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EncashDate).HasColumnType("datetime");
            entity.Property(e => e.EncashLeave).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.UsedLeave).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PayrollEmployeeForm16Detail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_EmployeeForm16Details");

            entity.Property(e => e.AllowanceLess).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Balance12).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Conveyance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDateDate).HasColumnType("datetime");
            entity.Property(e => e.DeductionUnderChapter6).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeForm16DetailsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EmployeeForm16DetailsID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Entertainment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Epf1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EPF1");
            entity.Property(e => e.Epf2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EPF2");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.GrossSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HRA");
            entity.Property(e => e.LessReliefUnderSection89).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Lta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LTA");
            entity.Property(e => e.ProfitunderSection173)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProfitunderSection17_3");
            entity.Property(e => e.Section80Ccc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Section80CCC1");
            entity.Property(e => e.Section80Ccc2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Section80CCC2");
            entity.Property(e => e.Section80Ccd1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Section80CCD1");
            entity.Property(e => e.Section80Ccd2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Section80CCD2");
            entity.Property(e => e.TaxOnEmployement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxOnTotalIncome).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPayable1213).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPayable1415)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TaxPayable14_15");
            entity.Property(e => e.TotalAll).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalIncome).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValueOfPerquisite).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PayrollEmployeePerquisitesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_EmployeePerquisitesDetails");

            entity.Property(e => e.AmountRecoveredFromEmployee).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountchargabletoTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AsPerRule).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeePerquisitesDetails).ValueGeneratedOnAdd();
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.MaxValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PerquisitesId).HasColumnName("PerquisitesID");
        });

        modelBuilder.Entity<PayrollEsicsetting>(entity =>
        {
            entity.HasKey(e => e.EsicsettingId).HasName("PK__Payroll___7124D1A4297722B6");

            entity.ToTable("Payroll_ESICSetting");

            entity.Property(e => e.EsicsettingId).HasColumnName("ESICSettingID");
            entity.Property(e => e.AmountFrom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountTo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContributerPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Contributor).HasMaxLength(50);
            entity.Property(e => e.EsicsettingActive).HasColumnName("ESICSettingActive");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<PayrollForm16Head>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_Form16Head");

            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Form16HeadId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Form16HeadID");
            entity.Property(e => e.Form16HeadName).HasMaxLength(100);
            entity.Property(e => e.SalaryHeadTypeId).HasColumnName("SalaryHeadTypeID");
        });

        modelBuilder.Entity<PayrollIncentiveTranfer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_IncentiveTranfer");

            entity.Property(e => e.CompanyAccountId).HasColumnName("CompanyAccountID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.IncentiveTranferId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IncentiveTranferID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.SalaryPaid).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PayrollLateDeduction>(entity =>
        {
            entity.HasKey(e => e.LateDeductionId).HasName("PK__Payroll___4E2E59C0648FFE2F");

            entity.ToTable("Payroll_LateDeduction");

            entity.Property(e => e.LateDeductionId).HasColumnName("LateDeductionID");
            entity.Property(e => e.AllowLateDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Deduction).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
        });

        modelBuilder.Entity<PayrollLoanApplication>(entity =>
        {
            entity.HasKey(e => e.LoanAppId).HasName("PK__Payroll___7A516B9AD2A947DE");

            entity.ToTable("Payroll_LoanApplication");

            entity.Property(e => e.LoanAppId).HasColumnName("LoanAppID");
            entity.Property(e => e.AppInstDate).HasColumnType("datetime");
            entity.Property(e => e.ApplyDate).HasColumnType("datetime");
            entity.Property(e => e.BalanceAmount).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ClearedDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.InsAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsGranted).HasColumnName("isGranted");
            entity.Property(e => e.IsPaid).HasColumnName("isPaid");
            entity.Property(e => e.LoanAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LoanReason).HasMaxLength(500);
            entity.Property(e => e.LoanTypeId).HasColumnName("LoanTypeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SanInstDate).HasColumnType("datetime");
            entity.Property(e => e.SanctionAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SanctionInsAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PayrollLoanDetail>(entity =>
        {
            entity.HasKey(e => e.LoanDetailId).HasName("PK__Payroll___760C10287C038FAE");

            entity.ToTable("Payroll_LoanDetail");

            entity.Property(e => e.LoanDetailId).HasColumnName("LoanDetailID");
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.InstAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InstDate).HasColumnType("datetime");
            entity.Property(e => e.IsCancelled).HasColumnName("isCancelled");
            entity.Property(e => e.IsGiven).HasColumnName("isGiven");
            entity.Property(e => e.LoanId).HasColumnName("LoanID");
        });

        modelBuilder.Entity<PayrollOtherEntitlementDetail>(entity =>
        {
            entity.HasKey(e => e.OtherEntitlementId).HasName("PK__Payroll___0CB643C03DF7BA6B");

            entity.ToTable("Payroll_OtherEntitlementDetail");

            entity.Property(e => e.OtherEntitlementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OtherEntitlementID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
        });

        modelBuilder.Entity<PayrollOtherEntitlementDetailFaf>(entity =>
        {
            entity.HasKey(e => e.OtherEntitlementId).HasName("PK__Payroll___0CB643C0818877EF");

            entity.ToTable("Payroll_OtherEntitlementDetailFAF");

            entity.Property(e => e.OtherEntitlementId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OtherEntitlementID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
        });

        modelBuilder.Entity<PayrollPerquisitesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_PerquisitesDetails");

            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.MaxValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("maxValue");
            entity.Property(e => e.PerquisitesId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PerquisitesID");
            entity.Property(e => e.PerquisitesName).HasMaxLength(100);
        });

        modelBuilder.Entity<PayrollPfsetting>(entity =>
        {
            entity.HasKey(e => e.PfsettingId).HasName("PK__Payroll___4681E4193C1FE2D6");

            entity.ToTable("Payroll_PFSetting");

            entity.Property(e => e.PfsettingId).HasColumnName("PFSettingID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContributionPercent).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Contributor).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PfsettingActive).HasColumnName("PFSettingActive");
            entity.Property(e => e.Pftype)
                .HasMaxLength(50)
                .HasColumnName("PFType");
        });

        modelBuilder.Entity<PayrollProfessionalTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_ProfessionalTax");

            entity.Property(e => e.AmountFrom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountPayable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountTo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProfessionalTaxId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ProfessionalTaxID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<PayrollRembursementDetail>(entity =>
        {
            entity.HasKey(e => e.RembursementDetailId).HasName("PK__Payroll___881B1A47B44BF443");

            entity.ToTable("Payroll_RembursementDetail");

            entity.Property(e => e.RembursementDetailId).HasColumnName("RembursementDetailID");
            entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.RembursementHeadId).HasColumnName("RembursementHeadID");
        });

        modelBuilder.Entity<PayrollSalaryDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryDetailId).HasName("PK__Payroll___EE7B1FE4B84FF36B");

            entity.ToTable("Payroll_SalaryDetail");

            entity.Property(e => e.SalaryDetailId).HasColumnName("SalaryDetailID");
            entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
            entity.Property(e => e.SalaryHeaderId).HasColumnName("SalaryHeaderID");
        });

        modelBuilder.Entity<PayrollSalaryDetailFaf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_SalaryDetailFAF");

            entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.SalaryDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SalaryDetailID");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
            entity.Property(e => e.SalaryHeaderId).HasColumnName("SalaryHeaderID");
        });

        modelBuilder.Entity<PayrollSalaryHeader>(entity =>
        {
            entity.HasKey(e => e.SalaryHeaderId).HasName("PK__Payroll___A6876495FBC66FBB");

            entity.ToTable("Payroll_SalaryHeader");

            entity.Property(e => e.SalaryHeaderId).HasColumnName("SalaryHeaderID");
            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EntitlementVerified).HasDefaultValue(false);
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.IncentiveVerified)
                .HasDefaultValue(false)
                .HasColumnName("incentiveVerified");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.SalaryVerified).HasDefaultValue(false);
        });

        modelBuilder.Entity<PayrollSalaryHeaderFaf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_SalaryHeaderFAF");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EntitlementVerified).HasDefaultValue(false);
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.IncentiveVerified)
                .HasDefaultValue(false)
                .HasColumnName("incentiveVerified");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.SalaryHeaderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SalaryHeaderID");
            entity.Property(e => e.SalaryVerified).HasDefaultValue(false);
        });

        modelBuilder.Entity<PayrollSalaryHold>(entity =>
        {
            entity.HasKey(e => e.SalaryHoldId).HasName("PK__Payroll___7AB4316FAC1F5663");

            entity.ToTable("Payroll_SalaryHold");

            entity.Property(e => e.SalaryHoldId).HasColumnName("SalaryHoldID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
        });

        modelBuilder.Entity<PayrollSalaryIncrement>(entity =>
        {
            entity.HasKey(e => e.SalaryIncrementId).HasName("PK__Payroll___1A976332C00CB378");

            entity.ToTable("Payroll_SalaryIncrement");

            entity.Property(e => e.SalaryIncrementId).HasColumnName("SalaryIncrementID");
            entity.Property(e => e.AmountTobe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Ctc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTC");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.IncrementAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IncrementType).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PercentageIncrement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreviousCtc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PreviousCTC");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RequstedDate).HasColumnType("datetime");
            entity.Property(e => e.Wefdate)
                .HasColumnType("datetime")
                .HasColumnName("wefdate");
        });

        modelBuilder.Entity<PayrollSalaryStructure>(entity =>
        {
            entity.HasKey(e => e.SalaryStructureId).HasName("PK__Payroll___49B48DF61DB06A4F");

            entity.ToTable("Payroll_SalaryStructure");

            entity.Property(e => e.SalaryStructureId).HasColumnName("SalaryStructureID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Formula).HasMaxLength(500);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValueBy).HasMaxLength(50);
        });

        modelBuilder.Entity<PayrollSalaryTranfer>(entity =>
        {
            entity.HasKey(e => e.SalaryTranferId).HasName("PK__Payroll___A711EC4FF02834BB");

            entity.ToTable("Payroll_SalaryTranfer");

            entity.Property(e => e.SalaryTranferId).HasColumnName("SalaryTranferID");
            entity.Property(e => e.CompanyAccountId).HasColumnName("CompanyAccountID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.SalaryPaid).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PayrollTdsadjustmentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_TDSAdjustmentDetail");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
            entity.Property(e => e.TdsadjustmentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TDSAdjustmentID");
        });

        modelBuilder.Entity<PayrollTdsclaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_TDSClaim");

            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CreatedBY");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.Form16Uploaded).HasDefaultValue(1);
            entity.Property(e => e.GeneralRemarks).HasMaxLength(500);
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ReviewerTo).HasMaxLength(50);
            entity.Property(e => e.TdsclaimId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TDSClaimID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayrollTdsclaimDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_TDSClaimDetail");

            entity.Property(e => e.ApprovedAmount)
                .HasDefaultValue(0.00m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.BilledAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClaimStatusId).HasColumnName("ClaimStatusID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.TdsclaimDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TDSClaimDetailID");
            entity.Property(e => e.TdsclaimId).HasColumnName("TDSClaimID");
            entity.Property(e => e.TdstypeId).HasColumnName("TDSTypeID");
        });

        modelBuilder.Entity<PayrollTdsform16>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_TDSForm16");

            entity.Property(e => e.ApprovedAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BilledAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.TdsclaimId).HasColumnName("TDSClaimID");
            entity.Property(e => e.Tdsform16Active).HasColumnName("TDSForm16Active");
            entity.Property(e => e.Tdsform16Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("TDSForm16ID");
            entity.Property(e => e.Tdstype).HasColumnName("TDSType");
        });

        modelBuilder.Entity<PayrollTdspriorInvestment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_TDSPriorInvestment");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountDifference).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CreatedBY");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.TdspriorInvestmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TDSPriorInvestmentID");
            entity.Property(e => e.TdstypeId).HasColumnName("TDSTypeID");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayrollTdssetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_TDSSetting");

            entity.Property(e => e.AmountExempted).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountExemptedto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rebate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TdssettingActive).HasColumnName("TDSSettingActive");
            entity.Property(e => e.TdssettingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TDSSettingID");
        });

        modelBuilder.Entity<PayrollTdstype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_TDSType");

            entity.Property(e => e.TdstypeActive).HasColumnName("TDSTypeActive");
            entity.Property(e => e.TdstypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TDSTypeID");
            entity.Property(e => e.TdstypeName)
                .HasMaxLength(100)
                .HasColumnName("TDSTypeName");
        });

        modelBuilder.Entity<PfemployerContribution>(entity =>
        {
            entity.HasKey(e => e.Pfecid).HasName("PK__PFEmploy__19F2DD4D635B4D22");

            entity.ToTable("PFEmployerContribution");

            entity.Property(e => e.Pfecid).HasColumnName("PFECID");
            entity.Property(e => e.AdminCharge)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Admin_Charge");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EdliAdminCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EDLI_Admin_Charges");
            entity.Property(e => e.EdliCharges)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EDLI_Charges");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Epfamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EPFAmount");
            entity.Property(e => e.Epsamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("EPSAmount");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Ncpdays)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NCPDays");
            entity.Property(e => e.Pfecactive).HasColumnName("PFECActive");
            entity.Property(e => e.RefundAdvance).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<RecruitmentResourceType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Recruitment_ResourceType");

            entity.Property(e => e.ResourceDescription).HasMaxLength(100);
            entity.Property(e => e.ResourceType).HasMaxLength(250);
            entity.Property(e => e.ResourceTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ResourceTypeID");
        });

        modelBuilder.Entity<RecruitmentTradeCategoryType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Recruitment_TradeCategoryType");

            entity.Property(e => e.CvtypeId).HasColumnName("CVTypeID");
            entity.Property(e => e.ResourceTypeId).HasColumnName("ResourceTypeID");
            entity.Property(e => e.TradeCategoryDescription).HasMaxLength(100);
            entity.Property(e => e.TradeCategoryType).HasMaxLength(250);
            entity.Property(e => e.TradeCategoryTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TradeCategoryTypeID");
        });

        modelBuilder.Entity<RembursementClaim>(entity =>
        {
            entity.ToTable("RembursementClaim");

            entity.Property(e => e.RembursementClaimId).HasColumnName("RembursementClaimID");
            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CreatedBY");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.GeneralRemarks).HasMaxLength(500);
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.ReviewerTo).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RembursementClaimDetail>(entity =>
        {
            entity.HasKey(e => e.RclaimDetailId);

            entity.ToTable("RembursementClaimDetail");

            entity.Property(e => e.RclaimDetailId).HasColumnName("RClaimDetailID");
            entity.Property(e => e.ApprovedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.BilledAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClaimStatusId).HasColumnName("ClaimStatusID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RembursementClaimId).HasColumnName("RembursementClaimID");
            entity.Property(e => e.RembursementTypeId).HasColumnName("RembursementTypeID");
        });

        modelBuilder.Entity<SequenceMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sequenceMaster");

            entity.Property(e => e.Head)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Increment).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.LastValue).HasColumnType("numeric(19, 0)");
            entity.Property(e => e.Prefix)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Start).HasColumnType("numeric(19, 0)");
            entity.Property(e => e.Stop).HasColumnType("numeric(19, 0)");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
        });

        modelBuilder.Entity<SettingBulletinBoard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bulletin__3214EC2767F770CF");

            entity.ToTable("Setting_BulletinBoard");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MessageType).HasMaxLength(50);
        });

        modelBuilder.Entity<SettingEmployeeOfTheMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Setting_EmployeeOfTheMonth");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmpMonthId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EmpMonthID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Month).HasMaxLength(50);
        });

        modelBuilder.Entity<SettingLoanType>(entity =>
        {
            entity.HasKey(e => e.LoanTypeId).HasName("PK__Setting___19466B4F63377598");

            entity.ToTable("Setting_LoanType");

            entity.Property(e => e.LoanTypeId).HasColumnName("LoanTypeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.LoanType).HasMaxLength(100);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<SettingSm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Setting_SMS");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.SmsSettingId).ValueGeneratedOnAdd();
            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .HasColumnName("UID");
            entity.Property(e => e.Upassword)
                .HasMaxLength(50)
                .HasColumnName("UPassword");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .HasColumnName("URL");
            entity.Property(e => e.UserName).HasMaxLength(200);
        });

        modelBuilder.Entity<SettingSmsaccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Setting_SMSAccount");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SmsaccountActive).HasColumnName("SMSAccountActive");
            entity.Property(e => e.SmsaccountId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SMSAccountId");
            entity.Property(e => e.Smslimit).HasColumnName("SMSLimit");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SettingsAlertRemainder>(entity =>
        {
            entity.HasKey(e => e.AlertRemainderId).HasName("PK__Settings__6EF4FBB8803B0D9B");

            entity.ToTable("Settings_AlertRemainder");

            entity.Property(e => e.AlertRemainderId).HasColumnName("AlertRemainderID");
            entity.Property(e => e.AlertReminder).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<SettingsAsset>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__Settings__434923728E1E34A1");

            entity.ToTable("Settings_Asset");

            entity.Property(e => e.AssetId).HasColumnName("AssetID");
            entity.Property(e => e.AssetName).HasMaxLength(100);
            entity.Property(e => e.AssetType).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<SettingsAttendanceSchedule>(entity =>
        {
            entity.HasKey(e => e.AttendanceScheduleId).HasName("PK__Settings__01F2633F255C790F");

            entity.ToTable("Settings_AttendanceSchedule");

            entity.Property(e => e.AttendanceScheduleId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("AttendanceScheduleID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Interval).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.MannualTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<SettingsBank>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("PK__Settings__AA08CB333BF2F7FE");

            entity.ToTable("Settings_Bank");

            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsBankBranch>(entity =>
        {
            entity.HasKey(e => e.BankBranchId).HasName("PK__Settings__135DBA95B4639088");

            entity.ToTable("Settings_BankBranch");

            entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BranchAddress).HasMaxLength(200);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.Ifscno)
                .HasMaxLength(100)
                .HasColumnName("IFSCNo");
            entity.Property(e => e.PhoneNo).HasMaxLength(50);
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.Bank).WithMany(p => p.SettingsBankBranches)
                .HasForeignKey(d => d.BankId)
                .HasConstraintName("FK_Settings_BankBranch_Settings_Bank");
        });

        modelBuilder.Entity<SettingsBloodGroup>(entity =>
        {
            entity.HasKey(e => e.BloodGroupId).HasName("PK__Settings__4398C6AFEABD2FCC");

            entity.ToTable("Settings_BloodGroup");

            entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");
            entity.Property(e => e.BloodGroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_City");

            entity.Property(e => e.CityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CityID");
            entity.Property(e => e.CityName).HasMaxLength(100);
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<SettingsCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Settings__2D971C4C03317E3D");

            entity.ToTable("Settings_Company");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Collectorate).HasMaxLength(100);
            entity.Property(e => e.CompanyAddress).HasMaxLength(500);
            entity.Property(e => e.CompanyGroupId).HasColumnName("CompanyGroupID");
            entity.Property(e => e.CompanyImgUrl).HasMaxLength(100);
            entity.Property(e => e.CompanyLicNo).HasMaxLength(100);
            entity.Property(e => e.CompanyLogo).HasColumnType("image");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CstNo).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EccNo).HasMaxLength(100);
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.ExciseAddress).HasMaxLength(100);
            entity.Property(e => e.ExciseDiv).HasMaxLength(100);
            entity.Property(e => e.ExciseRange).HasMaxLength(100);
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.Hgstno)
                .HasMaxLength(100)
                .HasColumnName("HGSTno");
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PhoneNo).HasMaxLength(50);
            entity.Property(e => e.PrimaryOwner).HasMaxLength(50);
            entity.Property(e => e.RegNo).HasMaxLength(100);
            entity.Property(e => e.ServiceTaxNo).HasMaxLength(100);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TinNo).HasMaxLength(50);
            entity.Property(e => e.Website).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsCompanyAccount>(entity =>
        {
            entity.HasKey(e => e.CompanyAccountId).HasName("PK__Settings__6ADC163F091BA537");

            entity.ToTable("Settings_CompanyAccount");

            entity.Property(e => e.CompanyAccountId).HasColumnName("CompanyAccountID");
            entity.Property(e => e.AccountNo).HasMaxLength(100);
            entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<SettingsCompanyGroup>(entity =>
        {
            entity.HasKey(e => e.CompanyGroupId).HasName("PK__Settings__3503DFC98BA4B933");

            entity.ToTable("Settings_CompanyGroup");

            entity.Property(e => e.CompanyGroupId).HasColumnName("CompanyGroupID");
            entity.Property(e => e.CompanyGroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Settings__10D160BFD069B2C3");

            entity.ToTable("Settings_Country");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsCourse>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Settings__C92D7187BE0E8231");

            entity.ToTable("Settings_Course");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CourseName).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Skills).HasMaxLength(150);
        });

        modelBuilder.Entity<SettingsCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PK__Settings__14470B10A95EA720");

            entity.ToTable("Settings_Currency");

            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencyCode).HasMaxLength(10);
            entity.Property(e => e.CurrencyName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsDepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Settings__B2079BCDE05A86EB");

            entity.ToTable("Settings_Department");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<SettingsDesignation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__Settings__BABD603E6E913C9F");

            entity.ToTable("Settings_Designation");

            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<SettingsDocumentType>(entity =>
        {
            entity.HasKey(e => e.DocumentTypeId).HasName("PK__Settings__DBA390C1B19CAC09");

            entity.ToTable("Settings_DocumentType");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.DocumentTypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_EMail");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmailActive).HasColumnName("EMailActive");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MailSettingId).ValueGeneratedOnAdd();
            entity.Property(e => e.MailType).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PortNo).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ServerName).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsEmployeeStatus>(entity =>
        {
            entity.HasKey(e => e.EmployeeStatusId).HasName("PK__Settings__360993CC592E4852");

            entity.ToTable("Settings_EmployeeStatus");

            entity.Property(e => e.EmployeeStatusId).HasColumnName("EmployeeStatusID");
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsExperience>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_Experience");

            entity.Property(e => e.ExperienceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ExperienceID");
            entity.Property(e => e.ExperienceName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsFinancialYear>(entity =>
        {
            entity.HasKey(e => e.FinancialYearId).HasName("PK__Settings__6ECE4CF14D469846");

            entity.ToTable("Settings_FinancialYear");

            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<SettingsForm>(entity =>
        {
            entity.HasKey(e => e.FormId).HasName("PK__Settings__FB05B7BDFF7B3F10");

            entity.ToTable("Settings_Form");

            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FormName).HasMaxLength(100);
            entity.Property(e => e.FormUrl).HasMaxLength(200);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

            entity.HasOne(d => d.Module).WithMany(p => p.SettingsForms)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_Settings_Form_Settings_Module");
        });

        modelBuilder.Entity<SettingsGrade>(entity =>
        {
            entity.HasKey(e => e.SalaryGradeId).HasName("PK__Settings__C90BBC466477ECF3");

            entity.ToTable("Settings_Grade");

            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaxGrossSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MinGrossSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsHoliday>(entity =>
        {
            entity.HasKey(e => e.HolidayId).HasName("PK__Settings__2D35D59A75A278F5");

            entity.ToTable("Settings_Holiday");

            entity.Property(e => e.HolidayId).HasColumnName("HolidayID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.HolidayDate).HasColumnType("datetime");
            entity.Property(e => e.HolidayDateTo).HasColumnType("datetime");
            entity.Property(e => e.HolidayName).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<SettingsIuserRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_IUserRole");

            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.Uimport).HasColumnName("UImport");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserIroleId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserIRoleID");
        });

        modelBuilder.Entity<SettingsLeaveType>(entity =>
        {
            entity.HasKey(e => e.LeaveTypeId).HasName("PK__Settings__43BE8FF4C559E96F");

            entity.ToTable("Settings_LeaveType");

            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");
            entity.Property(e => e.LeaveDescription).HasMaxLength(100);
            entity.Property(e => e.LeaveType).HasMaxLength(50);
        });

        modelBuilder.Entity<SettingsLeavingReason>(entity =>
        {
            entity.HasKey(e => e.LeavingReasonId).HasName("PK__Settings__25FE27DBD1419498");

            entity.ToTable("Settings_LeavingReason");

            entity.Property(e => e.LeavingReasonId).HasColumnName("LeavingReasonID");
            entity.Property(e => e.LeavingReason).HasMaxLength(250);
        });

        modelBuilder.Entity<SettingsLoan>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PK_Setting_Loan");

            entity.ToTable("Settings_Loan");

            entity.Property(e => e.LoanId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LoanID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LoanCode).HasMaxLength(50);
        });

        modelBuilder.Entity<SettingsLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Settings__E7FEA477BC89C0F0");

            entity.ToTable("Settings_Location");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.LocationAddress).HasMaxLength(500);
            entity.Property(e => e.LocationName).HasMaxLength(100);
            entity.Property(e => e.PhoneNo).HasMaxLength(50);
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.Company).WithMany(p => p.SettingsLocations)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Settings_Location_Settings_Company");
        });

        modelBuilder.Entity<SettingsMachineConfiguration>(entity =>
        {
            entity.HasKey(e => e.MachineConfigurationId).HasName("PK__Settings__F0AA595805E3CDB6");

            entity.ToTable("Settings_MachineConfiguration");

            entity.Property(e => e.MachineConfigurationId).HasColumnName("MachineConfigurationID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.MachineType).HasMaxLength(50);
        });

        modelBuilder.Entity<SettingsMaritalStatus>(entity =>
        {
            entity.HasKey(e => e.MaritalStatusId).HasName("PK__Settings__C8B1BA52C225D8D4");

            entity.ToTable("Settings_MaritalStatus");

            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MaritalStatusName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__Settings__2B747787164452B1");

            entity.ToTable("Settings_Module");

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModuleIcon).HasMaxLength(100);
            entity.Property(e => e.ModuleName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_Month");

            entity.Property(e => e.MonthId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MonthID");
            entity.Property(e => e.MonthName).HasMaxLength(50);
        });

        modelBuilder.Entity<SettingsNationaity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_Nationaity");

            entity.Property(e => e.Nationaity).HasMaxLength(100);
            entity.Property(e => e.NationaityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("NationaityID");
        });

        modelBuilder.Entity<SettingsPftype>(entity =>
        {
            entity.HasKey(e => e.PftypeId).HasName("PK__Settings__740C932B8F0CB7FE");

            entity.ToTable("Settings_PFType");

            entity.Property(e => e.PftypeId).HasColumnName("PFTypeID");
            entity.Property(e => e.Pftype).HasColumnName("PFType");
            entity.Property(e => e.PftypeActive).HasColumnName("PFTypeActive");
        });

        modelBuilder.Entity<SettingsPolicyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_PolicyDetails");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DocumentLogo).HasColumnType("image");
            entity.Property(e => e.DocumentUrl).HasColumnName("DocumentURl");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PolicyDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PolicyDetailID");
            entity.Property(e => e.PolicyDetailName).HasMaxLength(400);
        });

        modelBuilder.Entity<SettingsQualification>(entity =>
        {
            entity.HasKey(e => e.QualificationId).HasName("PK__Settings__C95C128A6EA7A713");

            entity.ToTable("Settings_Qualification");

            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.Qualification).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsQuerry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_Querry");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EstimateType).HasMaxLength(50);
            entity.Property(e => e.QuerryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("QuerryID");
        });

        modelBuilder.Entity<SettingsReference>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_Reference");

            entity.Property(e => e.ReferenceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ReferenceID");
            entity.Property(e => e.ReferenceName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsRelationShip>(entity =>
        {
            entity.HasKey(e => e.RelationShipId).HasName("PK__Settings__BAECEFCD2BB709C6");

            entity.ToTable("Settings_RelationShip");

            entity.Property(e => e.RelationShipId).HasColumnName("RelationShipID");
            entity.Property(e => e.RelationShip).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsReligion>(entity =>
        {
            entity.HasKey(e => e.ReligionId).HasName("PK__Settings__D3ADAB4AC36CDE58");

            entity.ToTable("Settings_Religion");

            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.ReligionName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsReportAccordianName>(entity =>
        {
            entity.HasKey(e => e.ReportPermissionId).HasName("PK__Settings__0C4B4F117A22AC65");

            entity.ToTable("Settings_ReportAccordianName");

            entity.Property(e => e.ReportPermissionId).HasColumnName("ReportPermissionID");
            entity.Property(e => e.AccordianId).HasColumnName("AccordianID");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<SettingsReportPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__Settings__EFA6FB2F5FA690A2");

            entity.ToTable("Settings_ReportPermission");

            entity.Property(e => e.AccordianId).HasColumnName("AccordianID");
            entity.Property(e => e.IsPermission).HasColumnName("isPermission");
            entity.Property(e => e.ReportPermissionId).HasColumnName("ReportPermissionID");
        });

        modelBuilder.Entity<SettingsRestrictedInterview>(entity =>
        {
            entity.HasKey(e => e.RestrictedInterviewId).HasName("PK__Settings__DF4071132DA7A64D");

            entity.ToTable("Settings_RestrictedInterview");

            entity.Property(e => e.RestrictedInterviewId).HasColumnName("RestrictedInterviewID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CvtypeId).HasColumnName("CVTypeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
        });

        modelBuilder.Entity<SettingsSalaryCycle>(entity =>
        {
            entity.HasKey(e => e.SalaryCycleId).HasName("PK__Settings__0CB849363D3B225B");

            entity.ToTable("Settings_SalaryCycle");

            entity.Property(e => e.SalaryCycleId).HasColumnName("SalaryCycleID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SettingsSalaryHead>(entity =>
        {
            entity.HasKey(e => e.SalaryHeadId).HasName("PK__Settings__0293EF2119DFD96B");

            entity.ToTable("Settings_SalaryHead");

            entity.Property(e => e.SalaryHeadId).HasColumnName("SalaryHeadID");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.SalaryComponentName).HasMaxLength(100);
            entity.Property(e => e.SalaryHeadTypeId).HasColumnName("SalaryHeadTypeID");
            entity.Property(e => e.Wef).HasColumnName("WEF");
        });

        modelBuilder.Entity<SettingsSalaryHeadType>(entity =>
        {
            entity.HasKey(e => e.SalaryHeadTypeId).HasName("PK__Settings__71B2C99E3243FC11");

            entity.ToTable("Settings_SalaryHeadType");

            entity.Property(e => e.SalaryHeadTypeId).HasColumnName("SalaryHeadTypeID");
            entity.Property(e => e.SalaryHeadTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<SettingsSalaryMode>(entity =>
        {
            entity.HasKey(e => e.SalaryModeId).HasName("PK__Settings__73A72811364FFB44");

            entity.ToTable("Settings_SalaryMode");

            entity.Property(e => e.SalaryModeId).HasColumnName("SalaryModeID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.SalaryMode).HasMaxLength(50);
        });

        modelBuilder.Entity<SettingsState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__Settings__C3BA3B5A552844AC");

            entity.ToTable("Settings_State");

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.StateName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateSettingId).HasName("PK__Settings__E86EF8B2C58A72FC");

            entity.ToTable("Settings_Template");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.TemplateFor).HasMaxLength(50);
            entity.Property(e => e.TemplateType).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Settings__1788CCAC33DE60B8");

            entity.ToTable("Settings_User");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.UserName).HasMaxLength(100);

            entity.HasOne(d => d.UserGroup).WithMany(p => p.SettingsUsers)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("FK_Settings_User_Settings_UserGroup");
        });

        modelBuilder.Entity<SettingsUserGroup>(entity =>
        {
            entity.HasKey(e => e.UserGroupId).HasName("PK__Settings__FA5A61E0FDF1971F");

            entity.ToTable("Settings_UserGroup");

            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.UserGroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsUserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId).HasName("PK__Settings__3D978A55FCCBE58A");

            entity.ToTable("Settings_UserRole");

            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.IsPermission).HasColumnName("isPermission");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.Uapproval).HasColumnName("UApproval");
            entity.Property(e => e.Udelete).HasColumnName("UDelete");
            entity.Property(e => e.Umodify).HasColumnName("UModify");
            entity.Property(e => e.Uprint).HasColumnName("UPrint");
            entity.Property(e => e.Uread).HasColumnName("URead");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Uwrite).HasColumnName("UWrite");

            entity.HasOne(d => d.Form).WithMany(p => p.SettingsUserRoles)
                .HasForeignKey(d => d.FormId)
                .HasConstraintName("FK_Settings_UserRole_Settings_Form");

            entity.HasOne(d => d.Module).WithMany(p => p.SettingsUserRoles)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_Settings_UserRole_Settings_Module");
        });

        modelBuilder.Entity<SettingsVigilance>(entity =>
        {
            entity.HasKey(e => e.VigilanceId).HasName("PK__Settings__2A1CA8C1398368A5");

            entity.ToTable("Settings_Vigilance");

            entity.Property(e => e.VigilanceId).HasColumnName("VigilanceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.VigilanceName).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsVisaType>(entity =>
        {
            entity.HasKey(e => e.VisaTypeId).HasName("PK__Settings__9522E679F85EF36D");

            entity.ToTable("Settings_VisaType");

            entity.Property(e => e.VisaTypeId).HasColumnName("VisaTypeID");
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<SettingsZone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Settings_Zone");

            entity.Property(e => e.ZoneId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ZoneID");
            entity.Property(e => e.ZoneName).HasMaxLength(100);
        });

        modelBuilder.Entity<Smshistory>(entity =>
        {
            entity.HasKey(e => e.SmshistoryId).HasName("PK__SMSHisto__339A06A93C6089F8");

            entity.ToTable("SMSHistory");

            entity.Property(e => e.SmshistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SMSHistoryId");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MessageId).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(15);
            entity.Property(e => e.SmshistoryActive).HasColumnName("SMSHistoryActive");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TemplateType).HasMaxLength(100);
        });

        modelBuilder.Entity<Smssetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SMSSetti__3214EC274CD9663F");

            entity.ToTable("SMSSetting");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EmailId)
                .HasMaxLength(200)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActiveStaus).HasColumnName("isActiveStaus");
            entity.Property(e => e.UpateDate).HasColumnType("datetime");
            entity.Property(e => e.UpatedBy).HasMaxLength(50);
            entity.Property(e => e.WorkFlow).HasMaxLength(50);
        });

        modelBuilder.Entity<TblDeviceToken>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(" tblDeviceToken");

            entity.Property(e => e.DeviceTokenId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblDeviceToken1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDeviceToken");

            entity.Property(e => e.DeviceTokenId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblEmployeeHasLeft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblEmployeeHasLeft");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeName).HasMaxLength(200);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ResignationDate).HasColumnType("datetime");
            entity.Property(e => e.TblEmployeehasLeftId)
                .ValueGeneratedOnAdd()
                .HasColumnName("tblEmployeehasLeftId");
        });

        modelBuilder.Entity<TblEmployeeOfTheMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblEmployeeOfTheMonth");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmpMonthId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EmpMonthID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Month).HasMaxLength(50);
        });

        modelBuilder.Entity<TblEmployeeRating>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblEmployeeRating");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Finyear).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TblRatingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("tblRatingId");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblResignedEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblResignedEmployee");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeName).HasMaxLength(200);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ResignationDate).HasColumnType("datetime");
            entity.Property(e => e.ResignedEmployeeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblTaskAssignment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTaskAssignment");

            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CreatedBY");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EstimatedTimeFrom).HasColumnType("datetime");
            entity.Property(e => e.EstimatedTimeTo).HasColumnType("datetime");
            entity.Property(e => e.GraceEstimatedTime).HasColumnType("datetime");
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.Priority).HasMaxLength(50);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.TaskAssignmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TaskAssignmentID");
            entity.Property(e => e.TaskStatus).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTaskAssignmentDisapproved>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTaskAssignment_Disapproved");

            entity.Property(e => e.DisapprovedDate).HasColumnType("datetime");
            entity.Property(e => e.DisapprovedId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DisapprovedID");
            entity.Property(e => e.TaskAssignmentId).HasColumnName("TaskAssignmentID");
        });

        modelBuilder.Entity<TblTroubleTicket>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTroubleTicket");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("CreatedBY");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EstimatedTime).HasColumnType("datetime");
            entity.Property(e => e.IsActiveStatus).HasColumnName("isActiveStatus");
            entity.Property(e => e.QuerryId).HasColumnName("QuerryID");
            entity.Property(e => e.SolvedBy).HasMaxLength(50);
            entity.Property(e => e.SolvedDate).HasColumnType("datetime");
            entity.Property(e => e.TroubleTicketId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TroubleTicketID");
        });

        modelBuilder.Entity<TblWish>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblWishes");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.SentBy).HasMaxLength(50);
            entity.Property(e => e.SentTo).HasMaxLength(50);
            entity.Property(e => e.WishFor).HasMaxLength(25);
            entity.Property(e => e.WishId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TbluserEnroll>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBLUSER_ENROLL");

            entity.Property(e => e.Adminopt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("ADMINOPT");
            entity.Property(e => e.Changepassword)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("CHANGEPASSWORD");
            entity.Property(e => e.Dbconfig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("DBCONFIG");
            entity.Property(e => e.Deployment)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("DEPLOYMENT");
            entity.Property(e => e.Enrollment)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("ENROLLMENT");
            entity.Property(e => e.Enrollmentopt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("ENROLLMENTOPT");
            entity.Property(e => e.Farconfig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("FARCONFIG");
            entity.Property(e => e.PassWord)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PASS_WORD");
            entity.Property(e => e.Portsettings)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("PORTSETTINGS");
            entity.Property(e => e.Readertempmanagement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("READERTEMPMANAGEMENT");
            entity.Property(e => e.UserName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("USER_NAME");
            entity.Property(e => e.Usermanagement)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("USERMANAGEMENT");
        });

        modelBuilder.Entity<Temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");
            entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BasicSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BloodGroup).HasMaxLength(50);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.CofirLetterDate).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");
            entity.Property(e => e.DdpayableAt)
                .HasMaxLength(250)
                .HasColumnName("DDPayableAt");
            entity.Property(e => e.DemiseDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.EmployeeStatusId).HasColumnName("EmployeeStatusID");
            entity.Property(e => e.EntryType).HasMaxLength(50);
            entity.Property(e => e.EpfexcessContribution).HasColumnName("EPFExcessContribution");
            entity.Property(e => e.EpsexcessContribution).HasColumnName("EPSExcessContribution");
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.ExitInterviewDate).HasColumnType("datetime");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(100)
                .HasColumnName("ImageURL");
            entity.Property(e => e.IncludedInEsischeme).HasColumnName("IncludedInESIScheme");
            entity.Property(e => e.IncludedInPfscheme).HasColumnName("IncludedInPFScheme");
            entity.Property(e => e.IqamaNo).HasMaxLength(150);
            entity.Property(e => e.JoiningDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingDate).HasColumnType("datetime");
            entity.Property(e => e.LeavingReasonId).HasColumnName("LeavingReasonID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NameAsPerAadhar).HasMaxLength(150);
            entity.Property(e => e.NameAsPerBank).HasMaxLength(150);
            entity.Property(e => e.NomineeName).HasMaxLength(100);
            entity.Property(e => e.OfferLetterId).HasColumnName("OfferLetterID");
            entity.Property(e => e.OtherBranch).HasMaxLength(200);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasColumnType("datetime")
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.Pfuannumber)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PFUANNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RelationShip).HasMaxLength(50);
            entity.Property(e => e.RelieveDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasColumnType("datetime");
            entity.Property(e => e.SalaryGradeId).HasColumnName("SalaryGradeID");
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.ValidUpto).HasColumnType("datetime");
            entity.Property(e => e.VisaNo).HasMaxLength(100);
        });

        modelBuilder.Entity<Tempdatum>(entity =>
        {
            entity.HasKey(e => new { e.Cardno, e.Officepunch }).HasName("PK_TEMP");

            entity.Property(e => e.Cardno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CARDNO");
            entity.Property(e => e.Officepunch)
                .HasColumnType("datetime")
                .HasColumnName("OFFICEPUNCH");
            entity.Property(e => e.DoorTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DOOR_TIME");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ERROR_CODE");
            entity.Property(e => e.IdNo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Id_No");
            entity.Property(e => e.Inout)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PDay)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("P_DAY");
            entity.Property(e => e.Process)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROCESS");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Snrno)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("snrno");
        });

        modelBuilder.Entity<ViewEmployeeBihar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Employee_Bihar");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BloodGroupName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfirmationDate).HasMaxLength(30);
            entity.Property(e => e.DemiseDate).HasMaxLength(30);
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(30)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeName).HasMaxLength(201);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasMaxLength(30);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.HasLeft)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.JoiningDate).HasMaxLength(30);
            entity.Property(e => e.LeavingDate).HasMaxLength(30);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaritalStatusName).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NomineeName).HasMaxLength(100);
            entity.Property(e => e.NoticeRequired)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoticeServed)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasMaxLength(30)
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.Pfuannumber)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PFUANNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RelieveDate).HasMaxLength(30);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasMaxLength(30);
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.ValidUpto).HasMaxLength(30);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEmployeeDehradoon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Employee_Dehradoon");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BloodGroupName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(30);
            entity.Property(e => e.DemiseDate).HasMaxLength(30);
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(30)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeName).HasMaxLength(201);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasMaxLength(30);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.HasLeft)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.JoiningDate).HasMaxLength(30);
            entity.Property(e => e.LeavingDate).HasMaxLength(30);
            entity.Property(e => e.MaritalStatusName).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NomineeName).HasMaxLength(100);
            entity.Property(e => e.NoticeRequired)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoticeServed)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasMaxLength(30)
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.Pfuannumber)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PFUANNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RelieveDate).HasMaxLength(30);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasMaxLength(30);
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.ValidUpto).HasMaxLength(30);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEmployeeDetailsBihar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeDetails_Bihar");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BloodGroupName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(30);
            entity.Property(e => e.DemiseDate).HasMaxLength(30);
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(30)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeName).HasMaxLength(201);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasMaxLength(30);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.HasLeft)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.JoiningDate).HasMaxLength(30);
            entity.Property(e => e.LeavingDate).HasMaxLength(30);
            entity.Property(e => e.LocationName).HasMaxLength(100);
            entity.Property(e => e.MaritalStatusName).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NomineeName).HasMaxLength(100);
            entity.Property(e => e.NoticeRequired)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoticeServed)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasMaxLength(30)
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.Pfuannumber)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PFUANNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RelieveDate).HasMaxLength(30);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasMaxLength(30);
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.ValidUpto).HasMaxLength(30);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEmployeeDetailsDehradoon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeDetails_Dehradoon");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BloodGroupName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(30);
            entity.Property(e => e.DemiseDate).HasMaxLength(30);
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(30)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeName).HasMaxLength(201);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasMaxLength(30);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.HasLeft)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.JoiningDate).HasMaxLength(30);
            entity.Property(e => e.LeavingDate).HasMaxLength(30);
            entity.Property(e => e.LocationName).HasMaxLength(100);
            entity.Property(e => e.MaritalStatusName).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NomineeName).HasMaxLength(100);
            entity.Property(e => e.NoticeRequired)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoticeServed)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasMaxLength(30)
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.Pfuannumber)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PFUANNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RelieveDate).HasMaxLength(30);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasMaxLength(30);
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.ValidUpto).HasMaxLength(30);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEmployeeDetailsRanchi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeDetails_Ranchi");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BloodGroupName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.ConfirmationDate).HasMaxLength(30);
            entity.Property(e => e.DemiseDate).HasMaxLength(30);
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(30)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeName).HasMaxLength(201);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasMaxLength(30);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.HasLeft)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.JoiningDate).HasMaxLength(30);
            entity.Property(e => e.LeavingDate).HasMaxLength(30);
            entity.Property(e => e.LocationName).HasMaxLength(100);
            entity.Property(e => e.MaritalStatusName).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NomineeName).HasMaxLength(100);
            entity.Property(e => e.NoticeRequired)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoticeServed)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasMaxLength(30)
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.Pfuannumber)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PFUANNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RelieveDate).HasMaxLength(30);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasMaxLength(30);
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.ValidUpto).HasMaxLength(30);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEmployeeLeaveDetailsBihar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeLeaveDetails_Bihar");

            entity.Property(e => e.ApprovedBy).HasMaxLength(252);
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.LeaveType).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.NoOfLeaveApplied).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RecomendedBy).HasMaxLength(252);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEmployeeLeaveDetailsDehradoon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeLeaveDetails_Dehradoon");

            entity.Property(e => e.ApprovedBy).HasMaxLength(252);
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.LeaveType).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.NoOfLeaveApplied).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RecomendedBy).HasMaxLength(252);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEmployeeLeaveDetailsRanchi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeLeaveDetails_Ranchi");

            entity.Property(e => e.ApprovedBy).HasMaxLength(252);
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.LeaveType).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.NoOfLeaveApplied).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RecomendedBy).HasMaxLength(252);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEmployeeRanchi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Employee_Ranchi");

            entity.Property(e => e.AadharEnrollmentNo).HasMaxLength(50);
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BloodGroupName).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ConfirmationDate).HasMaxLength(30);
            entity.Property(e => e.DemiseDate).HasMaxLength(30);
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(30)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeFeedback).HasMaxLength(250);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(201);
            entity.Property(e => e.EmployeeStatus).HasMaxLength(100);
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .HasColumnName("ESINo");
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.FinalSettelementdate).HasMaxLength(30);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.HasLeft)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.JoiningDate).HasMaxLength(30);
            entity.Property(e => e.LeavingDate).HasMaxLength(30);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MaritalStatusName).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.NomineeName).HasMaxLength(100);
            entity.Property(e => e.NoticeRequired)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoticeServed)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PanNo).HasMaxLength(50);
            entity.Property(e => e.PassportNo).HasMaxLength(100);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PfjoinDate)
                .HasMaxLength(30)
                .HasColumnName("PFJoinDate");
            entity.Property(e => e.Pfnumber)
                .HasMaxLength(100)
                .HasColumnName("PFNumber");
            entity.Property(e => e.Pfscheme)
                .HasMaxLength(50)
                .HasColumnName("PFScheme");
            entity.Property(e => e.Pfuannumber)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PFUANNumber");
            entity.Property(e => e.PhoneNo).HasMaxLength(20);
            entity.Property(e => e.RelieveDate).HasMaxLength(30);
            entity.Property(e => e.ResignSubmitted).HasColumnType("datetime");
            entity.Property(e => e.RetireDate).HasMaxLength(30);
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
            entity.Property(e => e.SpouseName).HasMaxLength(150);
            entity.Property(e => e.ValidUpto).HasMaxLength(30);
            entity.Property(e => e.VisaNo).HasMaxLength(100);
            entity.Property(e => e.VisaType).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEmployeeSalaryViewBihar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeSalaryView_Bihar");

            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.Doj)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Salary).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<ViewEmployeeSalaryViewDehradoon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeSalaryView_Dehradoon");

            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.Doj)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Salary).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<ViewEmployeeSalaryViewRanchi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeSalaryView_Ranchi");

            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.Doj)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Salary).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<ViewEmployeeWiseSalaryBihar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeWiseSalary_Bihar");

            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.Doj)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Salary).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<ViewEmployeeWiseSalaryDehradoon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeWiseSalary_Dehradoon");

            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.Doj)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Salary).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<ViewEmployeeWiseSalaryRanchi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeeWiseSalary_Ranchi");

            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.Doj)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Salary).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<ViewMonthWiseSalaryBihar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MonthWiseSalary_Bihar");

            entity.Property(e => e.ActualAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.FinalcialYear)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(100);
            entity.Property(e => e.MonthName).HasMaxLength(50);
            entity.Property(e => e.SalaryDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewMonthWiseSalaryDehradoon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MonthWiseSalary_Dehradoon");

            entity.Property(e => e.ActualAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.FinalcialYear)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(100);
            entity.Property(e => e.MonthName).HasMaxLength(50);
            entity.Property(e => e.SalaryDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewMonthWiseSalaryRanchi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MonthWiseSalary_Ranchi");

            entity.Property(e => e.ActualAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Amount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.FinalcialYear)
                .HasMaxLength(61)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.LocationName).HasMaxLength(100);
            entity.Property(e => e.MonthName).HasMaxLength(50);
            entity.Property(e => e.SalaryDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SalaryGradeName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewResignedEmployeeBihar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ResignedEmployee_Bihar");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(100)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.ResignSubmitted).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewResignedEmployeeDehradoon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ResignedEmployee_Dehradoon");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(100)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.ResignSubmitted).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewResignedEmployeeRanchi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ResignedEmployee_Ranchi");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(100)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.EmployeCode).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(150);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.ResignSubmitted).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
