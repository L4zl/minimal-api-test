﻿namespace MinimalApiTest.Application.Contracts.Users.Responses;

public class UserResponse
{
    public long UserId { get; set; }
    public long? UserTypeId { get; set; }
    public string? UserName { get; set; }
    public string? UserPassword { get; set; }
    public DateTime PasswordExpiryDate { get; set; }
    public string? Title { get; set; }
    public string? Forename { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? JobTitle { get; set; }
    public decimal? MaximumOrderValue { get; set; }
    public int? LoginStatus { get; set; }
    public bool? ChangeRequestedBy { get; set; }
    public decimal? MaximumAuthorisationValue { get; set; }
    public bool? Deleted { get; set; }
    public bool? Inactive { get; set; }
    public long? AlternateUserId { get; set; }
    public bool? OutOfOffice { get; set; }
    public bool? ViewAllNominalsBudgetEnquiry { get; set; }
    public long? FuelRateId { get; set; }
    public string? VehicleReg { get; set; }
    public long? DefaultVehicleId { get; set; }
    public decimal? CurrentMileage { get; set; }
    public decimal? StartMileage { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? UpdatedUser { get; set; }
    public bool? OverrideMonthlyBudget { get; set; }
    public bool? OverrideYtdbudget { get; set; }
    public bool? OverrideAnnualBudget { get; set; }
    public string? Pin { get; set; }
    public string? SagePayrollReference { get; set; }
    public bool? OnlyOneJobAtAtime { get; set; }
    public bool? OverrideProjectBudget { get; set; }
    public bool? OverrideProjectItemBudget { get; set; }
    public decimal? WeeklyContractedHours { get; set; }
    public decimal? SelfApprovalValue { get; set; }
    public string? TelephoneNumber { get; set; }
    public bool? SystemAccount { get; set; }
    public bool? SelfApprovalCheckBudgets { get; set; }
    public decimal? HistoricalPersonalMileage { get; set; }
    public decimal? HistoricalBusinessMileage { get; set; }
    public bool? OverrideTopLevelProjectBudget { get; set; }
    public bool? AllowLogin { get; set; }
    public bool? OverrideTopLevelCostItemBudget { get; set; }
    public string? CreditCardPostingReference { get; set; }
    public string? FuelCardPostingReference { get; set; }
    public long? WorkPatternId { get; set; }
    public decimal TimeInLieuHoursMaximum { get; set; }
    public decimal TimeInLieuHoursMinimum { get; set; }
    public decimal TimeInLieuHoursAccrued { get; set; }
    public bool? ParentGroupOverrideMonthlyBudget { get; set; }
    public bool? ParentGroupOverrideYtdbudget { get; set; }
    public bool? ParentGroupOverrideAnnualBudget { get; set; }
    public bool? ReportingCategoryOverrideMonthlyBudget { get; set; }
    public bool? ReportingCategoryOverrideYtdbudget { get; set; }
    public bool? ReportingCategoryOverrideAnnualBudget { get; set; }
    public decimal TimeInLieuHoursStartsAt { get; set; }
    public decimal OvertimeHoursStartsAt { get; set; }
    public decimal OvertimeHours2StartsAt { get; set; }
    public decimal OvertimeHours3StartsAt { get; set; }
    public bool? AccessAllNominals { get; set; }
    public bool? AccessAllProjects { get; set; }
    public bool? AccessAllProjectItemTypes { get; set; }
    public bool? AccessAllProjectItems { get; set; }
    public bool? AccessAllDelegates { get; set; }
    public long? HolidayWorkPatternId { get; set; }
    public long? SubsistenceGradeId { get; set; }
    public long? CountryId { get; set; }
    public bool? OverrideJobBudget { get; set; }
    public bool? OverrideJobCostHeaderBudget { get; set; }
    public bool? OverrideJobPhaseBudget { get; set; }
    public bool? OverrideJobStageBudget { get; set; }
    public bool? OverrideJobSubStageBudget { get; set; }
    public bool? OverrideJobPeriodBudget { get; set; }
    public bool? OverrideJobTopLevelBudget { get; set; }
    public bool? CanSelectOtherPrivateVehicles { get; set; }
    public DateTime PasswordChangedDate { get; set; }
    public bool? ForcePasswordChange { get; set; }
    public long? SageDatabaseIdforPayroll { get; set; }
    public long? FtcomparisonWorkPatternId { get; set; }
    public decimal DistanceToHome { get; set; }
    public long? TimesheetHoursWorkPatternId { get; set; }
    public bool? SubtractRegularCommute { get; set; }
    public bool? WelcomeEmailSent { get; set; }
    public DateTime? EmploymentStartDate { get; set; }
    public string? AnalysisCode1 { get; set; }
    public string? AnalysisCode2 { get; set; }
    public string? AnalysisCode3 { get; set; }
    public string? AnalysisCode4 { get; set; }
    public string? AnalysisCode5 { get; set; }
    public string? AnalysisCode6 { get; set; }
    public string? AnalysisCode7 { get; set; }
    public string? AnalysisCode8 { get; set; }
    public string? AnalysisCode9 { get; set; }
    public string? AnalysisCode10 { get; set; }
    public bool? AccessAllExpenseMeetings { get; set; }
    public bool? SubsistenceEnabled { get; set; }
    public decimal? MaximumDailyTimesheetHours { get; set; }
    public bool? DisableExpenseItemSagePosting { get; set; }
    public bool? DisableMileageItemSagePosting { get; set; }
    public bool? PartTime { get; set; }
    public long? ToilbankPog { get; set; }
    public Guid UserGuid { get; set; }
    public bool? ViewAllSupplierFilterCodes { get; set; }
    public string? TwoFactorSecurityKey { get; set; }
    public string? AuthenticateGuid { get; set; }
}

