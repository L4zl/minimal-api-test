﻿using MinimalApiTest.Domain.Models;

namespace MinimalApiTest.Domain.Abstractions;
public interface IWapContext
{
    DbSet<AnalysisLabel> AnalysisLabels { get; set; }
    DbSet<AnalysisValue> AnalysisValues { get; set; }
    DbSet<ApprovalHistory> ApprovalHistories { get; set; }
    DbSet<ApprovalHoldReason> ApprovalHoldReasons { get; set; }
    DbSet<ApprovalOption> ApprovalOptions { get; set; }
    DbSet<ApprovalRouteEntry> ApprovalRouteEntries { get; set; }
    DbSet<ApprovalRouteEntryItem> ApprovalRouteEntryItems { get; set; }
    DbSet<ApprovalRouteProgress> ApprovalRouteProgresses { get; set; }
    DbSet<ApprovalRouteReportDetailView> ApprovalRouteReportDetailViews { get; set; }
    DbSet<ApprovalRouteReportHeaderView> ApprovalRouteReportHeaderViews { get; set; }
    DbSet<ApprovalRouteReportView> ApprovalRouteReportViews { get; set; }
    DbSet<AuditLog> AuditLogs { get; set; }
    DbSet<BankHoliday> BankHolidays { get; set; }
    DbSet<BudgetEnquiry> BudgetEnquiries { get; set; }
    DbSet<CalendarLabel> CalendarLabels { get; set; }
    DbSet<City> Cities { get; set; }
    DbSet<ConstructDatabase> ConstructDatabases { get; set; }
    DbSet<ConstructionApplicationLine> ConstructionApplicationLines { get; set; }
    DbSet<ConstructionApplication> ConstructionApplications { get; set; }
    DbSet<ConstructionValuationLine> ConstructionValuationLines { get; set; }
    DbSet<ConstructionValuation> ConstructionValuations { get; set; }
    DbSet<CostDeptArchive> CostDeptArchives { get; set; }
    DbSet<CostDeptRule> CostDeptRules { get; set; }
    DbSet<CostDept> CostDepts { get; set; }
    DbSet<Country> Countries { get; set; }
    DbSet<CreditCard> CreditCards { get; set; }
    DbSet<CreditCardStatementLayout> CreditCardStatementLayouts { get; set; }
    DbSet<CreditCardStatementLine> CreditCardStatementLines { get; set; }
    DbSet<CreditCardStatement> CreditCardStatements { get; set; }
    DbSet<CsvimportFileInfo> CsvimportFileInfos { get; set; }
    DbSet<CustomCrmfield> CustomCrmfields { get; set; }
    DbSet<CustomerAnalysisValue> CustomerAnalysisValues { get; set; }
    DbSet<Customer> Customers { get; set; }
    DbSet<Customisation> Customisations { get; set; }
    DbSet<CustomPage> CustomPages { get; set; }
    DbSet<DeclarationConfirmation> DeclarationConfirmations { get; set; }
    DbSet<Declaration> Declarations { get; set; }
    DbSet<Models.Delegate> Delegates { get; set; }
    DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
    DbSet<DeliveryAddressStockItem> DeliveryAddressStockItems { get; set; }
    DbSet<Department> Departments { get; set; }
    DbSet<Despatch> Despatches { get; set; }
    DbSet<DespatchLine> DespatchLines { get; set; }
    DbSet<Discount> Discounts { get; set; }
    DbSet<DocumentTypeReminder> DocumentTypeReminders { get; set; }
    DbSet<DocumentType> DocumentTypes { get; set; }
    DbSet<Email> Emails { get; set; }
    DbSet<EmailThread> EmailThreads { get; set; }
    DbSet<EntityLock> EntityLocks { get; set; }
    DbSet<EventLog> EventLogs { get; set; }
    DbSet<ExpenseLine> ExpenseLines { get; set; }
    DbSet<ExpenseMeeting> ExpenseMeetings { get; set; }
    DbSet<ExpenseType> ExpenseTypes { get; set; }
    DbSet<Favouritable> Favouritables { get; set; }
    DbSet<Models.File> Files { get; set; }
    DbSet<FuelRateCutoff> FuelRateCutoffs { get; set; }
    DbSet<FuelRateCutoffSageDatabase> FuelRateCutoffSageDatabases { get; set; }
    DbSet<FuelRateHistory> FuelRateHistories { get; set; }
    DbSet<FuelRate> FuelRates { get; set; }
    DbSet<GoodsReceived> GoodsReceiveds { get; set; }
    DbSet<HolidayDefaultTimesheetProject> HolidayDefaultTimesheetProjects { get; set; }
    DbSet<HolidayRequestLine> HolidayRequestLines { get; set; }
    DbSet<HolidayRequest> HolidayRequests { get; set; }
    DbSet<Hrabsence> Hrabsences { get; set; }
    DbSet<HrabsenceType> HrabsenceTypes { get; set; }
    DbSet<Hraccident> Hraccidents { get; set; }
    DbSet<HraccidentType> HraccidentTypes { get; set; }
    DbSet<Hraddress> Hraddresses { get; set; }
    DbSet<HrbankAccount> HrbankAccounts { get; set; }
    DbSet<Hrcontact> Hrcontacts { get; set; }
    DbSet<Hrcourse> Hrcourses { get; set; }
    DbSet<HrcourseType> HrcourseTypes { get; set; }
    DbSet<HrdisciplinaryCaseLine> HrdisciplinaryCaseLines { get; set; }
    DbSet<HrdisciplinaryCase> HrdisciplinaryCases { get; set; }
    DbSet<HrdocumentLog> HrdocumentLogs { get; set; }
    DbSet<Hrdocument> Hrdocuments { get; set; }
    DbSet<HremployeeDetail> HremployeeDetails { get; set; }
    DbSet<HremployeeSalary> HremployeeSalaries { get; set; }
    DbSet<HrjobRoleNominalOverride> HrjobRoleNominalOverrides { get; set; }
    DbSet<HrjobRole> HrjobRoles { get; set; }
    DbSet<HrupdateLink> HrupdateLinks { get; set; }
    DbSet<Image> Images { get; set; }
    DbSet<InvoiceLine> InvoiceLines { get; set; }
    DbSet<InvoiceMatchHistory> InvoiceMatchHistories { get; set; }
    DbSet<Invoice> Invoices { get; set; }
    DbSet<IpaddressLockout> IpaddressLockouts { get; set; }
    DbSet<JobActivity> JobActivities { get; set; }
    DbSet<JobCostingCtc> JobCostingCtcs { get; set; }
    DbSet<JobCostingFieldValue> JobCostingFieldValues { get; set; }
    DbSet<JobCostingJob> JobCostingJobs { get; set; }
    DbSet<JobCostingMemo> JobCostingMemos { get; set; }
    DbSet<JobRole> JobRoles { get; set; }
    DbSet<JustificationValueBand> JustificationValueBands { get; set; }
    DbSet<LeaveType> LeaveTypes { get; set; }
    DbSet<Location> Locations { get; set; }
    DbSet<LoginRecordLine> LoginRecordLines { get; set; }
    DbSet<LoginRecord> LoginRecords { get; set; }
    DbSet<LostSalesOrderLine> LostSalesOrderLines { get; set; }
    DbSet<MandatoryHoliday> MandatoryHolidays { get; set; }
    DbSet<MeetingRequest> MeetingRequests { get; set; }
    DbSet<Mileage> Mileages { get; set; }
    DbSet<NextNumber> NextNumbers { get; set; }
    DbSet<NominalAccountDescription> NominalAccountDescriptions { get; set; }
    DbSet<NotificationOption> NotificationOptions { get; set; }
    DbSet<Notification> Notifications { get; set; }
    DbSet<OrderJustification> OrderJustifications { get; set; }
    DbSet<OrderLine> OrderLines { get; set; }
    DbSet<Order> Orders { get; set; }
    DbSet<OrderTemplateLine> OrderTemplateLines { get; set; }
    DbSet<OrderTemplate> OrderTemplates { get; set; }
    DbSet<OutOfOffice> OutOfOffices { get; set; }
    DbSet<Pctran> Pctrans { get; set; }
    DbSet<ProjectRequisitionLine> ProjectRequisitionLines { get; set; }
    DbSet<ProjectRequisition> ProjectRequisitions { get; set; }
    DbSet<ProposedPaymentLine> ProposedPaymentLines { get; set; }
    DbSet<ProposedPayment> ProposedPayments { get; set; }
    DbSet<PushNotificationToken> PushNotificationTokens { get; set; }
    DbSet<ReasonForLeaving> ReasonForLeavings { get; set; }
    DbSet<ReceiptBatchSerialAttribute> ReceiptBatchSerialAttributes { get; set; }
    DbSet<ReceiptBatchSerial> ReceiptBatchSerials { get; set; }
    DbSet<ReceiptLine> ReceiptLines { get; set; }
    DbSet<Receipt> Receipts { get; set; }
    DbSet<RequestForQuote> RequestForQuotes { get; set; }
    DbSet<ResetCode> ResetCodes { get; set; }
    DbSet<RestrictedNominal> RestrictedNominals { get; set; }
    DbSet<Sage50AccountNumber> Sage50AccountNumbers { get; set; }
    DbSet<Sage50Currency> Sage50Currencies { get; set; }
    DbSet<Sage50Department> Sage50Departments { get; set; }
    DbSet<Sage50NominalLedger> Sage50NominalLedgers { get; set; }
    DbSet<Sage50ProjectCostCode> Sage50ProjectCostCodes { get; set; }
    DbSet<Sage50ProjectCostType> Sage50ProjectCostTypes { get; set; }
    DbSet<Sage50ProjectResource> Sage50ProjectResources { get; set; }
    DbSet<Sage50Project> Sage50Projects { get; set; }
    DbSet<Sage50ProjectStatus> Sage50ProjectStatuses { get; set; }
    DbSet<Sage50PurchaseLedger> Sage50PurchaseLedgers { get; set; }
    DbSet<Sage50TaxCode> Sage50TaxCodes { get; set; }
    DbSet<SageDatabaseReportField> SageDatabaseReportFields { get; set; }
    DbSet<SageDatabase> SageDatabases { get; set; }
    DbSet<SageDatabaseSystemSetting> SageDatabaseSystemSettings { get; set; }
    DbSet<SalesInvoiceLayout> SalesInvoiceLayouts { get; set; }
    DbSet<SalesOrderAcknowledgementLayout> SalesOrderAcknowledgementLayouts { get; set; }
    DbSet<SalesOrderCrmdetail> SalesOrderCrmdetails { get; set; }
    DbSet<SalesOrderLine> SalesOrderLines { get; set; }
    DbSet<SalesOrderPriceBand> SalesOrderPriceBands { get; set; }
    DbSet<SalesOrderReportMapping> SalesOrderReportMappings { get; set; }
    DbSet<SalesOrderReport> SalesOrderReports { get; set; }
    DbSet<SalesOrder> SalesOrders { get; set; }
    DbSet<SalesOrderShippingLine> SalesOrderShippingLines { get; set; }
    DbSet<SalesOrderShipping> SalesOrderShippings { get; set; }
    DbSet<SalesQuoteLayout> SalesQuoteLayouts { get; set; }
    DbSet<ServiceNotification> ServiceNotifications { get; set; }
    DbSet<Setting> Settings { get; set; }
    DbSet<StockItem> StockItems { get; set; }
    DbSet<SubsistenceGrade> SubsistenceGrades { get; set; }
    DbSet<SubsistenceIncidental> SubsistenceIncidentals { get; set; }
    DbSet<SubsistenceRate> SubsistenceRates { get; set; }
    DbSet<Supplier> Suppliers { get; set; }
    DbSet<SystemMessage> SystemMessages { get; set; }
    DbSet<Theme> Themes { get; set; }
    DbSet<TimeInLieu> TimeInLieus { get; set; }
    DbSet<TimeRecord> TimeRecords { get; set; }
    DbSet<TimesheetDefault> TimesheetDefaults { get; set; }
    DbSet<TimesheetLineHour> TimesheetLineHours { get; set; }
    DbSet<TimesheetLineResourceHour> TimesheetLineResourceHours { get; set; }
    DbSet<TimesheetLine> TimesheetLines { get; set; }
    DbSet<TimesheetLockedWeek> TimesheetLockedWeeks { get; set; }
    DbSet<TimesheetPaymentLineHour> TimesheetPaymentLineHours { get; set; }
    DbSet<TimesheetPaymentLine> TimesheetPaymentLines { get; set; }
    DbSet<Timesheet> Timesheets { get; set; }
    DbSet<UserContract> UserContracts { get; set; }
    DbSet<UserCostingHeader> UserCostingHeaders { get; set; }
    DbSet<UserCostingItem> UserCostingItems { get; set; }
    DbSet<UserCostingItemType> UserCostingItemTypes { get; set; }
    DbSet<UserCreditCardExpense> UserCreditCardExpenses { get; set; }
    DbSet<UserDepartment> UserDepartments { get; set; }
    DbSet<UserEmail> UserEmails { get; set; }
    DbSet<UserExpenseMeeting> UserExpenseMeetings { get; set; }
    DbSet<UserExpenseTypeNominal> UserExpenseTypeNominals { get; set; }
    DbSet<UserExpenseType> UserExpenseTypes { get; set; }
    DbSet<UserFavouriteAddress> UserFavouriteAddresses { get; set; }
    DbSet<UserFavourite> UserFavourites { get; set; }
    DbSet<UserHolidayRule> UserHolidayRules { get; set; }
    DbSet<UserHoliday> UserHolidays { get; set; }
    DbSet<UserItemValue> UserItemValues { get; set; }
    DbSet<UserJob> UserJobs { get; set; }
    DbSet<UserMileageBalance> UserMileageBalances { get; set; }
    DbSet<UserNominalAccount> UserNominalAccounts { get; set; }
    DbSet<UserOrderTemplate> UserOrderTemplates { get; set; }
    DbSet<UserPasswordHistory> UserPasswordHistories { get; set; }
    DbSet<UserProjectItemType> UserProjectItemTypes { get; set; }
    DbSet<UserProject> UserProjects { get; set; }
    DbSet<UserRole> UserRoles { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<UserSageDatabase> UserSageDatabases { get; set; }
    DbSet<UserSelfApprovalValue> UserSelfApprovalValues { get; set; }
    DbSet<UserSetting> UserSettings { get; set; }
    DbSet<UserSubsistenceIncidental> UserSubsistenceIncidentals { get; set; }
    DbSet<UserSupplierFilterCode> UserSupplierFilterCodes { get; set; }
    DbSet<UserSystemSetting> UserSystemSettings { get; set; }
    DbSet<UserTimeRule> UserTimeRules { get; set; }
    DbSet<UserTimesheetSubmission> UserTimesheetSubmissions { get; set; }
    DbSet<UserTimesheetTeamDefault> UserTimesheetTeamDefaults { get; set; }
    DbSet<UserType> UserTypes { get; set; }
    DbSet<UserTypeSystemSetting> UserTypeSystemSettings { get; set; }
    DbSet<UserVehicle> UserVehicles { get; set; }
    DbSet<UserWarehouse> UserWarehouses { get; set; }
    DbSet<UserWeeklyContractedHour> UserWeeklyContractedHours { get; set; }
    DbSet<UserWorkPatternPayRate> UserWorkPatternPayRates { get; set; }
    DbSet<ValueBand> ValueBands { get; set; }
    DbSet<Vehicle> Vehicles { get; set; }
    DbSet<Models.Version> Versions { get; set; }
    DbSet<VNoDuplicateDoNo> VNoDuplicateDoNos { get; set; }
    DbSet<WapprojectItem> WapprojectItems { get; set; }
    DbSet<WapprojectItemTypeDocumentType> WapprojectItemTypeDocumentTypes { get; set; }
    DbSet<WapprojectItemType> WapprojectItemTypes { get; set; }
    DbSet<Wapproject> Wapprojects { get; set; }
    DbSet<Wapqueue> Wapqueues { get; set; }
    DbSet<Waptask> Waptasks { get; set; }
    DbSet<WarehouseNominalAccount> WarehouseNominalAccounts { get; set; }
    DbSet<WorkPatternDay> WorkPatternDays { get; set; }
    DbSet<WorkPatternDayShift> WorkPatternDayShifts { get; set; }
    DbSet<WorkPatternPayRate> WorkPatternPayRates { get; set; }
    DbSet<WorkPatternRule> WorkPatternRules { get; set; }
    DbSet<WorkPattern> WorkPatterns { get; set; }
    DbSet<WorkPatternShift> WorkPatternShifts { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}