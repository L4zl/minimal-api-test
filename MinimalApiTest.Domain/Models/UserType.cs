﻿namespace MinimalApiTest.Domain.Models
{
    public partial class UserType
    {
        public long UserTypeId { get; set; }
        public string? UserTypeName { get; set; }
        public bool? SubmitRequest { get; set; }
        public bool? AmendUsers { get; set; }
        public bool? ViewAllOrders { get; set; }
        public bool? AuthorisationRoute { get; set; }
        public bool? PostToSage { get; set; }
        public bool? AmendUserTypes { get; set; }
        public bool? Authorise { get; set; }
        public bool? AmendAddress { get; set; }
        public bool? CancelPostedOrders { get; set; }
        public bool? AmendUserNominalCodes { get; set; }
        public bool? CanSendEmail { get; set; }
        public bool? AmendNominalDescriptions { get; set; }
        public bool? AmendSystemSettings { get; set; }
        public bool? ConfirmGoodsReceived { get; set; }
        public bool? AmendDepartments { get; set; }
        public bool? CanPerformYearEnd { get; set; }
        public bool? Deleted { get; set; }
        public bool? AmendDelegates { get; set; }
        public bool? AmendUserProjects { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public bool? DeleteRequests { get; set; }
        public bool? AmendPostedRequests { get; set; }
        public bool? CanViewDashboard { get; set; }
        public bool? PrintRequests { get; set; }
        public bool? ArchiveRequests { get; set; }
        public bool? DeleteAttachFromCompletedDocs { get; set; }
        public bool? ViewAllInvoices { get; set; }
        public bool? SystemAccount { get; set; }
        public bool? AdHocApprovalRoutes { get; set; }
        public bool? ViewRequests { get; set; }
        public bool? AmendSubmittedTimesheets { get; set; }
        public bool? SubmitHolidayRequests { get; set; }
        public bool? ViewHolidayReport { get; set; }
        public bool? ApproveHolidayRequests { get; set; }
        public bool? AmendUserHolidayRules { get; set; }
        public bool? ViewAllTimesheets { get; set; }
        public bool? ViewEventLog { get; set; }
        public bool? AmendReports { get; set; }
        public bool? AmendInvoices { get; set; }
        public bool? DeleteInvoices { get; set; }
        public bool? EnableFailedDocumentsCommands { get; set; }
        public bool? InvoiceNotesPermission { get; set; }
        public bool? AmendTemplates { get; set; }
        public bool? GenerateTemplates { get; set; }
        public bool? ArchiveSalesOrders { get; set; }
        public bool? DeleteSalesOrders { get; set; }
        public bool? PrintSalesOrders { get; set; }
        public bool? ViewAllSalesOrders { get; set; }
        public bool? AmendUserWarehouses { get; set; }
        public bool? AmendUserOrderTemplates { get; set; }
        public bool? AmendPostedSalesOrders { get; set; }
        public bool? PostSalesOrders { get; set; }
        public bool? AdjustTimesheets { get; set; }
        public bool? DeleteTimesheets { get; set; }
        public bool? CanDeleteAllTemplates { get; set; }
        public bool? AmendWorkPatterns { get; set; }
        public bool? EnterNewInvoices { get; set; }
        public bool? ApproveInvoices { get; set; }
        public bool? RecordPoinvoices { get; set; }
        public bool? ViewInvoiceReports { get; set; }
        public bool? ViewAllExpenses { get; set; }
        public bool? ViewBudgetEnquiry { get; set; }
        public bool? ViewExpenseEnquiry { get; set; }
        public bool? ViewExpenseNominalAccountEnquiry { get; set; }
        public bool? ViewProjectCostingEnquiry { get; set; }
        public bool? ViewCustomReports { get; set; }
        public bool? ExpensesSelectTaxRate { get; set; }
        public bool? ApproveTimesheets { get; set; }
        public bool? ApproveRequisitions { get; set; }
        public bool? ApproveExpenses { get; set; }
        public bool? ApproveSalesOrders { get; set; }
        public bool? LockTimesheetWeeks { get; set; }
        public bool? ExpensesViewReports { get; set; }
        public bool? EnterExpenses { get; set; }
        public bool? ViewClockedInUsers { get; set; }
        public bool? TimesheetReportByWeekAndUser { get; set; }
        public bool? TimesheetReportUnsubmitted { get; set; }
        public bool? TimesheetReportFlexi { get; set; }
        public bool? TimesheetReportToilandOvertime { get; set; }
        public bool? TimesheetReportLoginActivity { get; set; }
        public bool? TimesheetReportTimesheetLines { get; set; }
        public bool? AmendWapprojects { get; set; }
        public bool? RequisitionReportAllOrderLines { get; set; }
        public bool? RequisitionReportGoni { get; set; }
        public bool? RequisitionReportGrni { get; set; }
        public bool? RequisitionReportLegacyAllOrderLines { get; set; }
        public bool? RequisitionReportLegacyApprovedOrders { get; set; }
        public bool? UpdateWorksOrdersFromTadashboard { get; set; }
        public bool? SwitchDelegates { get; set; }
        public bool? SubmitTimesheets { get; set; }
        public bool? SalesOrderGoodsDespatched { get; set; }
        public bool? SalesOrderNewCustomer { get; set; }
        public bool? EnterNewCreditNotes { get; set; }
        public bool? UseApproveAllButtons { get; set; }
        public bool? DeleteHolidayRequests { get; set; }
        public bool? ViewUserProjectReports { get; set; }
        public bool? EditExpensesDuringApproval { get; set; }
        public bool? EnableExpensesExtendedNominalAnalysis { get; set; }
        public bool? AllowFilterReportByDelegate { get; set; }
        public bool? AllowFilterReportByDepartment { get; set; }
        public bool? AllowFilterReportByAllUsers { get; set; }
        public bool? ExpensesSplitLines { get; set; }
        public bool? SelectVehicleOnMileageExpense { get; set; }
        public bool? CanMaintainVehicles { get; set; }
        public bool? PerformToilmonthEnd { get; set; }
        public bool? CanMaintainCreditCards { get; set; }
        public bool? ChangeExpenseNominal { get; set; }
        public bool? EditProjectTimeEntry { get; set; }
        public bool? CanImportCreditCardStatements { get; set; }
        public bool? ApicanCreateNewSupplier { get; set; }
        public bool? ApicanCreateNewExpenseSupplier { get; set; }
        public bool? ApicanCreateNewStockItem { get; set; }
        public bool? ApicanCreateNewCustomer { get; set; }
        public bool? TarequireSignIn { get; set; }
        public bool? TahideFromCurrentActivity { get; set; }
        public bool? ApproveSuppliers { get; set; }
        public bool? ApproveExpenseSuppliers { get; set; }
        public bool? ApproveStockItems { get; set; }
        public bool? ApproveCustomers { get; set; }
        public bool? EnquiriesCostingAllocationReports { get; set; }
        public bool? ViewAllCustomerRequests { get; set; }
        public bool? ViewAllSupplierRequests { get; set; }
        public bool? ViewAllStockItemRequests { get; set; }
        public bool SubmitRapidTimesheets { get; set; }
        public bool? Hradmin { get; set; }
        public long? SecurityLevel { get; set; }
        public bool? MaintainUserRoles { get; set; }
        public bool? HreditCourses { get; set; }
        public bool? HrdeleteCourses { get; set; }
        public bool? HreditDocuments { get; set; }
        public bool? HrdeleteDocuments { get; set; }
        public bool? HreditBankDetails { get; set; }
        public bool? HrnotifyEmployeeChanges { get; set; }
        public bool? ViewAllHolidayRequests { get; set; }
        public bool? ViewDepartmentHolidayRequests { get; set; }
        public bool? TimesheetCopyToTeam { get; set; }
        public bool? TimesheetAddResources { get; set; }
        public bool? EnquiriesJobCosting { get; set; }
        public bool CanEnterNewBatchInvoices { get; set; }
        public bool CanAmendInvoiceLineCostingDetailOnApproval { get; set; }
        public bool CanAmendOrderLineCostingDetailOnApproval { get; set; }
        public bool AllowPageCustomisation { get; set; }
        public bool AllowJobCosting { get; set; }
        public bool CanViewAllJcjobs { get; set; }
        public bool CanCreateJcjobs { get; set; }
        public bool CanEditJcjobs { get; set; }
        public bool CanEditJcjobAnalysisCodes { get; set; }
        public bool CanEditJcjobCustomFields { get; set; }
        public bool? CanViewJcjobCustomFields { get; set; }
        public bool SopstockBatchEntry { get; set; }
        public bool CanCopyInvoices { get; set; }
        public bool? ViewDepartmentTimesheets { get; set; }
        public bool? DeleteExpenses { get; set; }
        public bool? RequisitionOutOfHours { get; set; }
        public bool PerformHolidayMonthEnd { get; set; }
        public bool ApproveConstructionApplications { get; set; }
        public bool ViewConstructionApplications { get; set; }
        public bool SubmitConstructionApplications { get; set; }
        public bool ViewAllConstructionApplications { get; set; }
        public bool NewProjectRequisitions { get; set; }
        public bool ApproveProjectRequisitions { get; set; }
        public bool ViewProjectRequisitions { get; set; }
        public bool ViewAllProjectRequisitions { get; set; }
        public bool SetProjectRequisitionSupplier { get; set; }
        public bool ResetCompletedHolidays { get; set; }
        public bool? SalesOrderNewQuote { get; set; }
        public bool? ViewCostToComplete { get; set; }
        public bool? MobileUser { get; set; }
        public bool? MobileNewTimesheet { get; set; }
        public bool? MobileNewTimesheetOthers { get; set; }
        public bool? HolStartingHoliday { get; set; }
        public bool? MobileTsdecimalEntry { get; set; }
        public bool? DeleteStockItemRequests { get; set; }
        public bool? DeleteSupplierRequests { get; set; }
        public bool? DeleteCustomerRequests { get; set; }
        public bool? ClearIpaddressLockouts { get; set; }
        public bool? ResetUserPasswords { get; set; }
        public bool? RequisitionHideSupplierPricing { get; set; }
        public bool? ApproveProposedPayments { get; set; }
        public bool? AmendProposedPayments { get; set; }
        public bool? DeleteProposedPayments { get; set; }
        public bool? CanViewProjectRequisitionComments { get; set; }
        public bool? CanEnterProjectRequisitionComments { get; set; }
        public bool? CanViewProjectRequisitionReports { get; set; }
        public bool? ProcessPayrollExpenses { get; set; }
        public bool? TimesheetNotRequired { get; set; }
        public bool? RequisitionBatchNominalReplace { get; set; }
        public bool? SopcanApproveQuote { get; set; }
        public bool? SopcanConvertQuote { get; set; }
        public bool? SopcanViewAllQuotes { get; set; }
        public bool? SalesOrderViewReports { get; set; }
        public bool? CanPrintQuoteRequests { get; set; }
        public bool? CanImportOrders { get; set; }
        public bool CanEditJcmemos { get; set; }
        public bool? EditTimesheetsDuringApproval { get; set; }
        public bool? EnterHolidayForAll { get; set; }
        public bool? EnterHolidayForDelegates { get; set; }
        public bool? ApproveAbsences { get; set; }
        public bool? EnterAbsences { get; set; }
        public bool? EnterAbsencesForAll { get; set; }
        public bool? EnterAbsencesForBusinessUnit { get; set; }
        public bool? EnterAbsencesForDelegates { get; set; }
        public bool? CanViewAllAbsences { get; set; }
        public bool? CanViewAbsenceReports { get; set; }
        public bool? CanViewBusinessUnitAbsences { get; set; }
        public bool? CanDeleteAbsences { get; set; }
        public bool? CanEditEmploymentStartDate { get; set; }
        public bool CanViewSubContractorPos { get; set; }
        public bool SubmitSubContractorPos { get; set; }
        public bool CanImportExpenses { get; set; }
        public bool RequisitionReportGrhistory { get; set; }
        public bool? SopcanSubmitReturn { get; set; }
        public bool? SopcanApproveReturn { get; set; }
        public bool? SopcanViewAllReturns { get; set; }
        public bool? CanEditApprovalHoldReasonsInvoices { get; set; }
        public bool? CanEditApprovalHoldReasonsExpenses { get; set; }
        public bool? CanConfirmFinalReceipt { get; set; }
        public bool? CanUseJcoperations { get; set; }
        public bool? TscanResetWaitingLines { get; set; }
    }
}
