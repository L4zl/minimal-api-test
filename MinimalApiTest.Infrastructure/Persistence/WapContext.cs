namespace MinimalApiTest.Infrastructure.Persistence;

using MinimalApiTest.Domain.Models;

public partial class WapContext : DbContext, IWapContext
{
    public WapContext()
    {
    }

    public WapContext(DbContextOptions<WapContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnalysisLabel> AnalysisLabels { get; set; } = null!;
    public virtual DbSet<AnalysisValue> AnalysisValues { get; set; } = null!;
    public virtual DbSet<ApprovalHistory> ApprovalHistories { get; set; } = null!;
    public virtual DbSet<ApprovalHoldReason> ApprovalHoldReasons { get; set; } = null!;
    public virtual DbSet<ApprovalOption> ApprovalOptions { get; set; } = null!;
    public virtual DbSet<ApprovalRouteEntry> ApprovalRouteEntries { get; set; } = null!;
    public virtual DbSet<ApprovalRouteEntryItem> ApprovalRouteEntryItems { get; set; } = null!;
    public virtual DbSet<ApprovalRouteProgress> ApprovalRouteProgresses { get; set; } = null!;
    public virtual DbSet<ApprovalRouteReportDetailView> ApprovalRouteReportDetailViews { get; set; } = null!;
    public virtual DbSet<ApprovalRouteReportHeaderView> ApprovalRouteReportHeaderViews { get; set; } = null!;
    public virtual DbSet<ApprovalRouteReportView> ApprovalRouteReportViews { get; set; } = null!;
    public virtual DbSet<AuditLog> AuditLogs { get; set; } = null!;
    public virtual DbSet<BankHoliday> BankHolidays { get; set; } = null!;
    public virtual DbSet<BudgetEnquiry> BudgetEnquiries { get; set; } = null!;
    public virtual DbSet<CalendarLabel> CalendarLabels { get; set; } = null!;
    public virtual DbSet<City> Cities { get; set; } = null!;
    public virtual DbSet<ConstructDatabase> ConstructDatabases { get; set; } = null!;
    public virtual DbSet<ConstructionApplication> ConstructionApplications { get; set; } = null!;
    public virtual DbSet<ConstructionApplicationLine> ConstructionApplicationLines { get; set; } = null!;
    public virtual DbSet<ConstructionValuation> ConstructionValuations { get; set; } = null!;
    public virtual DbSet<ConstructionValuationLine> ConstructionValuationLines { get; set; } = null!;
    public virtual DbSet<CostDept> CostDepts { get; set; } = null!;
    public virtual DbSet<CostDeptArchive> CostDeptArchives { get; set; } = null!;
    public virtual DbSet<CostDeptRule> CostDeptRules { get; set; } = null!;
    public virtual DbSet<Country> Countries { get; set; } = null!;
    public virtual DbSet<CreditCard> CreditCards { get; set; } = null!;
    public virtual DbSet<CreditCardStatement> CreditCardStatements { get; set; } = null!;
    public virtual DbSet<CreditCardStatementLayout> CreditCardStatementLayouts { get; set; } = null!;
    public virtual DbSet<CreditCardStatementLine> CreditCardStatementLines { get; set; } = null!;
    public virtual DbSet<CsvimportFileInfo> CsvimportFileInfos { get; set; } = null!;
    public virtual DbSet<CustomCrmfield> CustomCrmfields { get; set; } = null!;
    public virtual DbSet<CustomPage> CustomPages { get; set; } = null!;
    public virtual DbSet<Customer> Customers { get; set; } = null!;
    public virtual DbSet<CustomerAnalysisValue> CustomerAnalysisValues { get; set; } = null!;
    public virtual DbSet<Customisation> Customisations { get; set; } = null!;
    public virtual DbSet<Declaration> Declarations { get; set; } = null!;
    public virtual DbSet<DeclarationConfirmation> DeclarationConfirmations { get; set; } = null!;
    public virtual DbSet<Domain.Models.Delegate> Delegates { get; set; } = null!;
    public virtual DbSet<DeliveryAddress> DeliveryAddresses { get; set; } = null!;
    public virtual DbSet<DeliveryAddressStockItem> DeliveryAddressStockItems { get; set; } = null!;
    public virtual DbSet<Department> Departments { get; set; } = null!;
    public virtual DbSet<Despatch> Despatches { get; set; } = null!;
    public virtual DbSet<DespatchLine> DespatchLines { get; set; } = null!;
    public virtual DbSet<Discount> Discounts { get; set; } = null!;
    public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
    public virtual DbSet<DocumentTypeReminder> DocumentTypeReminders { get; set; } = null!;
    public virtual DbSet<Email> Emails { get; set; } = null!;
    public virtual DbSet<EmailThread> EmailThreads { get; set; } = null!;
    public virtual DbSet<EntityLock> EntityLocks { get; set; } = null!;
    public virtual DbSet<EventLog> EventLogs { get; set; } = null!;
    public virtual DbSet<ExpenseLine> ExpenseLines { get; set; } = null!;
    public virtual DbSet<ExpenseMeeting> ExpenseMeetings { get; set; } = null!;
    public virtual DbSet<ExpenseType> ExpenseTypes { get; set; } = null!;
    public virtual DbSet<Favouritable> Favouritables { get; set; } = null!;
    public virtual DbSet<Domain.Models.File> Files { get; set; } = null!;
    public virtual DbSet<FuelRate> FuelRates { get; set; } = null!;
    public virtual DbSet<FuelRateCutoff> FuelRateCutoffs { get; set; } = null!;
    public virtual DbSet<FuelRateCutoffSageDatabase> FuelRateCutoffSageDatabases { get; set; } = null!;
    public virtual DbSet<FuelRateHistory> FuelRateHistories { get; set; } = null!;
    public virtual DbSet<GoodsReceived> GoodsReceiveds { get; set; } = null!;
    public virtual DbSet<HolidayDefaultTimesheetProject> HolidayDefaultTimesheetProjects { get; set; } = null!;
    public virtual DbSet<HolidayRequest> HolidayRequests { get; set; } = null!;
    public virtual DbSet<HolidayRequestLine> HolidayRequestLines { get; set; } = null!;
    public virtual DbSet<Hrabsence> Hrabsences { get; set; } = null!;
    public virtual DbSet<HrabsenceType> HrabsenceTypes { get; set; } = null!;
    public virtual DbSet<Hraccident> Hraccidents { get; set; } = null!;
    public virtual DbSet<HraccidentType> HraccidentTypes { get; set; } = null!;
    public virtual DbSet<Hraddress> Hraddresses { get; set; } = null!;
    public virtual DbSet<HrbankAccount> HrbankAccounts { get; set; } = null!;
    public virtual DbSet<Hrcontact> Hrcontacts { get; set; } = null!;
    public virtual DbSet<Hrcourse> Hrcourses { get; set; } = null!;
    public virtual DbSet<HrcourseType> HrcourseTypes { get; set; } = null!;
    public virtual DbSet<HrdisciplinaryCase> HrdisciplinaryCases { get; set; } = null!;
    public virtual DbSet<HrdisciplinaryCaseLine> HrdisciplinaryCaseLines { get; set; } = null!;
    public virtual DbSet<Hrdocument> Hrdocuments { get; set; } = null!;
    public virtual DbSet<HrdocumentLog> HrdocumentLogs { get; set; } = null!;
    public virtual DbSet<HremployeeDetail> HremployeeDetails { get; set; } = null!;
    public virtual DbSet<HremployeeSalary> HremployeeSalaries { get; set; } = null!;
    public virtual DbSet<HrjobRole> HrjobRoles { get; set; } = null!;
    public virtual DbSet<HrjobRoleNominalOverride> HrjobRoleNominalOverrides { get; set; } = null!;
    public virtual DbSet<HrupdateLink> HrupdateLinks { get; set; } = null!;
    public virtual DbSet<Image> Images { get; set; } = null!;
    public virtual DbSet<Invoice> Invoices { get; set; } = null!;
    public virtual DbSet<InvoiceLine> InvoiceLines { get; set; } = null!;
    public virtual DbSet<InvoiceMatchHistory> InvoiceMatchHistories { get; set; } = null!;
    public virtual DbSet<IpaddressLockout> IpaddressLockouts { get; set; } = null!;
    public virtual DbSet<JobActivity> JobActivities { get; set; } = null!;
    public virtual DbSet<JobCostingCtc> JobCostingCtcs { get; set; } = null!;
    public virtual DbSet<JobCostingFieldValue> JobCostingFieldValues { get; set; } = null!;
    public virtual DbSet<JobCostingJob> JobCostingJobs { get; set; } = null!;
    public virtual DbSet<JobCostingMemo> JobCostingMemos { get; set; } = null!;
    public virtual DbSet<JobRole> JobRoles { get; set; } = null!;
    public virtual DbSet<JustificationValueBand> JustificationValueBands { get; set; } = null!;
    public virtual DbSet<LeaveType> LeaveTypes { get; set; } = null!;
    public virtual DbSet<Location> Locations { get; set; } = null!;
    public virtual DbSet<LoginRecord> LoginRecords { get; set; } = null!;
    public virtual DbSet<LoginRecordLine> LoginRecordLines { get; set; } = null!;
    public virtual DbSet<LostSalesOrderLine> LostSalesOrderLines { get; set; } = null!;
    public virtual DbSet<MandatoryHoliday> MandatoryHolidays { get; set; } = null!;
    public virtual DbSet<MeetingRequest> MeetingRequests { get; set; } = null!;
    public virtual DbSet<Mileage> Mileages { get; set; } = null!;
    public virtual DbSet<NextNumber> NextNumbers { get; set; } = null!;
    public virtual DbSet<NominalAccountDescription> NominalAccountDescriptions { get; set; } = null!;
    public virtual DbSet<Notification> Notifications { get; set; } = null!;
    public virtual DbSet<NotificationOption> NotificationOptions { get; set; } = null!;
    public virtual DbSet<Order> Orders { get; set; } = null!;
    public virtual DbSet<OrderJustification> OrderJustifications { get; set; } = null!;
    public virtual DbSet<OrderLine> OrderLines { get; set; } = null!;
    public virtual DbSet<OrderTemplate> OrderTemplates { get; set; } = null!;
    public virtual DbSet<OrderTemplateLine> OrderTemplateLines { get; set; } = null!;
    public virtual DbSet<OutOfOffice> OutOfOffices { get; set; } = null!;
    public virtual DbSet<Pctran> Pctrans { get; set; } = null!;
    public virtual DbSet<ProjectRequisition> ProjectRequisitions { get; set; } = null!;
    public virtual DbSet<ProjectRequisitionLine> ProjectRequisitionLines { get; set; } = null!;
    public virtual DbSet<ProposedPayment> ProposedPayments { get; set; } = null!;
    public virtual DbSet<ProposedPaymentLine> ProposedPaymentLines { get; set; } = null!;
    public virtual DbSet<PushNotificationToken> PushNotificationTokens { get; set; } = null!;
    public virtual DbSet<ReasonForLeaving> ReasonForLeavings { get; set; } = null!;
    public virtual DbSet<Receipt> Receipts { get; set; } = null!;
    public virtual DbSet<ReceiptBatchSerial> ReceiptBatchSerials { get; set; } = null!;
    public virtual DbSet<ReceiptBatchSerialAttribute> ReceiptBatchSerialAttributes { get; set; } = null!;
    public virtual DbSet<ReceiptLine> ReceiptLines { get; set; } = null!;
    public virtual DbSet<RequestForQuote> RequestForQuotes { get; set; } = null!;
    public virtual DbSet<ResetCode> ResetCodes { get; set; } = null!;
    public virtual DbSet<RestrictedNominal> RestrictedNominals { get; set; } = null!;
    public virtual DbSet<Sage50AccountNumber> Sage50AccountNumbers { get; set; } = null!;
    public virtual DbSet<Sage50Currency> Sage50Currencies { get; set; } = null!;
    public virtual DbSet<Sage50Department> Sage50Departments { get; set; } = null!;
    public virtual DbSet<Sage50NominalLedger> Sage50NominalLedgers { get; set; } = null!;
    public virtual DbSet<Sage50Project> Sage50Projects { get; set; } = null!;
    public virtual DbSet<Sage50ProjectCostCode> Sage50ProjectCostCodes { get; set; } = null!;
    public virtual DbSet<Sage50ProjectCostType> Sage50ProjectCostTypes { get; set; } = null!;
    public virtual DbSet<Sage50ProjectResource> Sage50ProjectResources { get; set; } = null!;
    public virtual DbSet<Sage50ProjectStatus> Sage50ProjectStatuses { get; set; } = null!;
    public virtual DbSet<Sage50PurchaseLedger> Sage50PurchaseLedgers { get; set; } = null!;
    public virtual DbSet<Sage50TaxCode> Sage50TaxCodes { get; set; } = null!;
    public virtual DbSet<SageDatabase> SageDatabases { get; set; } = null!;
    public virtual DbSet<SageDatabaseReportField> SageDatabaseReportFields { get; set; } = null!;
    public virtual DbSet<SageDatabaseSystemSetting> SageDatabaseSystemSettings { get; set; } = null!;
    public virtual DbSet<SalesInvoiceLayout> SalesInvoiceLayouts { get; set; } = null!;
    public virtual DbSet<SalesOrder> SalesOrders { get; set; } = null!;
    public virtual DbSet<SalesOrderAcknowledgementLayout> SalesOrderAcknowledgementLayouts { get; set; } = null!;
    public virtual DbSet<SalesOrderCrmdetail> SalesOrderCrmdetails { get; set; } = null!;
    public virtual DbSet<SalesOrderLine> SalesOrderLines { get; set; } = null!;
    public virtual DbSet<SalesOrderPriceBand> SalesOrderPriceBands { get; set; } = null!;
    public virtual DbSet<SalesOrderReport> SalesOrderReports { get; set; } = null!;
    public virtual DbSet<SalesOrderReportMapping> SalesOrderReportMappings { get; set; } = null!;
    public virtual DbSet<SalesOrderShipping> SalesOrderShippings { get; set; } = null!;
    public virtual DbSet<SalesOrderShippingLine> SalesOrderShippingLines { get; set; } = null!;
    public virtual DbSet<SalesQuoteLayout> SalesQuoteLayouts { get; set; } = null!;
    public virtual DbSet<ServiceNotification> ServiceNotifications { get; set; } = null!;
    public virtual DbSet<Setting> Settings { get; set; } = null!;
    public virtual DbSet<StockItem> StockItems { get; set; } = null!;
    public virtual DbSet<SubsistenceGrade> SubsistenceGrades { get; set; } = null!;
    public virtual DbSet<SubsistenceIncidental> SubsistenceIncidentals { get; set; } = null!;
    public virtual DbSet<SubsistenceRate> SubsistenceRates { get; set; } = null!;
    public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
    public virtual DbSet<SystemMessage> SystemMessages { get; set; } = null!;
    public virtual DbSet<Theme> Themes { get; set; } = null!;
    public virtual DbSet<TimeInLieu> TimeInLieus { get; set; } = null!;
    public virtual DbSet<TimeRecord> TimeRecords { get; set; } = null!;
    public virtual DbSet<Timesheet> Timesheets { get; set; } = null!;
    public virtual DbSet<TimesheetDefault> TimesheetDefaults { get; set; } = null!;
    public virtual DbSet<TimesheetLine> TimesheetLines { get; set; } = null!;
    public virtual DbSet<TimesheetLineHour> TimesheetLineHours { get; set; } = null!;
    public virtual DbSet<TimesheetLineResourceHour> TimesheetLineResourceHours { get; set; } = null!;
    public virtual DbSet<TimesheetLockedWeek> TimesheetLockedWeeks { get; set; } = null!;
    public virtual DbSet<TimesheetPaymentLine> TimesheetPaymentLines { get; set; } = null!;
    public virtual DbSet<TimesheetPaymentLineHour> TimesheetPaymentLineHours { get; set; } = null!;
    public virtual DbSet<User> Users { get; set; } = null!;
    public virtual DbSet<UserContract> UserContracts { get; set; } = null!;
    public virtual DbSet<UserCostingHeader> UserCostingHeaders { get; set; } = null!;
    public virtual DbSet<UserCostingItem> UserCostingItems { get; set; } = null!;
    public virtual DbSet<UserCostingItemType> UserCostingItemTypes { get; set; } = null!;
    public virtual DbSet<UserCreditCardExpense> UserCreditCardExpenses { get; set; } = null!;
    public virtual DbSet<UserDepartment> UserDepartments { get; set; } = null!;
    public virtual DbSet<UserEmail> UserEmails { get; set; } = null!;
    public virtual DbSet<UserExpenseMeeting> UserExpenseMeetings { get; set; } = null!;
    public virtual DbSet<UserExpenseType> UserExpenseTypes { get; set; } = null!;
    public virtual DbSet<UserExpenseTypeNominal> UserExpenseTypeNominals { get; set; } = null!;
    public virtual DbSet<UserFavourite> UserFavourites { get; set; } = null!;
    public virtual DbSet<UserFavouriteAddress> UserFavouriteAddresses { get; set; } = null!;
    public virtual DbSet<UserHoliday> UserHolidays { get; set; } = null!;
    public virtual DbSet<UserHolidayRule> UserHolidayRules { get; set; } = null!;
    public virtual DbSet<UserItemValue> UserItemValues { get; set; } = null!;
    public virtual DbSet<UserJob> UserJobs { get; set; } = null!;
    public virtual DbSet<UserMileageBalance> UserMileageBalances { get; set; } = null!;
    public virtual DbSet<UserNominalAccount> UserNominalAccounts { get; set; } = null!;
    public virtual DbSet<UserOrderTemplate> UserOrderTemplates { get; set; } = null!;
    public virtual DbSet<UserPasswordHistory> UserPasswordHistories { get; set; } = null!;
    public virtual DbSet<UserProject> UserProjects { get; set; } = null!;
    public virtual DbSet<UserProjectItemType> UserProjectItemTypes { get; set; } = null!;
    public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
    public virtual DbSet<UserSageDatabase> UserSageDatabases { get; set; } = null!;
    public virtual DbSet<UserSelfApprovalValue> UserSelfApprovalValues { get; set; } = null!;
    public virtual DbSet<UserSetting> UserSettings { get; set; } = null!;
    public virtual DbSet<UserSubsistenceIncidental> UserSubsistenceIncidentals { get; set; } = null!;
    public virtual DbSet<UserSupplierFilterCode> UserSupplierFilterCodes { get; set; } = null!;
    public virtual DbSet<UserSystemSetting> UserSystemSettings { get; set; } = null!;
    public virtual DbSet<UserTimeRule> UserTimeRules { get; set; } = null!;
    public virtual DbSet<UserTimesheetSubmission> UserTimesheetSubmissions { get; set; } = null!;
    public virtual DbSet<UserTimesheetTeamDefault> UserTimesheetTeamDefaults { get; set; } = null!;
    public virtual DbSet<UserType> UserTypes { get; set; } = null!;
    public virtual DbSet<UserTypeSystemSetting> UserTypeSystemSettings { get; set; } = null!;
    public virtual DbSet<UserVehicle> UserVehicles { get; set; } = null!;
    public virtual DbSet<UserWarehouse> UserWarehouses { get; set; } = null!;
    public virtual DbSet<UserWeeklyContractedHour> UserWeeklyContractedHours { get; set; } = null!;
    public virtual DbSet<UserWorkPatternPayRate> UserWorkPatternPayRates { get; set; } = null!;
    public virtual DbSet<VNoDuplicateDoNo> VNoDuplicateDoNos { get; set; } = null!;
    public virtual DbSet<ValueBand> ValueBands { get; set; } = null!;
    public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
    public virtual DbSet<Domain.Models.Version> Versions { get; set; } = null!;
    public virtual DbSet<Wapproject> Wapprojects { get; set; } = null!;
    public virtual DbSet<WapprojectItem> WapprojectItems { get; set; } = null!;
    public virtual DbSet<WapprojectItemType> WapprojectItemTypes { get; set; } = null!;
    public virtual DbSet<WapprojectItemTypeDocumentType> WapprojectItemTypeDocumentTypes { get; set; } = null!;
    public virtual DbSet<Wapqueue> Wapqueues { get; set; } = null!;
    public virtual DbSet<Waptask> Waptasks { get; set; } = null!;
    public virtual DbSet<WarehouseNominalAccount> WarehouseNominalAccounts { get; set; } = null!;
    public virtual DbSet<WorkPattern> WorkPatterns { get; set; } = null!;
    public virtual DbSet<WorkPatternDay> WorkPatternDays { get; set; } = null!;
    public virtual DbSet<WorkPatternDayShift> WorkPatternDayShifts { get; set; } = null!;
    public virtual DbSet<WorkPatternPayRate> WorkPatternPayRates { get; set; } = null!;
    public virtual DbSet<WorkPatternRule> WorkPatternRules { get; set; } = null!;
    public virtual DbSet<WorkPatternShift> WorkPatternShifts { get; set; } = null!;

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => await base.SaveChangesAsync(cancellationToken);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnalysisLabel>(entity =>
        {
            entity.ToTable("AnalysisLabel");

            entity.Property(e => e.AnalysisLabelId).HasColumnName("AnalysisLabelID");

            entity.Property(e => e.ApprovableTier)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel1)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel10)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel2)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel3)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel4)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel5)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel6)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel7)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel8)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CheckLabel9)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel1)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel10)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel2)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel3)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel4)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel5)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel6)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel7)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel8)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextLabel9)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AnalysisValue>(entity =>
        {
            entity.ToTable("AnalysisValue");

            entity.HasIndex(e => new { e.ForeignKey, e.DocumentType, e.ApprovableTier }, "AnalysisValue_Index");

            entity.Property(e => e.AnalysisValueId).HasColumnName("AnalysisValueID");

            entity.Property(e => e.ApprovableTier)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TextValue1)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue10)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue2)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue3)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue4)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue5)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue6)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue7)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue8)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TextValue9)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApprovalHistory>(entity =>
        {
            entity.ToTable("ApprovalHistory");

            entity.HasIndex(e => new { e.OrderId, e.Source, e.ApprovalType, e.ApprovalHistoryId, e.ApprovalDate }, "ApprovalHistory_Index");

            entity.HasIndex(e => new { e.ApprovalUserId, e.Source }, "IX_ApprovalHistory_Source_OrderID");

            entity.Property(e => e.ApprovalHistoryId).HasColumnName("ApprovalHistoryID");

            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

            entity.Property(e => e.ApprovalText).IsUnicode(false);

            entity.Property(e => e.ApprovalType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ApprovalUserId).HasColumnName("ApprovalUserID");

            entity.Property(e => e.DelegateApprovalUserId).HasColumnName("DelegateApprovalUserID");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

            entity.Property(e => e.Rejected).HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApprovalHoldReason>(entity =>
        {
            entity.ToTable("ApprovalHoldReason");

            entity.Property(e => e.ApprovalHoldReasonId).HasColumnName("ApprovalHoldReasonID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HoldReason)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApprovalOption>(entity =>
        {
            entity.ToTable("ApprovalOption");

            entity.Property(e => e.ApprovalOptionId).HasColumnName("ApprovalOptionID");

            entity.Property(e => e.ApprovalValueSource)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ApproveAsSingleDoc).HasDefaultValueSql("((0))");

            entity.Property(e => e.ByJobManager).HasDefaultValueSql("((0))");

            entity.Property(e => e.ByNominalAccount).HasDefaultValueSql("((0))");

            entity.Property(e => e.ByProject).HasDefaultValueSql("((0))");

            entity.Property(e => e.ByProjectItem).HasDefaultValueSql("((0))");

            entity.Property(e => e.BySupplier).HasDefaultValueSql("((0))");

            entity.Property(e => e.ByUser).HasDefaultValueSql("((0))");

            entity.Property(e => e.ByValue).HasDefaultValueSql("((0))");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RequiresApproval).HasDefaultValueSql("((1))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApprovalRouteEntry>(entity =>
        {
            entity.ToTable("ApprovalRouteEntry");

            entity.HasIndex(e => new { e.CustomApprovalRoute, e.SageDatabaseId, e.NominalAccountId, e.Step, e.DocumentType }, "ApprovalRouteEntry_Index");

            entity.HasIndex(e => new { e.SageDatabaseId, e.CustomApprovalRoute, e.SupplierId, e.DocumentType, e.Step }, "IX_ApprovalRouteEntry_SageDatabaseID_CustomApprovalRoute_SupplierID_DocumentType_Step");

            entity.HasIndex(e => new { e.SageDatabaseId, e.NominalAccountId, e.RequestingUserId, e.ProjectId, e.ProjectItemId, e.ValueBandId, e.CustomApprovalRoute, e.DocumentType, e.Step, e.JobManager }, "IX_ApprovalRouteEntry_SageDatabaseID_NominalAccountID_RequestingUserID_Etc");

            entity.HasIndex(e => new { e.SageDatabaseId, e.RequestingUserId, e.CustomApprovalRoute, e.DocumentType, e.Step }, "IX_ApprovalRouteEntry_SageDatabaseID_RequestingUserID_CustomApprovalRoute_DocumentType_Step");

            entity.HasIndex(e => new { e.SageDatabaseId, e.RequestingUserId, e.CustomApprovalRoute, e.DocumentType, e.Step, e.JobManager }, "IX_ApprovalRouteEntry_SageDatabaseID_RequestingUserID_CustomApprovalRoute_DocumentType_Step_JobManager");

            entity.Property(e => e.ApprovalRouteEntryId).HasColumnName("ApprovalRouteEntryID");

            entity.Property(e => e.AllowPreviousApprovers).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApprovalRouteEntryType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomApprovalRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomApprovalRouteId).HasColumnName("CustomApprovalRouteID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryCustom1).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom2).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom3).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryIfOverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.NominalAccountId).HasColumnName("NominalAccountID");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.RequestingUserId).HasColumnName("RequestingUserID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ValueBandId).HasColumnName("ValueBandID");
        });

        modelBuilder.Entity<ApprovalRouteEntryItem>(entity =>
        {
            entity.ToTable("ApprovalRouteEntryItem");

            entity.HasIndex(e => e.ApprovalRouteEntryId, "ApprovalRouteEntryItem_Index");

            entity.Property(e => e.ApprovalRouteEntryItemId).HasColumnName("ApprovalRouteEntryItemID");

            entity.Property(e => e.ApprovalRouteEntryId).HasColumnName("ApprovalRouteEntryID");

            entity.Property(e => e.ApproverId).HasColumnName("ApproverID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApprovalRouteProgress>(entity =>
        {
            entity.ToTable("ApprovalRouteProgress");

            entity.HasIndex(e => new { e.Approved, e.Rejected, e.DocumentType }, "IX_ApprovalRouteProgress_Approved_Rejected_DocumentType");

            entity.HasIndex(e => new { e.ApproverId, e.Approved, e.Rejected, e.DocumentType }, "IX_ApprovalRouteProgress_ApproverID_Approved_Rejected_DocumentType");

            entity.HasIndex(e => new { e.IapprovableId, e.IapprovableParentId, e.DocumentType }, "IX_ApprovalRouteProgress_IAppID_IAppParentID_DocType");

            entity.HasIndex(e => new { e.IapprovableParentId, e.ApproverId, e.Step, e.Approved, e.Rejected, e.DocumentType }, "IX_ApprovalRouteProgress_IApprovableParentID_ApproverID_Step_Approved_Rejected_DocumentType");

            entity.HasIndex(e => new { e.OutOfOfficeApprover, e.OutOfOfficeOriginalApproverId }, "IX_ApprovalRouteProgress_OutOfOfficeApprover_OutOfOfficeOriginalApproverID");

            entity.Property(e => e.ApprovalRouteProgressId).HasColumnName("ApprovalRouteProgressID");

            entity.Property(e => e.AllowPreviousApprovers).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApprovalRouteEntryId).HasColumnName("ApprovalRouteEntryID");

            entity.Property(e => e.ApprovalRouteEntryItemId).HasColumnName("ApprovalRouteEntryItemID");

            entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproverId).HasColumnName("ApproverID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.IapprovableId).HasColumnName("IApprovableID");

            entity.Property(e => e.IapprovableParentId).HasColumnName("IApprovableParentID");

            entity.Property(e => e.Mandatory).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom1).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom2).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom3).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryIfOverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OutOfOfficeApprover).HasDefaultValueSql("((0))");

            entity.Property(e => e.OutOfOfficeOriginalApproverId)
                .HasColumnName("OutOfOfficeOriginalApproverID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Rejected).HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApprovalRouteReportDetailView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ApprovalRouteReportDetailView");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NominalAccountId).HasColumnName("NominalAccountID");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.RequestingUserId).HasColumnName("RequestingUserID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.UserItemValueType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ValueBandId).HasColumnName("ValueBandID");
        });

        modelBuilder.Entity<ApprovalRouteReportHeaderView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ApprovalRouteReportHeaderView");

            entity.Property(e => e.ApprovalRouteEntryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ApprovalRouteEntryID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NominalAccountId).HasColumnName("NominalAccountID");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.RequestingUserId).HasColumnName("RequestingUserID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.ValueBandId).HasColumnName("ValueBandID");
        });

        modelBuilder.Entity<ApprovalRouteReportView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ApprovalRouteReportView");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NominalAccountId).HasColumnName("NominalAccountID");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.RequestingUserId).HasColumnName("RequestingUserID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.UserItemValueType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ValueBandId).HasColumnName("ValueBandID");

            entity.Property(e => e._0).HasColumnName("0");

            entity.Property(e => e._1).HasColumnName("1");

            entity.Property(e => e._2).HasColumnName("2");

            entity.Property(e => e._3).HasColumnName("3");

            entity.Property(e => e._4).HasColumnName("4");

            entity.Property(e => e._5).HasColumnName("5");

            entity.Property(e => e._6).HasColumnName("6");

            entity.Property(e => e._7).HasColumnName("7");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.ToTable("AuditLog");

            entity.HasIndex(e => e.ClassFullName, "IX_AuditLog_ClassFullName");

            entity.HasIndex(e => new { e.ClassFullName, e.ForeignParentKey }, "IX_AuditLog_ClassFullName_ForeignParentKey");

            entity.HasIndex(e => new { e.DocumentType, e.ClassFullName, e.ApprovableParentKey, e.ApprovableKey }, "IX_AuditLog_DocumentType_ClassFullName_ApprovableParentKey_ApprovableKey");

            entity.HasIndex(e => new { e.ForeignParentKey, e.ClassFullName }, "IX_AuditLog_ForeignParentKey_ClassFullName");

            entity.Property(e => e.AuditLogId).HasColumnName("AuditLogID");

            entity.Property(e => e.AuditAction)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AuditDescription).IsUnicode(false);

            entity.Property(e => e.CallStack).IsUnicode(false);

            entity.Property(e => e.ClassFullName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ItemDescription).IsUnicode(false);

            entity.Property(e => e.LoggedInUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedValue).IsUnicode(false);

            entity.Property(e => e.OriginalValue).IsUnicode(false);

            entity.Property(e => e.PropertyDescription)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
        });

        modelBuilder.Entity<BankHoliday>(entity =>
        {
            entity.ToTable("BankHoliday");

            entity.Property(e => e.BankHolidayId).HasColumnName("BankHolidayID");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BudgetEnquiry>(entity =>
        {
            entity.ToTable("BudgetEnquiry");

            entity.Property(e => e.BudgetEnquiryId).HasColumnName("BudgetEnquiryID");

            entity.Property(e => e.Credit).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.Debit).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Net).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.NlnominalAccountId).HasColumnName("NLNominalAccountID");

            entity.Property(e => e.NominalAccountCostCentre)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.NominalAccountDepartment)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.NominalAccountName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.NominalAccountNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OrderedBy)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

            entity.Property(e => e.PlsupplierAccountId).HasColumnName("PLSupplierAccountID");

            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PONumber");

            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SecondReference)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SupplierAccountName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.SupplierAccountNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Urn).HasColumnName("URN");

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<CalendarLabel>(entity =>
        {
            entity.ToTable("CalendarLabel");

            entity.Property(e => e.CalendarLabelId).HasColumnName("CalendarLabelID");

            entity.Property(e => e.CalendarSource)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Colour)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City");

            entity.Property(e => e.CityId).HasColumnName("CityID");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConstructDatabase>(entity =>
        {
            entity.ToTable("ConstructDatabase");

            entity.Property(e => e.ConstructDatabaseId).HasColumnName("ConstructDatabaseID");

            entity.Property(e => e.ConnectString)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConstructionApplication>(entity =>
        {
            entity.ToTable("ConstructionApplication");

            entity.Property(e => e.ConstructionApplicationId).HasColumnName("ConstructionApplicationID");

            entity.Property(e => e.ApplicationAppliedFor).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationAppliedForNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

            entity.Property(e => e.ApplicationExpiryDate).HasColumnType("datetime");

            entity.Property(e => e.ApplicationInvoiced).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationInvoicedNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationInvoicedRet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationPostedDate).HasColumnType("datetime");

            entity.Property(e => e.ApplicationReceived).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationReceivedNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationReceivedRet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationRef)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationRef2)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationTax).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationTaxNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationValued).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationValuedDate).HasColumnType("datetime");

            entity.Property(e => e.ApplicationValuedNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.AppliedForQuantity).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CostCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.Property(e => e.CustomerReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.InvoiceReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceUrn).HasColumnName("InvoiceURN");

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdatedByDateTime).HasColumnType("datetime");

            entity.Property(e => e.LineStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OpeningBalanceNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OpeningBalanceRet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.PayLessDate).HasColumnType("datetime");

            entity.Property(e => e.PaymentDueDate).HasColumnType("datetime");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.Queried)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Retention1Id).HasColumnName("Retention1ID");

            entity.Property(e => e.Retention2Id).HasColumnName("Retention2ID");

            entity.Property(e => e.Retention3Id).HasColumnName("Retention3ID");

            entity.Property(e => e.Retention4Id).HasColumnName("Retention4ID");

            entity.Property(e => e.RetentionDate1).HasColumnType("datetime");

            entity.Property(e => e.RetentionDate2).HasColumnType("datetime");

            entity.Property(e => e.RetentionDate3).HasColumnType("datetime");

            entity.Property(e => e.RetentionDate4).HasColumnType("datetime");

            entity.Property(e => e.RetentionPercentage1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercentage2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercentage3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercentage4).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionTotal).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RiskValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SageApplicationId).HasColumnName("SageApplicationID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SiJctrnApplicationGross)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("SiJCTrnApplicationGross");

            entity.Property(e => e.SiJctrnDicount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("SiJCTrnDicount");

            entity.Property(e => e.SijcempId).HasColumnName("SIJCEmpID");

            entity.Property(e => e.SoporderReturnLineId).HasColumnName("SOPOrderReturnLineID");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.SupplierReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SysaccountingPeriodId).HasColumnName("SYSAccountingPeriodID");

            entity.Property(e => e.SysfinancialYearId).HasColumnName("SYSFinancialYearID");

            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ValuationDate).HasColumnType("datetime");

            entity.Property(e => e.ValuedQuantity).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<ConstructionApplicationLine>(entity =>
        {
            entity.ToTable("ConstructionApplicationLine");

            entity.Property(e => e.ConstructionApplicationLineId).HasColumnName("ConstructionApplicationLineID");

            entity.Property(e => e.AccumulatedTotal).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationValued).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationValuedDate).HasColumnType("datetime");

            entity.Property(e => e.ApplicationValuedNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ApplicationValuedRet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConstructionApplicationId).HasColumnName("ConstructionApplicationID");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoicedValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.InvoicedValueNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.JobDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LineStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Narrative)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");

            entity.Property(e => e.ReceivedValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.Retention1Id).HasColumnName("Retention1ID");

            entity.Property(e => e.Retention2Id).HasColumnName("Retention2ID");

            entity.Property(e => e.Retention3Id).HasColumnName("Retention3ID");

            entity.Property(e => e.Retention4Id).HasColumnName("Retention4ID");

            entity.Property(e => e.RetentionDate1).HasColumnType("datetime");

            entity.Property(e => e.RetentionDate2).HasColumnType("datetime");

            entity.Property(e => e.RetentionDate3).HasColumnType("datetime");

            entity.Property(e => e.RetentionDate4).HasColumnType("datetime");

            entity.Property(e => e.RetentionPercentage1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercentage2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercentage3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercentage4).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionTotal).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionValue1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionValue2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionValue3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionValue4).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageLineId).HasColumnName("SageLineID");

            entity.Property(e => e.SiJcEmpId).HasColumnName("SiJcEmpID");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

            entity.Property(e => e.TaxValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TaxValueNet).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ValuationType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ValueQuantity).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<ConstructionValuation>(entity =>
        {
            entity.ToTable("ConstructionValuation");

            entity.Property(e => e.ConstructionValuationId).HasColumnName("ConstructionValuationID");

            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

            entity.Property(e => e.Cis)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CIS");

            entity.Property(e => e.Citbvalue)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CITBValue");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.DefaultInvoiceNumber)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.GrossApplication).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Invoiced).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LabourPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LabourValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LineStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MaterialValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Note)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.OtherValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.PaymentDue).HasColumnType("datetime");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Reference2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RetentionPercent1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercent2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercent3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionPercent4).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionValue1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionValue2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionValue3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RetentionValue4).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Retentions).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageValuationId).HasColumnName("SageValuationID");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.Supplier)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Valued).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<ConstructionValuationLine>(entity =>
        {
            entity.ToTable("ConstructionValuationLine");

            entity.Property(e => e.ConstructionValuationLineId).HasColumnName("ConstructionValuationLineID");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

            entity.Property(e => e.ApplicationValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConstructionValuationId).HasColumnName("ConstructionValuationID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Narrative)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.NetValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.NominalAccountId).HasColumnName("NominalAccountID");

            entity.Property(e => e.NominalCostCentre)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.NominalDepartment)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.NominalName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.NominalReference)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PhaseId).HasColumnName("PhaseID");

            entity.Property(e => e.ProjectHeaderId).HasColumnName("ProjectHeaderID");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StageId).HasColumnName("StageID");

            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

            entity.Property(e => e.TaxCodeString)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.TaxValue).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<CostDept>(entity =>
        {
            entity.ToTable("CostDept");

            entity.Property(e => e.CostDeptId).HasColumnName("CostDeptID");

            entity.Property(e => e.AccountNumberId).HasColumnName("AccountNumberID");

            entity.Property(e => e.ApprovalRouteType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId)
                .HasColumnName("CustomRouteID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.RequestingUserId).HasColumnName("RequestingUserID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<CostDeptArchive>(entity =>
        {
            entity.ToTable("CostDeptArchive");

            entity.Property(e => e.CostDeptArchiveId).HasColumnName("CostDeptArchiveID");

            entity.Property(e => e.AccountNumberId).HasColumnName("AccountNumberID");

            entity.Property(e => e.ApprovalRouteType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ArchivedDate).HasColumnType("datetime");

            entity.Property(e => e.ArchivedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CostDeptId).HasColumnName("CostDeptID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.RequestingUserId).HasColumnName("RequestingUserID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<CostDeptRule>(entity =>
        {
            entity.ToTable("CostDeptRule");

            entity.Property(e => e.CostDeptRuleId).HasColumnName("CostDeptRuleID");

            entity.Property(e => e.CostDeptId).HasColumnName("CostDeptID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ValueUpTo).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.Property(e => e.Alpha2)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Alpha3)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.DefaultCountry).HasDefaultValueSql("((0))");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MileageUnit)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MileageYearChange).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Selectable).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CreditCard>(entity =>
        {
            entity.ToTable("CreditCard");

            entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CardNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CardSupplier)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardFieldMappingId).HasColumnName("CreditCardFieldMappingID");

            entity.Property(e => e.DebitCreditCardType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDate)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Issuer)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Selectable).HasDefaultValueSql("((0))");

            entity.Property(e => e.SortCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SupplierAccountId).HasColumnName("SupplierAccountID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CreditCardStatement>(entity =>
        {
            entity.ToTable("CreditCardStatement");

            entity.Property(e => e.CreditCardStatementId).HasColumnName("CreditCardStatementID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Filename)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ImportedByUserId)
                .HasColumnName("ImportedByUserID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.StatementDate).HasColumnType("datetime");

            entity.Property(e => e.StatementImportDate).HasColumnType("datetime");

            entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CreditCardStatementLayout>(entity =>
        {
            entity.ToTable("CreditCardStatementLayout");

            entity.Property(e => e.CreditCardStatementLayoutId).HasColumnName("CreditCardStatementLayoutID");

            entity.Property(e => e.CommentChar)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Delimiter)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EscapeChar)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.QouteChar)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Selectable).HasDefaultValueSql("((1))");

            entity.Property(e => e.StatementDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CreditCardStatementLine>(entity =>
        {
            entity.ToTable("CreditCardStatementLine");

            entity.Property(e => e.CreditCardStatementLineId).HasColumnName("CreditCardStatementLineID");

            entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

            entity.Property(e => e.CreditCardStatementId).HasColumnName("CreditCardStatementID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.Property(e => e.TransactionValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<CsvimportFileInfo>(entity =>
        {
            entity.HasKey(e => e.CsvimportInfoId);

            entity.ToTable("CSVImportFileInfo");

            entity.Property(e => e.CsvimportInfoId).HasColumnName("CSVImportInfoID");

            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ImportType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomCrmfield>(entity =>
        {
            entity.ToTable("CustomCRMField");

            entity.Property(e => e.CustomCrmfieldId).HasColumnName("CustomCRMFieldID");

            entity.Property(e => e.CrmentityId)
                .HasColumnName("CRMEntityID")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Ordinal).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CustomPage>(entity =>
        {
            entity.ToTable("CustomPage");

            entity.Property(e => e.CustomPageId).HasColumnName("CustomPageID");

            entity.Property(e => e.PageDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PageName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PageType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine4)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ContactEmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ContactFaxAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactFaxCountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ContactFaxNumber)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactMobileAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactMobileCountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ContactMobileNumber)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactTelephoneAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactTelephoneCountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ContactTelephoneNumber)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactWebsite)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.County)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.CustomerAccountRef)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CustomerShortName)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LineStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.PostCode)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Salutation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SlaccountId).HasColumnName("SLAccountID");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.SyscountryCodeId).HasColumnName("SYSCountryCodeID");

            entity.Property(e => e.SyscurrencyId).HasColumnName("SYSCurrencyID");

            entity.Property(e => e.TelephoneAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TelephoneCountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TelephoneNumber)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TradingDefaultNominalCodeId).HasColumnName("TradingDefaultNominalCodeID");

            entity.Property(e => e.TradingDefaultTaxCodeId).HasColumnName("TradingDefaultTaxCodeID");

            entity.Property(e => e.TradingDunsnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TradingDUNSNumber");

            entity.Property(e => e.TradingOrderPriority)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TradingSyscountryCodeId).HasColumnName("TradingSYSCountryCodeID");

            entity.Property(e => e.TradingTaxCodeSopdefault).HasColumnName("TradingTaxCodeSOPDefault");

            entity.Property(e => e.TradingTaxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.WebSite)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerAnalysisValue>(entity =>
        {
            entity.ToTable("CustomerAnalysisValue");

            entity.Property(e => e.CustomerAnalysisValueId).HasColumnName("CustomerAnalysisValueID");

            entity.Property(e => e.AnalysisCodeId).HasColumnName("AnalysisCodeID");

            entity.Property(e => e.AnalysisValue)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Mandatory).HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customisation>(entity =>
        {
            entity.ToTable("Customisation");

            entity.Property(e => e.CustomisationId).HasColumnName("CustomisationID");

            entity.Property(e => e.ControlName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ParentContainer)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ToolTip)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Declaration>(entity =>
        {
            entity.ToTable("Declaration");

            entity.Property(e => e.DeclarationId).HasColumnName("DeclarationID");

            entity.Property(e => e.ApprovableTier)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeclarationText)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceLineType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeclarationConfirmation>(entity =>
        {
            entity.ToTable("DeclarationConfirmation");

            entity.Property(e => e.DeclarationConfirmationId).HasColumnName("DeclarationConfirmationID");

            entity.Property(e => e.ApprovableId).HasColumnName("ApprovableID");

            entity.Property(e => e.ApprovableItemId).HasColumnName("ApprovableItemID");

            entity.Property(e => e.DeclarationId).HasColumnName("DeclarationID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Domain.Models.Delegate>(entity =>
        {
            entity.ToTable("Delegate");

            entity.Property(e => e.DelegateId).HasColumnName("DelegateID");

            entity.Property(e => e.DelegateUserId).HasColumnName("DelegateUserID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<DeliveryAddress>(entity =>
        {
            entity.ToTable("DeliveryAddress");

            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");

            entity.Property(e => e.Address1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DefaultInvoiceAddress).HasDefaultValueSql("((0))");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DropDownDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.FaxNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.IsCustomAddress).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsMainAddress).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsSageAddress).HasDefaultValueSql("((0))");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PlsupplierAccountId)
                .HasColumnName("PLSupplierAccountID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.PostCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PostalName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId)
                .HasColumnName("SageDatabaseID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SageDatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.TelephoneNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.Property(e => e.WebAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeliveryAddressStockItem>(entity =>
        {
            entity.ToTable("DeliveryAddressStockItem");

            entity.Property(e => e.DeliveryAddressStockItemId).HasColumnName("DeliveryAddressStockItemID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeliveryAddressId)
                .HasColumnName("DeliveryAddressID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SageDatabaseId)
                .HasColumnName("SageDatabaseID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.StockItemId)
                .HasColumnName("StockItemID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ForeignId)
                .HasColumnName("ForeignID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Despatch>(entity =>
        {
            entity.ToTable("Despatch");

            entity.Property(e => e.DespatchId).HasColumnName("DespatchID");

            entity.Property(e => e.CustomerAccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerDocumentDate).HasColumnType("datetime");

            entity.Property(e => e.CustomerDocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.Property(e => e.DespatchDate).HasColumnType("datetime");

            entity.Property(e => e.Gdnnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GDNNumber");

            entity.Property(e => e.Narrative)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<DespatchLine>(entity =>
        {
            entity.ToTable("DespatchLine");

            entity.Property(e => e.DespatchLineId).HasColumnName("DespatchLineID");

            entity.Property(e => e.DespatchDate).HasColumnType("datetime");

            entity.Property(e => e.DespatchId).HasColumnName("DespatchID");

            entity.Property(e => e.QuantityDespatched).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.QuantityInvoiced)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

            entity.Property(e => e.SalesOrderLineId).HasColumnName("SalesOrderLineID");

            entity.Property(e => e.SopdespatchReceiptLineId).HasColumnName("SOPDespatchReceiptLineID");

            entity.Property(e => e.SoporderReturnLineId).HasColumnName("SOPOrderReturnLineID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.ToTable("Discount");

            entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

            entity.Property(e => e.AddedById).HasColumnName("AddedByID");

            entity.Property(e => e.AddedDate).HasColumnType("datetime");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BaseValue)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Reason)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SalesOrderLineId).HasColumnName("SalesOrderLineID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.ToTable("DocumentType");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentType");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocumentTypeReminder>(entity =>
        {
            entity.ToTable("DocumentTypeReminder");

            entity.Property(e => e.DocumentTypeReminderId).HasColumnName("DocumentTypeReminderID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NextSendTime).HasColumnType("datetime");

            entity.Property(e => e.PriorityId).HasColumnName("PriorityID");

            entity.Property(e => e.ReminderDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ReminderInterval)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReminderOption)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReminderText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TimeOfDay).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UseOooalternate).HasColumnName("UseOOOAlternate");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity.ToTable("Email");

            entity.Property(e => e.EmailId).HasColumnName("EmailID");

            entity.Property(e => e.Body).IsUnicode(false);

            entity.Property(e => e.DateSent).HasColumnType("datetime");

            entity.Property(e => e.Failed).HasDefaultValueSql("((0))");

            entity.Property(e => e.FailedReason).IsUnicode(false);

            entity.Property(e => e.Recipient)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Sender)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmailThread>(entity =>
        {
            entity.ToTable("EmailThread");

            entity.Property(e => e.EmailThreadId).HasColumnName("EmailThreadID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.IncludeSentItems).HasDefaultValueSql("((0))");

            entity.Property(e => e.NextEmailSendTime).HasColumnType("datetime");

            entity.Property(e => e.SendAwaitingApproval).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendComplete).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendEmailRecords).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendFriday).HasDefaultValueSql("((1))");

            entity.Property(e => e.SendFullyAllocated).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendFullyApproved).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendGoodsReceived).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendMonday).HasDefaultValueSql("((1))");

            entity.Property(e => e.SendNoApprovers).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendPartAllocated).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendPostedToSage).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendRejected).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendSaturday).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendSummary).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendSunday).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendThursday).HasDefaultValueSql("((1))");

            entity.Property(e => e.SendTuesday).HasDefaultValueSql("((1))");

            entity.Property(e => e.SendWednesday).HasDefaultValueSql("((1))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WindowEnd).HasColumnType("datetime");

            entity.Property(e => e.WindowStart).HasColumnType("datetime");
        });

        modelBuilder.Entity<EntityLock>(entity =>
        {
            entity.HasKey(e => new { e.EntityKey, e.EntityType })
                .HasName("PK_EntityLocks");

            entity.ToTable("EntityLock");

            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EntityLockContext)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EntityLockDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EntityLockSource)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EntityUserId).HasColumnName("EntityUserID");
        });

        modelBuilder.Entity<EventLog>(entity =>
        {
            entity.ToTable("EventLog");

            entity.Property(e => e.EventLogId).HasColumnName("EventLogID");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EventLogEntryType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EventMessage).IsUnicode(false);

            entity.Property(e => e.EventSource)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LineId).HasColumnName("LineID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExpenseLine>(entity =>
        {
            entity.ToTable("ExpenseLine");

            entity.HasIndex(e => new { e.InvoiceLineId, e.Deleted }, "IX_ExpenseLine_InvoiceLineID_Deleted");

            entity.Property(e => e.ExpenseLineId).HasColumnName("ExpenseLineID");

            entity.Property(e => e.Absence).HasDefaultValueSql("((0))");

            entity.Property(e => e.Alcohol).HasDefaultValueSql("((0))");

            entity.Property(e => e.AllowNegativeAmounts).HasDefaultValueSql("((0))");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.AmountInAccountCurrency).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.AmountInBaseCurrency).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CityId)
                .HasColumnName("CityID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Conference).HasDefaultValueSql("((0))");

            entity.Property(e => e.CountryId)
                .HasColumnName("CountryID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Detention).HasDefaultValueSql("((0))");

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.EntertainmentDetail)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.EntertainmentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ExchangeRateAccount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ExpenseDate).HasColumnType("datetime");

            entity.Property(e => e.ExpenseDateEndDate).HasColumnType("datetime");

            entity.Property(e => e.ExpensePaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");

            entity.Property(e => e.FirstClass).HasDefaultValueSql("((0))");

            entity.Property(e => e.GratuityIncluded).HasDefaultValueSql("((0))");

            entity.Property(e => e.GratuityValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.InvoiceLineId).HasColumnName("InvoiceLineID");

            entity.Property(e => e.Notes)
                .HasMaxLength(3000)
                .IsUnicode(false);

            entity.Property(e => e.OrderLineId)
                .HasColumnName("OrderLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Overnight).HasDefaultValueSql("((0))");

            entity.Property(e => e.ReceiptAttached)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NA')");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.Subsistence).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubsistenceAccommodation).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubsistenceBreakfast).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubsistenceDetail)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SubsistenceDinner).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubsistenceGradeId)
                .HasColumnName("SubsistenceGradeID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SubsistenceIncidentalId).HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SubsistenceIncidentals).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubsistenceLunch).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubsistenceRateConference).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SubsistenceRateDayRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SubsistenceRateDetention).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SubsistenceRateReduced).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SubsistenceRateStandard).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SubsistenceType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SyscurrencyId).HasColumnName("SYSCurrencyID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExpenseMeeting>(entity =>
        {
            entity.ToTable("ExpenseMeeting");

            entity.Property(e => e.ExpenseMeetingId).HasColumnName("ExpenseMeetingID");

            entity.Property(e => e.AnalysisCode1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.MeetingCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MeetingDescription)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.MeetingName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExpenseType>(entity =>
        {
            entity.ToTable("ExpenseType");

            entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");

            entity.Property(e => e.Accommodation).HasDefaultValueSql("((0))");

            entity.Property(e => e.CategoryComponentId)
                .HasColumnName("CategoryComponentID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.ExpenseTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.MaximumClaim).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Meals).HasDefaultValueSql("((0))");

            entity.Property(e => e.Memo).IsUnicode(false);

            entity.Property(e => e.MinimumRequiredAttachments).HasDefaultValueSql("((0))");

            entity.Property(e => e.MinimumRequiredAttachmentsNoReceipt).HasDefaultValueSql("((0))");

            entity.Property(e => e.NlnominalAccountId)
                .HasColumnName("NLNominalAccountID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ParentCategoryComponentId)
                .HasColumnName("ParentCategoryComponentID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ProjectItemId)
                .HasColumnName("ProjectItemID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SageDatabaseId)
                .HasColumnName("SageDatabaseID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SystaxCodeId)
                .HasColumnName("SYSTaxCodeID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.System).HasDefaultValueSql("((0))");

            entity.Property(e => e.Travel).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Favouritable>(entity =>
        {
            entity.ToTable("Favouritable");

            entity.Property(e => e.FavouritableId).HasColumnName("FavouritableID");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ParentContainer)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ToolTip)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Domain.Models.File>(entity =>
        {
            entity.ToTable("File");

            entity.HasIndex(e => new { e.ForeignChildKey, e.FileSource }, "IX_File_ForeignChildKey_FileSource");

            entity.Property(e => e.FileId).HasColumnName("FileID");

            entity.Property(e => e.ContentType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.FileData).HasColumnType("image");

            entity.Property(e => e.FileGuid).HasDefaultValueSql("(newid())");

            entity.Property(e => e.FileName)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.FileSource)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ForeignChildKey).HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.OriginalFileName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FuelRate>(entity =>
        {
            entity.ToTable("FuelRate");

            entity.Property(e => e.FuelRateId).HasColumnName("FuelRateID");

            entity.Property(e => e.CompanyPrivate)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.Property(e => e.EngineSize)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FuelComponentRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.FuelType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LowerRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PerPassenger).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpperRate).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<FuelRateCutoff>(entity =>
        {
            entity.ToTable("FuelRateCutoff");

            entity.Property(e => e.FuelRateCutoffId).HasColumnName("FuelRateCutoffID");

            entity.Property(e => e.Cutoff).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.FuelRateHistoryId).HasColumnName("FuelRateHistoryID");

            entity.Property(e => e.Rate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FuelRateCutoffSageDatabase>(entity =>
        {
            entity.ToTable("FuelRateCutoffSageDatabase");

            entity.Property(e => e.FuelRateCutoffSageDatabaseId).HasColumnName("FuelRateCutoffSageDatabaseID");

            entity.Property(e => e.FuelRateCutoffId).HasColumnName("FuelRateCutoffID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.TscategoryComponentId).HasColumnName("TSCategoryComponentID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FuelRateHistory>(entity =>
        {
            entity.ToTable("FuelRateHistory");

            entity.Property(e => e.FuelRateHistoryId).HasColumnName("FuelRateHistoryID");

            entity.Property(e => e.FuelComponentRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.FuelRateId).HasColumnName("FuelRateID");

            entity.Property(e => e.LowerRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PerPassenger).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RateStartDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpperRate).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<GoodsReceived>(entity =>
        {
            entity.ToTable("GoodsReceived");

            entity.Property(e => e.GoodsReceivedId).HasColumnName("GoodsReceivedID");

            entity.Property(e => e.LineTypeId)
                .HasColumnName("LineTypeID")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Narrative)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PoporderReturnLineId).HasColumnName("POPOrderReturnLineID");

            entity.Property(e => e.QuantityReceived).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ReceivedById)
                .HasColumnName("ReceivedByID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SupplierGrn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SupplierGRN");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Wapgrnno)
                .HasColumnName("WAPGRNNo")
                .HasDefaultValueSql("((-2147483648))");
        });

        modelBuilder.Entity<HolidayDefaultTimesheetProject>(entity =>
        {
            entity.ToTable("HolidayDefaultTimesheetProject");

            entity.Property(e => e.HolidayDefaultTimesheetProjectId).HasColumnName("HolidayDefaultTimesheetProjectID");

            entity.Property(e => e.ChargeRateTypeId).HasColumnName("ChargeRateTypeID");

            entity.Property(e => e.CostRateTypeId).HasColumnName("CostRateTypeID");

            entity.Property(e => e.PayRateTypeId).HasColumnName("PayRateTypeID");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId)
                .HasColumnName("UserID")
                .HasDefaultValueSql("((-2147483648))");
        });

        modelBuilder.Entity<HolidayRequest>(entity =>
        {
            entity.ToTable("HolidayRequest");

            entity.HasIndex(e => new { e.Deleted, e.RequestedById }, "IX_HolidayRequest_Deleted_RequestedByID");

            entity.Property(e => e.HolidayRequestId).HasColumnName("HolidayRequestID");

            entity.Property(e => e.Adjustment).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EnteredById).HasColumnName("EnteredByID");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.TotalDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TotalHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HolidayRequestLine>(entity =>
        {
            entity.ToTable("HolidayRequestLine");

            entity.HasIndex(e => new { e.Deleted, e.RequestedById, e.Unpaid, e.Cancelled, e.Toil, e.StartTime, e.EndTime, e.LineStatus, e.DocumentType }, "IX_HolidayRequestLine_Deleted_RequestedByID_Unpaid_Cancelled_TOIL_StartTime_EndTime_LineStatus_DocumentType");

            entity.HasIndex(e => new { e.HolidayRequestId, e.Deleted, e.Cancelled, e.DocumentType }, "IX_HolidayRequestLine_HolidayRequestID_Deleted_Cancelled_DocumentType");

            entity.Property(e => e.HolidayRequestLineId).HasColumnName("HolidayRequestLineID");

            entity.Property(e => e.Adjustment).HasDefaultValueSql("((0))");

            entity.Property(e => e.AlternativeUserId).HasColumnName("AlternativeUserID");

            entity.Property(e => e.BreakAmount)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Cancelled).HasDefaultValueSql("((0))");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.Days).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

            entity.Property(e => e.HideDescription).HasDefaultValueSql("((0))");

            entity.Property(e => e.HolidayRequestId).HasColumnName("HolidayRequestID");

            entity.Property(e => e.Hours)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.LastPostedDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LastPostedHours)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

            entity.Property(e => e.LineStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LineType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.RejectReason)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Remove).HasDefaultValueSql("((0))");

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.Toil)
                .HasColumnName("TOIL")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ToilbankMonth).HasColumnName("TOILBankMonth");

            entity.Property(e => e.ToilbankPeriodId).HasColumnName("TOILBankPeriodID");

            entity.Property(e => e.Unpaid).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserHolidayId).HasColumnName("UserHolidayID");
        });

        modelBuilder.Entity<Hrabsence>(entity =>
        {
            entity.ToTable("HRAbsence");

            entity.Property(e => e.HrabsenceId).HasColumnName("HRAbsenceID");

            entity.Property(e => e.AbsenceType)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId)
                .HasColumnName("CustomRouteID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Days).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Hours)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.LastPostedDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LastPostedHours)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.LineStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LineType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ResetRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrabsenceType>(entity =>
        {
            entity.ToTable("HRAbsenceType");

            entity.Property(e => e.HrabsenceTypeId).HasColumnName("HRAbsenceTypeID");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hraccident>(entity =>
        {
            entity.ToTable("HRAccident");

            entity.Property(e => e.HraccidentId).HasColumnName("HRAccidentID");

            entity.Property(e => e.AccidentTypeId).HasColumnName("AccidentTypeID");

            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.FollowUpActions)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.TimeOfAccident).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<HraccidentType>(entity =>
        {
            entity.ToTable("HRAccidentType");

            entity.Property(e => e.HraccidentTypeId).HasColumnName("HRAccidentTypeID");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.System).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hraddress>(entity =>
        {
            entity.ToTable("HRAddress");

            entity.Property(e => e.HraddressId).HasColumnName("HRAddressID");

            entity.Property(e => e.City)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.County)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

            entity.Property(e => e.Line1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Line2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Line3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Line4)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Mobile)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PostCode)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<HrbankAccount>(entity =>
        {
            entity.ToTable("HRBankAccount");

            entity.Property(e => e.HrbankAccountId).HasColumnName("HRBankAccountID");

            entity.Property(e => e.AccountName)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Mobile)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SortCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Hrcontact>(entity =>
        {
            entity.ToTable("HRContact");

            entity.Property(e => e.HrcontactId).HasColumnName("HRContactID");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Mobile)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Relationship)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Telephone)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Hrcourse>(entity =>
        {
            entity.ToTable("HRCourse");

            entity.Property(e => e.HrcourseId).HasColumnName("HRCourseID");

            entity.Property(e => e.CourseEndDate).HasColumnType("datetime");

            entity.Property(e => e.CourseStartDate).HasColumnType("datetime");

            entity.Property(e => e.CourseStatus)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CourseType)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CourseTypeId).HasColumnName("CourseTypeID");

            entity.Property(e => e.CreatorId).HasColumnName("CreatorID");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");

            entity.Property(e => e.ExpiredNotificationSent).HasDefaultValueSql("((0))");

            entity.Property(e => e.Expiresin1NotificationSent).HasDefaultValueSql("((0))");

            entity.Property(e => e.Expiresin3NotificationSent).HasDefaultValueSql("((0))");

            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.QualificationExpiryDate).HasColumnType("datetime");

            entity.Property(e => e.QualificationStartDate).HasColumnType("datetime");

            entity.Property(e => e.ReminderDate).HasColumnType("datetime");

            entity.Property(e => e.ReminderSent).HasDefaultValueSql("((0))");

            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<HrcourseType>(entity =>
        {
            entity.ToTable("HRCourseType");

            entity.Property(e => e.HrcourseTypeId).HasColumnName("HRCourseTypeID");

            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdisciplinaryCase>(entity =>
        {
            entity.ToTable("HRDisciplinaryCase");

            entity.Property(e => e.HrdisciplinaryCaseId).HasColumnName("HRDisciplinaryCaseID");

            entity.Property(e => e.CaseType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DateAdded).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

            entity.Property(e => e.InvestigatorId).HasColumnName("InvestigatorID");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<HrdisciplinaryCaseLine>(entity =>
        {
            entity.ToTable("HRDisciplinaryCaseLine");

            entity.Property(e => e.HrdisciplinaryCaseLineId).HasColumnName("HRDisciplinaryCaseLineID");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");

            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.HrdisciplinaryCaseId).HasColumnName("HRDisciplinaryCaseID");

            entity.Property(e => e.LineType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

            entity.Property(e => e.PeriodStart).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Hrdocument>(entity =>
        {
            entity.ToTable("HRDocument");

            entity.Property(e => e.HrdocumentId).HasColumnName("HRDocumentID");

            entity.Property(e => e.CreatorId).HasColumnName("CreatorID");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");

            entity.Property(e => e.DisplayEndDate)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DisplayStartDate).HasColumnType("datetime");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HradminsOnly).HasColumnName("HRAdminsOnly");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdocumentLog>(entity =>
        {
            entity.ToTable("HRDocumentLog");

            entity.Property(e => e.HrdocumentLogId).HasColumnName("HRDocumentLogID");

            entity.Property(e => e.DateEmailed).HasColumnType("datetime");

            entity.Property(e => e.DateNotificationAdded).HasColumnType("datetime");

            entity.Property(e => e.DateNotificationCleared).HasColumnType("datetime");

            entity.Property(e => e.DateReadConfirmed).HasColumnType("datetime");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HrdocumentId).HasColumnName("HRDocumentID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<HremployeeDetail>(entity =>
        {
            entity.ToTable("HREmployeeDetail");

            entity.Property(e => e.HremployeeDetailId).HasColumnName("HREmployeeDetailID");

            entity.Property(e => e.Aka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AKA");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.Property(e => e.DisabilityNotes)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.Dlexpiry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLExpiry");

            entity.Property(e => e.Dlnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DLNumber");

            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOB");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.EmployeeNumber)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Ethnicity)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HomePhoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.MedicalInfo)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.MobileNumber)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Ninumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NINumber");

            entity.Property(e => e.PreviousSurname)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Religion)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RtwdocumentsReceived).HasColumnName("RTWDocumentsReceived");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.VehicleRegNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HremployeeSalary>(entity =>
        {
            entity.ToTable("HREmployeeSalary");

            entity.Property(e => e.HremployeeSalaryId).HasColumnName("HREmployeeSalaryID");

            entity.Property(e => e.AmtCur).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.AmtHol).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.AmtTotal).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DefaultFactorMultiplier).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DefaultHrsNo).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DefaultRateAmt).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.FactorMultiplierCur).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.FactorMultiplierHol).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.HrsNoCur).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.HrsNoHol).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RateAmtCur).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RateAmtHol).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<HrjobRole>(entity =>
        {
            entity.ToTable("HRJobRole");

            entity.Property(e => e.HrjobRoleId).HasColumnName("HRJobRoleID");

            entity.Property(e => e.CompanyInductionDate).HasColumnType("datetime");

            entity.Property(e => e.ContractStartDate).HasColumnType("datetime");

            entity.Property(e => e.ContractType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ContractedHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DateFrom).HasColumnType("datetime");

            entity.Property(e => e.DateTo).HasColumnType("datetime");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.JobRoleId).HasColumnName("JobRoleID");

            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ManagerInductionDate).HasColumnType("datetime");

            entity.Property(e => e.Notes)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.NoticeDetails)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.NoticePeriod)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ProbationDueDate).HasColumnType("datetime");

            entity.Property(e => e.ProbationNotes)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.ProbationReviewDate).HasColumnType("datetime");

            entity.Property(e => e.RestrictiveCovenantComments)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.YearlySalary).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<HrjobRoleNominalOverride>(entity =>
        {
            entity.ToTable("HRJobRoleNominalOverride");

            entity.Property(e => e.HrjobRoleNominalOverrideId).HasColumnName("HRJobRoleNominalOverrideID");

            entity.Property(e => e.AccountNumberId).HasColumnName("AccountNumberID");

            entity.Property(e => e.CostCentreId).HasColumnName("CostCentreID");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.Property(e => e.HrjobRoleId).HasColumnName("HRJobRoleID");

            entity.Property(e => e.InvoiceLineType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrupdateLink>(entity =>
        {
            entity.ToTable("HRUpdateLink");

            entity.Property(e => e.HrupdateLinkId).HasColumnName("HRUpdateLinkID");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

            entity.Property(e => e.HrrecordId).HasColumnName("HRRecordID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Type)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.ToTable("Image");

            entity.Property(e => e.ImageId).HasColumnName("ImageID");

            entity.Property(e => e.FileExtension)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

            entity.Property(e => e.Type)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.ToTable("Invoice");

            entity.HasIndex(e => e.Deleted, "IX_Invoice_Deleted");

            entity.HasIndex(e => new { e.Deleted, e.SupplierId, e.InvoiceDate, e.InvoiceStatus, e.InvoiceExpense }, "IX_Invoice_Deleted_SupplierID_InvoiceDate_InvoiceStatus_InvoiceExpense");

            entity.HasIndex(e => new { e.SupplierId, e.Deleted, e.OnHold, e.InvoiceExpense }, "IX_Invoice_SupplierID_Deleted_OnHold_InvoiceExpense");

            entity.HasIndex(e => new { e.SageDatabaseId, e.PlpostedSupplierTranId, e.Deleted }, "Invoice_Service_PLPostedSupplierTran_Index");

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

            entity.Property(e => e.BusinessUnitId)
                .HasColumnName("BusinessUnitID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CheckForNewDocuments).HasDefaultValueSql("((0))");

            entity.Property(e => e.ConsIsConstructionInvoice).HasDefaultValueSql("((0))");

            entity.Property(e => e.ConsLabourPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConsLabourValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConsMaterialValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConsOtherValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConsRetentionMaterialsDefectsDueDate).HasColumnType("datetime");

            entity.Property(e => e.ConsRetentionMaterialsDefectsPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConsRetentionMaterialsPracticalDueDate).HasColumnType("datetime");

            entity.Property(e => e.ConsRetentionMaterialsPracticalPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConsRetentionWorksDefectsDueDate).HasColumnType("datetime");

            entity.Property(e => e.ConsRetentionWorksDefectsPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ConsRetentionWorksPracticalDueDate).HasColumnType("datetime");

            entity.Property(e => e.ConsRetentionWorksPracticalPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.EnteredById).HasColumnName("EnteredByID");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ForReview).HasDefaultValueSql("((0))");

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.GoodsValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.HasAnalysisValues).HasDefaultValueSql("((0))");

            entity.Property(e => e.HasAttachments).HasDefaultValueSql("((0))");

            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

            entity.Property(e => e.InvoiceDueDate).HasColumnType("datetime");

            entity.Property(e => e.InvoiceExpense)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceRecordedFromPo)
                .HasColumnName("InvoiceRecordedFromPO")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.InvoiceStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryCustom1).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom2).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom3).HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.Notes)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.OnHold).HasDefaultValueSql("((0))");

            entity.Property(e => e.OnHoldReason)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.PlpostedSupplierTranId).HasColumnName("PLPostedSupplierTranID");

            entity.Property(e => e.RecordedPoreceivedGoodsValue)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("RecordedPOReceivedGoodsValue");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageDatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SecondReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SentToSage).HasDefaultValueSql("((0))");

            entity.Property(e => e.SiconDmsaiinvoiceId)
                .HasColumnName("SiconDMSAIInvoiceID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.SupplierName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TaxValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Urn).HasColumnName("URN");
        });

        modelBuilder.Entity<InvoiceLine>(entity =>
        {
            entity.ToTable("InvoiceLine");

            entity.HasIndex(e => new { e.InvoiceId, e.CreditCardStatementId }, "IX_InvoiceLine_InvoiceID_CreditCardStatementID");

            entity.HasIndex(e => new { e.SageDatabaseId, e.NlnominalAccountId, e.InvoiceLineId }, "IX_InvoiceLine_SageDatabaseID_NLNominalAccountID_InvoiceLineID");

            entity.Property(e => e.InvoiceLineId).HasColumnName("InvoiceLineID");

            entity.Property(e => e.ConstructLineTypeId).HasColumnName("ConstructLineTypeID");

            entity.Property(e => e.ConstructVariationId).HasColumnName("ConstructVariationID");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CreditCardID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CreditCardStatementId)
                .HasColumnName("CreditCardStatementID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CreditCardStatementLineId)
                .HasColumnName("CreditCardStatementLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId)
                .HasColumnName("CustomRouteID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.DuplicateMatchReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.GoodsValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.HasAttachments).HasDefaultValueSql("((0))");

            entity.Property(e => e.InvoiceCredit)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

            entity.Property(e => e.InvoiceLineType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobRoleId)
                .HasColumnName("JobRoleID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.LineStatusId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LineStatusID");

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.Narrative).IsUnicode(false);

            entity.Property(e => e.NlnominalAccountId).HasColumnName("NLNominalAccountID");

            entity.Property(e => e.NlpostedNominalTranId).HasColumnName("NLPostedNominalTranID");

            entity.Property(e => e.ParentPlpostedSupplierTranId).HasColumnName("ParentPLPostedSupplierTranID");

            entity.Property(e => e.PayrollProcessReference)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.PostedDate).HasColumnType("datetime");

            entity.Property(e => e.ProjectCodeId).HasColumnName("ProjectCodeID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.ProjectPhaseId)
                .HasColumnName("ProjectPhaseID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ProjectStageId)
                .HasColumnName("ProjectStageID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ProjectSubStageId)
                .HasColumnName("ProjectSubStageID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ProjectVariationId)
                .HasColumnName("ProjectVariationID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SplitOriginatorId).HasColumnName("SplitOriginatorID");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SystaxRateId).HasColumnName("SYSTaxRateID");

            entity.Property(e => e.TaxValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TransactionAnalysisCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Urn).HasColumnName("URN");

            entity.Property(e => e.WaitingForApprovalType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WaitingForId).HasColumnName("WaitingForID");
        });

        modelBuilder.Entity<InvoiceMatchHistory>(entity =>
        {
            entity.ToTable("InvoiceMatchHistory");

            entity.Property(e => e.InvoiceMatchHistoryId).HasColumnName("InvoiceMatchHistoryID");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.InvoiceLineId)
                .HasColumnName("InvoiceLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.OrderLineId)
                .HasColumnName("OrderLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ReceiptLineId)
                .HasColumnName("ReceiptLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IpaddressLockout>(entity =>
        {
            entity.ToTable("IPAddressLockout");

            entity.Property(e => e.IpaddressLockoutId).HasColumnName("IPAddressLockoutID");

            entity.Property(e => e.Attempts).HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Ipaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IPAddress");

            entity.Property(e => e.LockoutDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobActivity>(entity =>
        {
            entity.ToTable("JobActivity");

            entity.HasIndex(e => new { e.UserId, e.EndDate, e.Module }, "IX_JobActivity_UserID_EndDate_Module");

            entity.HasIndex(e => new { e.UserId, e.Module, e.TimesheetLineId }, "IX_JobActivity_UserID_Module_TimesheetLineID");

            entity.Property(e => e.JobActivityId).HasColumnName("JobActivityID");

            entity.Property(e => e.DueDate).HasColumnType("datetime");

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.QuantityComplete).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Rework).HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SiOperationId).HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SiWorksOrderLineId)
                .HasColumnName("SiWorksOrderLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.Property(e => e.TimesheetLineId)
                .HasColumnName("TimesheetLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.WofinishedItemQuantity)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("WOFinishedItemQuantity");
        });

        modelBuilder.Entity<JobCostingCtc>(entity =>
        {
            entity.ToTable("JobCostingCTC");

            entity.Property(e => e.JobCostingCtcid).HasColumnName("JobCostingCTCID");

            entity.Property(e => e.CostCode)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CostToComplete).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.HoursToComplete).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PhaseId).HasColumnName("PhaseID");

            entity.Property(e => e.ProjectVariationId).HasColumnName("ProjectVariationID");

            entity.Property(e => e.ReasonForChange)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SiJccostToCompleteId).HasColumnName("SiJCCostToCompleteID");

            entity.Property(e => e.SijcjobId).HasColumnName("SIJCJobID");

            entity.Property(e => e.StageId).HasColumnName("StageID");

            entity.Property(e => e.SubStageId).HasColumnName("SubStageID");

            entity.Property(e => e.SysaccountingPeriodId).HasColumnName("SYSAccountingPeriodID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobCostingFieldValue>(entity =>
        {
            entity.ToTable("JobCostingFieldValue");

            entity.Property(e => e.JobCostingFieldValueId).HasColumnName("JobCostingFieldValueID");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.JobCostingJobId).HasColumnName("JobCostingJobID");

            entity.Property(e => e.PropertyName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobCostingJob>(entity =>
        {
            entity.ToTable("JobCostingJob");

            entity.Property(e => e.JobCostingJobId).HasColumnName("JobCostingJobID");

            entity.Property(e => e.ActualCompDate).HasColumnType("datetime");

            entity.Property(e => e.Analysis1)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.Analysis2)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.Analysis3)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Analysis4)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Analysis5)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Analysis6)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Analysis7)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerRefCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobNotes).IsUnicode(false);

            entity.Property(e => e.JobNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MarkupPercentage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PercentageComplete).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PlanCompDate).HasColumnType("datetime");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Sijcjobid).HasColumnName("SIJCJOBID");

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StockCoverPercent).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobCostingMemo>(entity =>
        {
            entity.ToTable("JobCostingMemo");

            entity.Property(e => e.JobCostingMemoId).HasColumnName("JobCostingMemoID");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Memocreatedby)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("MEMOCREATEDBY");

            entity.Property(e => e.Memocreateddate)
                .HasColumnType("datetime")
                .HasColumnName("MEMOCREATEDDATE");

            entity.Property(e => e.Memoid).HasColumnName("MEMOID");

            entity.Property(e => e.Memotext)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("MEMOTEXT");

            entity.Property(e => e.Memotype).HasColumnName("MEMOTYPE");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Sijcjobid).HasColumnName("SIJCJOBID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobRole>(entity =>
        {
            entity.ToTable("JobRole");

            entity.Property(e => e.JobRoleId).HasColumnName("JobRoleID");

            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JustificationValueBand>(entity =>
        {
            entity.ToTable("JustificationValueBand");

            entity.Property(e => e.JustificationValueBandId).HasColumnName("JustificationValueBandID");

            entity.Property(e => e.BandEnd).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BandStart).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveType>(entity =>
        {
            entity.ToTable("LeaveType");

            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

            entity.Property(e => e.Display).HasDefaultValueSql("((1))");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ShowOnLeaveCalendar).HasDefaultValueSql("((1))");

            entity.Property(e => e.System).HasDefaultValueSql("((0))");

            entity.Property(e => e.Toil)
                .HasColumnName("TOIL")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdateRecords).HasDefaultValueSql("((1))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.IsTouchScreen).HasDefaultValueSql("((1))");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoginRecord>(entity =>
        {
            entity.ToTable("LoginRecord");

            entity.HasIndex(e => new { e.LoginRecordLineId, e.Deleted }, "IX_LoginRecord_LoginRecordLineID_Deleted");

            entity.HasIndex(e => new { e.UserId, e.TimeOut, e.TimeIn }, "IX_LoginRecord_UserID_TimeOut_TimeIn");

            entity.Property(e => e.LoginRecordId).HasColumnName("LoginRecordID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Hours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.Property(e => e.LoginRecordLineId).HasColumnName("LoginRecordLineID");

            entity.Property(e => e.PayElement)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PayElementRef)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ReasonForLeavingId).HasColumnName("ReasonForLeavingID");

            entity.Property(e => e.TimeIn).HasColumnType("datetime");

            entity.Property(e => e.TimeOut).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<LoginRecordLine>(entity =>
        {
            entity.ToTable("LoginRecordLine");

            entity.HasIndex(e => new { e.TimesheetId, e.Deleted }, "IX_LoginRecordLine_TimesheetID_Deleted");

            entity.Property(e => e.LoginRecordLineId).HasColumnName("LoginRecordLineID");

            entity.Property(e => e.BankHolidayId)
                .HasColumnName("BankHolidayID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.HolidayRequestLineId)
                .HasColumnName("HolidayRequestLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.HrabsenceId)
                .HasColumnName("HRAbsenceID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.MandatoryHolidayId)
                .HasColumnName("MandatoryHolidayID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Notes)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WorkPatternPayRateId).HasColumnName("WorkPatternPayRateID");
        });

        modelBuilder.Entity<LostSalesOrderLine>(entity =>
        {
            entity.ToTable("LostSalesOrderLine");

            entity.Property(e => e.LostSalesOrderLineId).HasColumnName("LostSalesOrderLineID");

            entity.Property(e => e.AdditionalInformation).IsUnicode(false);

            entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Reason).IsUnicode(false);

            entity.Property(e => e.RequestingUser)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SalesOrderLineId).HasColumnName("SalesOrderLineID");

            entity.Property(e => e.SellPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<MandatoryHoliday>(entity =>
        {
            entity.ToTable("MandatoryHoliday");

            entity.Property(e => e.MandatoryHolidayId).HasColumnName("MandatoryHolidayID");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.Days).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MeetingRequest>(entity =>
        {
            entity.ToTable("MeetingRequest");

            entity.Property(e => e.MeetingRequestId).HasColumnName("MeetingRequestID");

            entity.Property(e => e.Body).IsUnicode(false);

            entity.Property(e => e.Cancelled).HasDefaultValueSql("((0))");

            entity.Property(e => e.DateSent).HasColumnType("datetime");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Recipient)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Uid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Mileage>(entity =>
        {
            entity.ToTable("Mileage");

            entity.Property(e => e.MileageId).HasColumnName("MileageID");

            entity.Property(e => e.BusinessMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BusinessMileageAdjustment).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BusinessMileageAdjustmentReason).IsUnicode(false);

            entity.Property(e => e.CategoryComponentId).HasColumnName("CategoryComponentID");

            entity.Property(e => e.EndMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.FuelRateHistoryId).HasColumnName("FuelRateHistoryID");

            entity.Property(e => e.FuelRateId).HasColumnName("FuelRateID");

            entity.Property(e => e.InvoiceLineId).HasColumnName("InvoiceLineID");

            entity.Property(e => e.JourneyDetails).IsUnicode(false);

            entity.Property(e => e.JourneyWaypoints)
                .HasMaxLength(5000)
                .IsUnicode(false);

            entity.Property(e => e.MileageDate).HasColumnType("datetime");

            entity.Property(e => e.ParentCategoryComponentId).HasColumnName("ParentCategoryComponentID");

            entity.Property(e => e.PassengerPencePerMile).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PencePerMile).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PersonalMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ReceiptAttached)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StartMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SysfinancialYearId).HasColumnName("SYSFinancialYearID");

            entity.Property(e => e.TotalMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserCurrentMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

            entity.Property(e => e.VehicleRegistration)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NextNumber>(entity =>
        {
            entity.ToTable("NextNumber");

            entity.Property(e => e.NextNumberId).HasColumnName("NextNumberID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NA')");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NominalAccountDescription>(entity =>
        {
            entity.ToTable("NominalAccountDescription");

            entity.Property(e => e.NominalAccountDescriptionId).HasColumnName("NominalAccountDescriptionID");

            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.NominalAccountId).HasColumnName("NominalAccountID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification");

            entity.HasIndex(e => new { e.NotificationTypeId, e.ForeignParentKey, e.DocumentType }, "IX_Notification_NotificationTypeID_ForeignParentKey_DocumentType");

            entity.HasIndex(e => new { e.NotifyRead, e.UserId, e.NotifyTime }, "IX_Notification_NotifyRead_UserID_NotifyTime");

            entity.HasIndex(e => new { e.NotificationTypeId, e.ForeignKey, e.DocumentType }, "NotificationDocumentType_IDX");

            entity.HasIndex(e => new { e.NotifyRead, e.EmailSent }, "Notification_Service_Index");

            entity.HasIndex(e => new { e.NotificationTypeId, e.ForeignKey, e.DocumentType }, "Notification_Type_ForeignKey_DocumentTypeIndex");

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Message)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

            entity.Property(e => e.NotifyTime).HasColumnType("datetime");

            entity.Property(e => e.OutOfOfficeOriginalApproverId)
                .HasColumnName("OutOfOfficeOriginalApproverID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.PriorityId).HasColumnName("PriorityID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<NotificationOption>(entity =>
        {
            entity.ToTable("NotificationOption");

            entity.Property(e => e.NotificationOptionId).HasColumnName("NotificationOptionID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NotificationOptionType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order");

            entity.HasIndex(e => new { e.Deleted, e.SupplierId, e.OrderDate }, "IX_Order_Deleted_SupplierID_OrderDate");

            entity.HasIndex(e => new { e.Archived, e.SageDatabaseId, e.UpdateStatus, e.Deleted, e.OrderId, e.InternalOrder, e.OrderStatus }, "Order_Existing_Orders_Index");

            entity.HasIndex(e => new { e.InternalOrder, e.Archived, e.SageDatabaseId, e.UpdateStatus, e.Deleted, e.SupplierId, e.PodocumentNo, e.OrderStatus, e.OrderId }, "Order_Service_Index");

            entity.HasIndex(e => new { e.SageDatabaseId, e.UpdateStatus, e.SentToSage, e.Deleted, e.Cancelled, e.SageOrderId }, "Order_Service_Update_Index");

            entity.HasIndex(e => new { e.SageDatabaseId, e.Deleted, e.SageOrderId, e.OrderId }, "Order_SingleOrder_Index");
            
            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.AdditionalReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Analysis1)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis10)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis11)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis12)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis13)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis14)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis15)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis16)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis17)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis18)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis19)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis2)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis20)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis3)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis4)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis5)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis6)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis7)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis8)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis9)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.CallOff).HasDefaultValueSql("((0))");

            entity.Property(e => e.CheckForNewDocuments).HasDefaultValueSql("((0))");

            entity.Property(e => e.Confidential).HasDefaultValueSql("((0))");

            entity.Property(e => e.CurrencySymbol)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DefaultProjectId).HasColumnName("DefaultProjectID");

            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");

            entity.Property(e => e.DeliveryAddressLine1)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine2)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine3)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine4)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryContactName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

            entity.Property(e => e.DeliveryFaxNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryPostCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryPostalName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryTelephoneNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.Property(e => e.DocumentNoPrefix)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EmailSent).HasDefaultValueSql("((0))");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.HasAnalysisValues).HasDefaultValueSql("((0))");

            entity.Property(e => e.HasAttachments).HasDefaultValueSql("((0))");

            entity.Property(e => e.Hyperlink)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.InternalOrder).HasDefaultValueSql("((0))");

            entity.Property(e => e.InvoiceAddressId).HasColumnName("InvoiceAddressID");

            entity.Property(e => e.InvoiceAddressLine1)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine2)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine3)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine4)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceCity)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceContactName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceCounty)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceFaxNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoicePostCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoicePostalName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceTelephoneNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryCustom1).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom2).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom3).HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.Mrporder).HasColumnName("MRPOrder");

            entity.Property(e => e.NetValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OrderDate).HasColumnType("datetime");

            entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OrderStatus)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.OutOfHours).HasDefaultValueSql("((0))");

            entity.Property(e => e.PodocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PODocumentNo");

            entity.Property(e => e.ProjectRequisitionId).HasColumnName("ProjectRequisitionID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RequestedFor)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageDatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageOrderId).HasColumnName("SageOrderID");

            entity.Property(e => e.SpareDate1).HasColumnType("datetime");

            entity.Property(e => e.SpareDate2).HasColumnType("datetime");

            entity.Property(e => e.SpareDate3).HasColumnType("datetime");

            entity.Property(e => e.SpareNumber1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareNumber2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareNumber3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareText1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpareText2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpareText3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Special).IsUnicode(false);

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.SupplierContactName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierEmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierFax)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.SupplierName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SupplierTelephone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SystraderAnalysisValueId).HasColumnName("SYSTraderAnalysisValueID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<OrderJustification>(entity =>
        {
            entity.ToTable("OrderJustification");

            entity.Property(e => e.OrderJustificationId).HasColumnName("OrderJustificationID");

            entity.Property(e => e.Notes).IsUnicode(false);

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.PreferredNotes).IsUnicode(false);

            entity.Property(e => e.QuotedPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierDescription).IsUnicode(false);

            entity.Property(e => e.SyscurrencyId).HasColumnName("SYSCurrencyID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderLine>(entity =>
        {
            entity.ToTable("OrderLine");

            entity.HasIndex(e => e.Deleted, "IX_OrderLine_Deleted");

            entity.HasIndex(e => e.SageOrderLineId, "OrderLine_Existing_Index");

            entity.HasIndex(e => new { e.OrderId, e.Deleted }, "OrderLine_OrderID_Deleted_Index");

            entity.HasIndex(e => e.Deleted, "Orderline_Deleted_Index");

            entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

            entity.Property(e => e.AccountNumberId).HasColumnName("AccountNumberID");

            entity.Property(e => e.AmendedDescription).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendedDescriptionText)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Analysis1)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis10)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis11)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis12)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis13)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis14)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis15)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis16)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis17)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis18)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis19)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis2)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis20)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis3)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis4)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis5)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis6)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis7)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis8)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis9)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.BuyingMultOfStockUnit)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.BuyingUnitDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ConstructLineTypeId).HasColumnName("ConstructLineTypeID");

            entity.Property(e => e.ConstructVariationId).HasColumnName("ConstructVariationID");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");

            entity.Property(e => e.ContractItemId).HasColumnName("ContractItemID");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId)
                .HasColumnName("CustomRouteID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.IdentificationNumber)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LineNumber).HasDefaultValueSql("((0))");

            entity.Property(e => e.LineStatus)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LineStatusId).HasColumnName("LineStatusID");

            entity.Property(e => e.LineType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lineType");

            entity.Property(e => e.MatchedExpenseLinesNetValue)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.PccostItemId).HasColumnName("PCCostItemID");

            entity.Property(e => e.PlannedPurchaseId).HasColumnName("PlannedPurchaseID");

            entity.Property(e => e.PostedCostingDetailId)
                .HasColumnName("PostedCostingDetailID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.PricingMultOfStockUnit)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.PricingUnitDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ProjectCodeId).HasColumnName("ProjectCodeID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.ProjectPhaseId).HasColumnName("ProjectPhaseID");

            entity.Property(e => e.ProjectRequisitionLineId).HasColumnName("ProjectRequisitionLineID");

            entity.Property(e => e.ProjectStageId).HasColumnName("ProjectStageID");

            entity.Property(e => e.ProjectSubStageId).HasColumnName("ProjectSubStageID");

            entity.Property(e => e.ProjectVariationId).HasColumnName("ProjectVariationID");

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.QuantityInvoiced)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.QuantityReceived).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RejectReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageOrderLineId).HasColumnName("SageOrderLineID");

            entity.Property(e => e.SentToSageValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ShowCommentOnSupplierDocs).HasDefaultValueSql("((1))");

            entity.Property(e => e.SpareDate1).HasColumnType("datetime");

            entity.Property(e => e.SpareDate2).HasColumnType("datetime");

            entity.Property(e => e.SpareDate3).HasColumnType("datetime");

            entity.Property(e => e.SpareNumber1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareNumber2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareNumber3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareText1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpareText2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpareText3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SupplierPartNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WaitingForApprovalType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WaitingForId).HasColumnName("WaitingForID");

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<OrderTemplate>(entity =>
        {
            entity.ToTable("OrderTemplate");

            entity.Property(e => e.OrderTemplateId).HasColumnName("OrderTemplateID");

            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

            entity.Property(e => e.CreatedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DefaultWarehouseId).HasColumnName("DefaultWarehouseID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageDatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.TemplateDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderTemplateLine>(entity =>
        {
            entity.ToTable("OrderTemplateLine");

            entity.Property(e => e.OrderTemplateLineId).HasColumnName("OrderTemplateLineID");

            entity.Property(e => e.BuyingUnitDescription)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.LineType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NominalAccountId).HasColumnName("NominalAccountID");

            entity.Property(e => e.OrderTemplateId).HasColumnName("OrderTemplateID");

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StockItemCode)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.SupplierName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierPartNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SupplierReference)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.Property(e => e.WarehouseName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OutOfOffice>(entity =>
        {
            entity.ToTable("OutOfOffice");

            entity.Property(e => e.OutOfOfficeId).HasColumnName("OutOfOfficeID");

            entity.Property(e => e.AlternateUserId).HasColumnName("AlternateUserID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Pctran>(entity =>
        {
            entity.HasKey(e => e.PctransId);

            entity.ToTable("PCTrans");

            entity.Property(e => e.PctransId).HasColumnName("PCTransID");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId)
                .HasColumnName("CustomRouteID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.Hours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LineStatusId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LineStatusID");

            entity.Property(e => e.Narrative).IsUnicode(false);

            entity.Property(e => e.PcprojectId).HasColumnName("PCProjectID");

            entity.Property(e => e.PcprojectItemId).HasColumnName("PCProjectItemID");

            entity.Property(e => e.RecordType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.TimesheetDefaultId).HasColumnName("TimesheetDefaultID");

            entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

            entity.Property(e => e.TransType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.Property(e => e.TschargeRateId).HasColumnName("TSChargeRateID");

            entity.Property(e => e.TscostRateId).HasColumnName("TSCostRateID");

            entity.Property(e => e.TspayRateId)
                .HasColumnName("TSPayRateID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.TspersonId).HasColumnName("TSPersonID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WaitingForId).HasColumnName("WaitingForID");

            entity.Property(e => e.WaitingForType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProjectRequisition>(entity =>
        {
            entity.ToTable("ProjectRequisition");

            entity.Property(e => e.ProjectRequisitionId).HasColumnName("ProjectRequisitionID");

            entity.Property(e => e.Analysis1)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis10)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis11)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis12)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis13)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis14)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis15)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis16)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis17)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis18)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis19)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis2)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis20)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis3)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis4)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis5)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis6)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis7)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis8)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis9)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ApprovalComments)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.DefaultNominalAccountId).HasColumnName("DefaultNominalAccountID");

            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");

            entity.Property(e => e.DeliveryAddressLine1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine4)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryContactName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryFaxNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryPostCode)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryPostalName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryTelephoneNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.Property(e => e.DocumentDate).HasColumnType("datetime");

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.InvoiceAddressId).HasColumnName("InvoiceAddressID");

            entity.Property(e => e.InvoiceAddressLine1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine4)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceContactName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceFaxNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoicePostCode)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoicePostalName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceTelephoneNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Notes).IsUnicode(false);

            entity.Property(e => e.OnHold).HasDefaultValueSql("((0))");

            entity.Property(e => e.OnHoldReason)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageDatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProjectRequisitionLine>(entity =>
        {
            entity.ToTable("ProjectRequisitionLine");

            entity.Property(e => e.ProjectRequisitionLineId).HasColumnName("ProjectRequisitionLineID");

            entity.Property(e => e.AccountNumberId).HasColumnName("AccountNumberID");

            entity.Property(e => e.AmendedDescription).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendedDescriptionText)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Analysis1)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis10)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis11)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis12)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis13)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis14)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis15)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis16)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis17)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis18)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis19)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis2)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis20)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis3)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis4)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis5)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis6)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis7)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis8)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis9)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.BuyingMultOfStockUnit).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BuyingUnitDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ItemCode)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LineStatus)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LineStatusId)
                .HasColumnName("LineStatusID")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.LineType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Note).IsUnicode(false);

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

            entity.Property(e => e.PlannedPurchaseId).HasColumnName("PlannedPurchaseID");

            entity.Property(e => e.PricingMultOfStockUnit).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PricingUnitDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Process).HasDefaultValueSql("((0))");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.ProjectPhaseId).HasColumnName("ProjectPhaseID");

            entity.Property(e => e.ProjectRequisitionId).HasColumnName("ProjectRequisitionID");

            entity.Property(e => e.ProjectStageId).HasColumnName("ProjectStageID");

            entity.Property(e => e.ProjectSubStageId).HasColumnName("ProjectSubStageID");

            entity.Property(e => e.ProjectVariationId).HasColumnName("ProjectVariationID");

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RejectReason)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.SupplierPartNo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<ProposedPayment>(entity =>
        {
            entity.ToTable("ProposedPayment");

            entity.HasIndex(e => new { e.PlproposedPaymentId, e.SageDatabaseId }, "IX_ProposedPayment_PLProposedPaymentID_SageDatabaseID");

            entity.Property(e => e.ProposedPaymentId).HasColumnName("ProposedPaymentID");

            entity.Property(e => e.BankChequeDiscountValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BankChequeValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DateTimeCreated).HasColumnType("datetime");

            entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");

            entity.Property(e => e.DocumentDate).HasColumnType("datetime");

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.PlproposedPaymentId).HasColumnName("PLProposedPaymentID");

            entity.Property(e => e.PlsupplierAccountId).HasColumnName("PLSupplierAccountID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.SupplierName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProposedPaymentLine>(entity =>
        {
            entity.ToTable("ProposedPaymentLine");

            entity.HasIndex(e => e.Deleted, "IX_ProposedPaymentLine_Deleted");

            entity.HasIndex(e => e.PlproposedPaymentPostedTranId, "IX_ProposedPaymentLine_PLProposedPaymentPostedTranID");

            entity.Property(e => e.ProposedPaymentLineId).HasColumnName("ProposedPaymentLineID");

            entity.Property(e => e.AuthoriseStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.DateTimeCreated).HasColumnType("datetime");

            entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");

            entity.Property(e => e.DiscountToClaimValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DueDate).HasColumnType("datetime");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

            entity.Property(e => e.PlpostedSupplierTranId).HasColumnName("PLPostedSupplierTranID");

            entity.Property(e => e.PlproposedPaymentId).HasColumnName("PLProposedPaymentID");

            entity.Property(e => e.PlproposedPaymentPostedTranId).HasColumnName("PLProposedPaymentPostedTranID");

            entity.Property(e => e.ProposedPaymentId).HasColumnName("ProposedPaymentID");

            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.ToPayValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TransDate).HasColumnType("datetime");

            entity.Property(e => e.TransType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Value).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ValueBandId).HasColumnName("ValueBandID");

            entity.Property(e => e.Vatdiscount)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("VATDiscount");
        });

        modelBuilder.Entity<PushNotificationToken>(entity =>
        {
            entity.ToTable("PushNotificationToken");

            entity.Property(e => e.PushNotificationTokenId).HasColumnName("PushNotificationTokenID");

            entity.Property(e => e.DeviceType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LastUsedDate).HasColumnType("datetime");

            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ReasonForLeaving>(entity =>
        {
            entity.ToTable("ReasonForLeaving");

            entity.Property(e => e.ReasonForLeavingId).HasColumnName("ReasonForLeavingID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.ToTable("Receipt");

            entity.HasIndex(e => new { e.Deleted, e.SageDatabaseId, e.UpdateStatus }, "Receipt_Service_Update_Index");

            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

            entity.Property(e => e.Grnnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRNNumber");

            entity.Property(e => e.HasAttachments).HasDefaultValueSql("((0))");

            entity.Property(e => e.Narrative)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierAccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SupplierDocumentDate).HasColumnType("datetime");

            entity.Property(e => e.SupplierDocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ReceiptBatchSerial>(entity =>
        {
            entity.ToTable("ReceiptBatchSerial");

            entity.Property(e => e.ReceiptBatchSerialId).HasColumnName("ReceiptBatchSerialID");

            entity.Property(e => e.AlternativeRef)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BatchSerialNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Grnnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRNNumber");

            entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

            entity.Property(e => e.PoporderReturnLineId).HasColumnName("POPOrderReturnLineID");

            entity.Property(e => e.PopreceiptReturnLineId).HasColumnName("POPReceiptReturnLineID");

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.QuantityDelivered).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ReceiptLineId).HasColumnName("ReceiptLineID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SellBy).HasColumnType("datetime");

            entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

            entity.Property(e => e.TraceableItemId).HasColumnName("TraceableItemID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UseBy).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReceiptBatchSerialAttribute>(entity =>
        {
            entity.ToTable("ReceiptBatchSerialAttribute");

            entity.Property(e => e.ReceiptBatchSerialAttributeId).HasColumnName("ReceiptBatchSerialAttributeID");

            entity.Property(e => e.ProductGroupBatchAttributeId).HasColumnName("ProductGroupBatchAttributeID");

            entity.Property(e => e.ReceiptBatchSerialId).HasColumnName("ReceiptBatchSerialID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ValueText)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReceiptLine>(entity =>
        {
            entity.ToTable("ReceiptLine");

            entity.HasIndex(e => e.OrderLineId, "ReceiptLine_OrderLine_Index");

            entity.HasIndex(e => new { e.ReceiptId, e.Deleted }, "ReceiptLine_ReceiptID_Deleted_Index");

            entity.Property(e => e.ReceiptLineId).HasColumnName("ReceiptLineID");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

            entity.Property(e => e.PoporderReturnLineId).HasColumnName("POPOrderReturnLineID");

            entity.Property(e => e.PopreceiptReturnLineId).HasColumnName("POPReceiptReturnLineID");

            entity.Property(e => e.QuantityInvoiced)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.QuantityReceived).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.Property(e => e.WarehouseName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RequestForQuote>(entity =>
        {
            entity.ToTable("RequestForQuote");

            entity.Property(e => e.RequestForQuoteId).HasColumnName("RequestForQuoteID");

            entity.Property(e => e.EmailDate).HasColumnType("datetime");

            entity.Property(e => e.LineDescription).IsUnicode(false);

            entity.Property(e => e.Notes).IsUnicode(false);

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.PrlineId).HasColumnName("PRLineID");

            entity.Property(e => e.Reference)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierAccountName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.SupplierContactName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.SupplierEmail)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ResetCode>(entity =>
        {
            entity.ToTable("ResetCode");

            entity.Property(e => e.ResetCodeId).HasColumnName("ResetCodeID");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<RestrictedNominal>(entity =>
        {
            entity.ToTable("RestrictedNominal");

            entity.Property(e => e.RestrictedNominalId).HasColumnName("RestrictedNominalID");

            entity.Property(e => e.NominalId).HasColumnName("NominalID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50AccountNumber>(entity =>
        {
            entity.ToTable("Sage50AccountNumber");

            entity.HasIndex(e => new { e.AccountRef, e.SageDatabaseId }, "IX_Sage50AccountNumber_ACCOUNT_REF_SageDatabaseID");

            entity.Property(e => e.Sage50AccountNumberId).HasColumnName("Sage50AccountNumberID");

            entity.Property(e => e.AccountRef)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_REF");

            entity.Property(e => e.AccountType).HasColumnName("ACCOUNT_TYPE");

            entity.Property(e => e.BalanceBf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_BF")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceFuture)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_FUTURE")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH1")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth10)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH10")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth11)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH11")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth12)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH12")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH2")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH3")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth4)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH4")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth5)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH5")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth6)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH6")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth7)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH7")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth8)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH8")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BalanceMth9)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE_MTH9")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH1")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth10)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH10")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth11)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH11")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth12)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH12")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH2")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH3")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth4)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH4")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth5)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH5")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth6)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH6")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth7)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH7")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth8)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH8")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.BudgetMth9)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BUDGET_MTH9")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditBf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_BF")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditFuture)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_FUTURE")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH1")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth10)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH10")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth11)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH11")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth12)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH12")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH2")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH3")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth4)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH4")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth5)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH5")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth6)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH6")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth7)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH7")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth8)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH8")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CreditMth9)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH9")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitBf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_BF")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitFuture)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_FUTURE")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH1")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth10)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH10")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth11)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH11")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth12)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH12")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH2")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH3")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth4)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH4")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth5)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH5")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth6)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH6")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth7)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH7")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth8)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH8")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DebitMth9)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DEBIT_MTH9")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50Currency>(entity =>
        {
            entity.ToTable("Sage50Currency");

            entity.Property(e => e.Sage50CurrencyId).HasColumnName("Sage50CurrencyID");

            entity.Property(e => e.BaseCurrency).HasColumnName("BASE_CURRENCY");

            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CODE");

            entity.Property(e => e.EmuMember).HasColumnName("EMU_MEMBER");

            entity.Property(e => e.MajorCurrencyUnit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAJOR_CURRENCY_UNIT");

            entity.Property(e => e.MinorCurrencyUnit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MINOR_CURRENCY_UNIT");

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.Number).HasColumnName("NUMBER");

            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("RATE");

            entity.Property(e => e.RecordDeleted).HasColumnName("RECORD_DELETED");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Symbol)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SYMBOL");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50Department>(entity =>
        {
            entity.ToTable("Sage50Department");

            entity.Property(e => e.Sage50DepartmentId).HasColumnName("Sage50DepartmentID");

            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.Number).HasColumnName("NUMBER");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50NominalLedger>(entity =>
        {
            entity.ToTable("Sage50NominalLedger");

            entity.Property(e => e.Sage50NominalLedgerId).HasColumnName("Sage50NominalLedgerID");

            entity.Property(e => e.AccountRef)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_REF");

            entity.Property(e => e.AccountType).HasColumnName("ACCOUNT_TYPE");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT_NAME");

            entity.Property(e => e.DepartmentNumber).HasColumnName("DEPARTMENT_NUMBER");

            entity.Property(e => e.DepartmentReference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT_REFERENCE");

            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50Project>(entity =>
        {
            entity.ToTable("Sage50Project");

            entity.Property(e => e.Sage50ProjectId).HasColumnName("Sage50ProjectID");

            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_1");

            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_2");

            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_3");

            entity.Property(e => e.Address4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_4");

            entity.Property(e => e.Address5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_5");

            entity.Property(e => e.Analysis1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANALYSIS_1");

            entity.Property(e => e.Analysis2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANALYSIS_2");

            entity.Property(e => e.Analysis3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANALYSIS_3");

            entity.Property(e => e.BilledNet)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BILLED_NET");

            entity.Property(e => e.BilledTax)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BILLED_TAX");

            entity.Property(e => e.ChildPosition)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CHILD_POSITION");

            entity.Property(e => e.CommittedCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("COMMITTED_COST");

            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NAME");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE");

            entity.Property(e => e.CustomerRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_REF");

            entity.Property(e => e.Description)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");

            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_MAIL");

            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");

            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAX");

            entity.Property(e => e.LastBilledDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_BILLED_DATE");

            entity.Property(e => e.LastCostDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_COST_DATE");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_NUMBER");

            entity.Property(e => e.OutstandingToBill)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("OUTSTANDING_TO_BILL");

            entity.Property(e => e.ParentProjectNo)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PARENT_PROJECT_NO");

            entity.Property(e => e.PriceQuoted)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PRICE_QUOTED");

            entity.Property(e => e.ProfitToDate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PROFIT_TO_DATE");

            entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");

            entity.Property(e => e.RecordCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_CREATE_DATE");

            entity.Property(e => e.RecordDeleted).HasColumnName("RECORD_DELETED");

            entity.Property(e => e.RecordModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_MODIFY_DATE");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");

            entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEPHONE");

            entity.Property(e => e.TotalBilled)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("TOTAL_BILLED");

            entity.Property(e => e.TotalBudget)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("TOTAL_BUDGET");

            entity.Property(e => e.TotalCost)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("TOTAL_COST");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Variance)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("VARIANCE");
        });

        modelBuilder.Entity<Sage50ProjectCostCode>(entity =>
        {
            entity.ToTable("Sage50ProjectCostCode");

            entity.Property(e => e.Sage50ProjectCostCodeId).HasColumnName("Sage50ProjectCostCodeID");

            entity.Property(e => e.CostCodeId).HasColumnName("COST_CODE_ID");

            entity.Property(e => e.CostTypeId).HasColumnName("COST_TYPE_ID");

            entity.Property(e => e.Description)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");

            entity.Property(e => e.RecordCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_CREATE_DATE");

            entity.Property(e => e.RecordDeleted).HasColumnName("RECORD_DELETED");

            entity.Property(e => e.RecordModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_MODIFY_DATE");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50ProjectCostType>(entity =>
        {
            entity.ToTable("Sage50ProjectCostType");

            entity.Property(e => e.Sage50ProjectCostTypeId).HasColumnName("Sage50ProjectCostTypeID");

            entity.Property(e => e.CostTypeId).HasColumnName("COST_TYPE_ID");

            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.RecordCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_CREATE_DATE");

            entity.Property(e => e.RecordDeleted).HasColumnName("RECORD_DELETED");

            entity.Property(e => e.RecordModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_MODIFY_DATE");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50ProjectResource>(entity =>
        {
            entity.ToTable("Sage50ProjectResource");

            entity.Property(e => e.Sage50ProjectResourceId).HasColumnName("Sage50ProjectResourceID");

            entity.Property(e => e.DefaultCostCodeId).HasColumnName("DEFAULT_COST_CODE_ID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("RATE");

            entity.Property(e => e.RecordCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_CREATE_DATE");

            entity.Property(e => e.RecordDeleted).HasColumnName("RECORD_DELETED");

            entity.Property(e => e.RecordModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_MODIFY_DATE");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE");

            entity.Property(e => e.ResourceId).HasColumnName("RESOURCE_ID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50ProjectStatus>(entity =>
        {
            entity.ToTable("Sage50ProjectStatus");

            entity.Property(e => e.Sage50ProjectStatusId).HasColumnName("Sage50ProjectStatusID");

            entity.Property(e => e.AllowDelete).HasColumnName("ALLOW_DELETE");

            entity.Property(e => e.AllowPosting).HasColumnName("ALLOW_POSTING");

            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.RecordCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_CREATE_DATE");

            entity.Property(e => e.RecordDeleted).HasColumnName("RECORD_DELETED");

            entity.Property(e => e.RecordModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_MODIFY_DATE");

            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sage50PurchaseLedger>(entity =>
        {
            entity.ToTable("Sage50PurchaseLedger");

            entity.Property(e => e.Sage50PurchaseLedgerId).HasColumnName("Sage50PurchaseLedgerID");

            entity.Property(e => e.AccountOnHold).HasColumnName("ACCOUNT_ON_HOLD");

            entity.Property(e => e.AccountRef)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_REF");

            entity.Property(e => e.Address1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_1");

            entity.Property(e => e.Address2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_2");

            entity.Property(e => e.Address3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_3");

            entity.Property(e => e.Address4)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_4");

            entity.Property(e => e.Address5)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_5");

            entity.Property(e => e.Analysis1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ANALYSIS_1");

            entity.Property(e => e.Analysis2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ANALYSIS_2");

            entity.Property(e => e.Analysis3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ANALYSIS_3");

            entity.Property(e => e.BacsRef)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BACS_REF");

            entity.Property(e => e.Balance)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BALANCE");

            entity.Property(e => e.BankAccountName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCOUNT_NAME");

            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ACCOUNT_NUMBER");

            entity.Property(e => e.BankAdditionalref1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ADDITIONALREF1");

            entity.Property(e => e.BankAdditionalref2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ADDITIONALREF2");

            entity.Property(e => e.BankAdditionalref3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ADDITIONALREF3");

            entity.Property(e => e.BankAddress1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ADDRESS_1");

            entity.Property(e => e.BankAddress2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ADDRESS_2");

            entity.Property(e => e.BankAddress3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ADDRESS_3");

            entity.Property(e => e.BankAddress4)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ADDRESS_4");

            entity.Property(e => e.BankAddress5)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ADDRESS_5");

            entity.Property(e => e.BankBic)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_BIC");

            entity.Property(e => e.BankIban)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_IBAN");

            entity.Property(e => e.BankName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_NAME");

            entity.Property(e => e.BankRollnumber)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BANK_ROLLNUMBER");

            entity.Property(e => e.BankSortCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BANK_SORT_CODE");

            entity.Property(e => e.BureauCode).HasColumnName("BUREAU_CODE");

            entity.Property(e => e.CAddress1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("C_ADDRESS_1");

            entity.Property(e => e.CAddress2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("C_ADDRESS_2");

            entity.Property(e => e.CAddress3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("C_ADDRESS_3");

            entity.Property(e => e.CAddress4)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("C_ADDRESS_4");

            entity.Property(e => e.CAddress5)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("C_ADDRESS_5");

            entity.Property(e => e.ContactName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NAME");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE");

            entity.Property(e => e.CreditBf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_BF");

            entity.Property(e => e.CreditCf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_CF");

            entity.Property(e => e.CreditLimit)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_LIMIT");

            entity.Property(e => e.CreditMth1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH1");

            entity.Property(e => e.CreditMth10)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH10");

            entity.Property(e => e.CreditMth11)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH11");

            entity.Property(e => e.CreditMth12)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH12");

            entity.Property(e => e.CreditMth2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH2");

            entity.Property(e => e.CreditMth3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH3");

            entity.Property(e => e.CreditMth4)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH4");

            entity.Property(e => e.CreditMth5)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH5");

            entity.Property(e => e.CreditMth6)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH6");

            entity.Property(e => e.CreditMth7)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH7");

            entity.Property(e => e.CreditMth8)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH8");

            entity.Property(e => e.CreditMth9)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("CREDIT_MTH9");

            entity.Property(e => e.CreditPosCode).HasColumnName("CREDIT_POS_CODE");

            entity.Property(e => e.CreditPosition)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("CREDIT_POSITION");

            entity.Property(e => e.CreditRef)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CREDIT_REF");

            entity.Property(e => e.Currency).HasColumnName("CURRENCY");

            entity.Property(e => e.DateAccountOpened)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ACCOUNT_OPENED");

            entity.Property(e => e.DateCreditApplied)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREDIT_APPLIED");

            entity.Property(e => e.DateCreditReceived)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREDIT_RECEIVED");

            entity.Property(e => e.DateLastCredit)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LAST_CREDIT");

            entity.Property(e => e.DateNextCredit)
                .HasColumnType("datetime")
                .HasColumnName("DATE_NEXT_CREDIT");

            entity.Property(e => e.DefNomCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DEF_NOM_CODE");

            entity.Property(e => e.DefTaxCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DEF_TAX_CODE");

            entity.Property(e => e.DefaultFundId).HasColumnName("DEFAULT_FUND_ID");

            entity.Property(e => e.DelAddress1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEL_ADDRESS_1");

            entity.Property(e => e.DelAddress2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEL_ADDRESS_2");

            entity.Property(e => e.DelAddress3)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEL_ADDRESS_3");

            entity.Property(e => e.DelAddress4)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEL_ADDRESS_4");

            entity.Property(e => e.DelAddress5)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEL_ADDRESS_5");

            entity.Property(e => e.DelContactName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEL_CONTACT_NAME");

            entity.Property(e => e.DelFax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEL_FAX");

            entity.Property(e => e.DelName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEL_NAME");

            entity.Property(e => e.DelTelephone)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEL_TELEPHONE");

            entity.Property(e => e.DeptName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DEPT_NAME");

            entity.Property(e => e.DeptNumber).HasColumnName("DEPT_NUMBER");

            entity.Property(e => e.DiscountRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("DISCOUNT_RATE");

            entity.Property(e => e.EMail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("E_MAIL");

            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FAX");

            entity.Property(e => e.FirstInvDate)
                .HasColumnType("datetime")
                .HasColumnName("FIRST_INV_DATE");

            entity.Property(e => e.InvoiceBf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_BF");

            entity.Property(e => e.InvoiceCf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_CF");

            entity.Property(e => e.InvoiceMth1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH1");

            entity.Property(e => e.InvoiceMth10)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH10");

            entity.Property(e => e.InvoiceMth11)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH11");

            entity.Property(e => e.InvoiceMth12)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH12");

            entity.Property(e => e.InvoiceMth2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH2");

            entity.Property(e => e.InvoiceMth3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH3");

            entity.Property(e => e.InvoiceMth4)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH4");

            entity.Property(e => e.InvoiceMth5)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH5");

            entity.Property(e => e.InvoiceMth6)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH6");

            entity.Property(e => e.InvoiceMth7)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH7");

            entity.Property(e => e.InvoiceMth8)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH8");

            entity.Property(e => e.InvoiceMth9)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("INVOICE_MTH9");

            entity.Property(e => e.LastInvDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_INV_DATE");

            entity.Property(e => e.LastPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_PAYMENT_DATE");

            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.OverrideTaxCode).HasColumnName("OVERRIDE_TAX_CODE");

            entity.Property(e => e.PaymentBf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_BF");

            entity.Property(e => e.PaymentCf)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_CF");

            entity.Property(e => e.PaymentDueDays).HasColumnName("PAYMENT_DUE_DAYS");

            entity.Property(e => e.PaymentMth1)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH1");

            entity.Property(e => e.PaymentMth10)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH10");

            entity.Property(e => e.PaymentMth11)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH11");

            entity.Property(e => e.PaymentMth12)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH12");

            entity.Property(e => e.PaymentMth2)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH2");

            entity.Property(e => e.PaymentMth3)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH3");

            entity.Property(e => e.PaymentMth4)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH4");

            entity.Property(e => e.PaymentMth5)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH5");

            entity.Property(e => e.PaymentMth6)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH6");

            entity.Property(e => e.PaymentMth7)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH7");

            entity.Property(e => e.PaymentMth8)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH8");

            entity.Property(e => e.PaymentMth9)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PAYMENT_MTH9");

            entity.Property(e => e.PriorYear)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("PRIOR_YEAR");

            entity.Property(e => e.RestrictMail).HasColumnName("RESTRICT_MAIL");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SettlementDiscRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("SETTLEMENT_DISC_RATE");

            entity.Property(e => e.SettlementDueDays).HasColumnName("SETTLEMENT_DUE_DAYS");

            entity.Property(e => e.StatusNumber).HasColumnName("STATUS_NUMBER");

            entity.Property(e => e.StatusText)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("STATUS_TEXT");

            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEPHONE");

            entity.Property(e => e.Telephone2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEPHONE_2");

            entity.Property(e => e.Terms)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TERMS");

            entity.Property(e => e.TermsAgreed).HasColumnName("TERMS_AGREED");

            entity.Property(e => e.TradeContact)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TRADE_CONTACT");

            entity.Property(e => e.TurnoverMtd)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("TURNOVER_MTD");

            entity.Property(e => e.TurnoverYtd)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("TURNOVER_YTD");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UseBacs).HasColumnName("USE_BACS");

            entity.Property(e => e.UseBsoc).HasColumnName("USE_BSOC");

            entity.Property(e => e.VatRegNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VAT_REG_NUMBER");

            entity.Property(e => e.WebAddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("WEB_ADDRESS");
        });

        modelBuilder.Entity<Sage50TaxCode>(entity =>
        {
            entity.ToTable("Sage50TaxCode");

            entity.Property(e => e.Sage50TaxCodeId).HasColumnName("Sage50TaxCodeID");

            entity.Property(e => e.Description)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");

            entity.Property(e => e.EuroPurchase).HasColumnName("EURO_PURCHASE");

            entity.Property(e => e.EuroSales).HasColumnName("EURO_SALES");

            entity.Property(e => e.IsReversecharge).HasColumnName("IS_REVERSECHARGE");

            entity.Property(e => e.RelatedCode).HasColumnName("RELATED_CODE");

            entity.Property(e => e.RelatedRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("RELATED_RATE");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.TaxCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TAX_CODE");

            entity.Property(e => e.TaxRate)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("TAX_RATE");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.VatInclude).HasColumnName("VAT_INCLUDE");
        });

        modelBuilder.Entity<SageDatabase>(entity =>
        {
            entity.ToTable("SageDatabase");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.CompanyId)
                .HasColumnName("CompanyID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CompanyLogoPath)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CompanyRegisteredNumber)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ConnectString)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ConnectionType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomPrintText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DatabasePassword)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DefaultNonTaxRateId)
                .HasColumnName("DefaultNonTaxRateID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.DefaultStockItemWarehouse)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DefaultTaxRateId)
                .HasColumnName("DefaultTaxRateID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DirectDeliveryWarehouse)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DocumentNoPrefix)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.GremailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("GREmailBodyText");

            entity.Property(e => e.GremailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GREmailSubjectText");

            entity.Property(e => e.InvoiceEmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceEmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LayoutsFilePath)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.NonStockItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OdbcremoteServer).HasColumnName("ODBCRemoteServer");

            entity.Property(e => e.PassengerRateMileageExpenseCategoryId)
                .HasColumnName("PassengerRateMileageExpenseCategoryID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.PlaceOfRegistration)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PoquoteEmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("POQuoteEmailBodyText");

            entity.Property(e => e.PoquoteEmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("POQuoteEmailSubjectText");

            entity.Property(e => e.Poreport).HasColumnName("POReport");

            entity.Property(e => e.PoreportDetailed).HasColumnName("POReportDetailed");

            entity.Property(e => e.PotermsAndConditionsLandscape).HasColumnName("POTermsAndConditionsLandscape");

            entity.Property(e => e.PotermsAndConditionsPage)
                .IsUnicode(false)
                .HasColumnName("POTermsAndConditionsPage");

            entity.Property(e => e.ProFormaEmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.ProFormaEmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ProjectRequisitionEmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.ProjectRequisitionEmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PurchaseOrderEmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.PurchaseOrderEmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.QuoteEmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.QuoteEmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RegisteredOffice)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SagePassword)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageUsername)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SalesOrderEmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.SalesOrderEmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SalesOrderMinimumGrossMarginForOrderSelfApproval).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SalesOrderMinimumMarginForSelfApproval).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SalesOrderSignaturePage).IsUnicode(false);

            entity.Property(e => e.SalesOrderTermsAndConditionsPage).IsUnicode(false);

            entity.Property(e => e.Sopattachment)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SOPAttachment");

            entity.Property(e => e.SopreturnEmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("SOPReturnEmailBodyText");

            entity.Property(e => e.SopreturnEmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SOPReturnEmailSubjectText");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UseWebApi).HasColumnName("UseWebAPI");

            entity.Property(e => e.WebApipassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("WebAPIPassword");

            entity.Property(e => e.WebApiusername)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("WebAPIUsername");

            entity.Property(e => e.YearStartMonth).HasDefaultValueSql("((4))");
        });

        modelBuilder.Entity<SageDatabaseReportField>(entity =>
        {
            entity.ToTable("SageDatabaseReportField");

            entity.Property(e => e.SageDatabaseReportFieldId).HasColumnName("SageDatabaseReportFieldID");

            entity.Property(e => e.DetailedReportId).HasColumnName("DetailedReportID");

            entity.Property(e => e.EmailBodyText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.EmailSubjectText)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.InternalReportId).HasColumnName("InternalReportID");

            entity.Property(e => e.ReportId).HasColumnName("ReportID");

            entity.Property(e => e.ReportType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SignaturePage).IsUnicode(false);

            entity.Property(e => e.TermsAndConditionsPage).IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SageDatabaseSystemSetting>(entity =>
        {
            entity.Property(e => e.SageDatabaseSystemSettingId).HasColumnName("SageDatabaseSystemSettingID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SettingId).HasColumnName("SettingID");

            entity.Property(e => e.SettingValue)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesInvoiceLayout>(entity =>
        {
            entity.ToTable("SalesInvoiceLayout");

            entity.Property(e => e.SalesInvoiceLayoutId).HasColumnName("SalesInvoiceLayoutID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrder>(entity =>
        {
            entity.ToTable("SalesOrder");

            entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

            entity.Property(e => e.AmountPaid)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Analysis1)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis10)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis11)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis12)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis13)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis14)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis15)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis16)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis17)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis18)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis19)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis2)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis20)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis3)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis4)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis5)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis6)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis7)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis8)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis9)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.CheckForNewDocuments).HasDefaultValueSql("((0))");

            entity.Property(e => e.CrmcompanyId).HasColumnName("CRMCompanyID");

            entity.Property(e => e.Crmusername)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CRMUsername");

            entity.Property(e => e.CurrencySymbol)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerContactName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CustomerDeliveryAddressId).HasColumnName("CustomerDeliveryAddressID");

            entity.Property(e => e.CustomerEmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CustomerFax)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CustomerReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CustomerTelephone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine1)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine2)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine3)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressLine4)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryCity)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryCounty)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

            entity.Property(e => e.DeliveryPostCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryPostalName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.HasAnalysisValues).HasDefaultValueSql("((0))");

            entity.Property(e => e.HasAttachments).HasDefaultValueSql("((0))");

            entity.Property(e => e.InternalOrder).HasDefaultValueSql("((0))");

            entity.Property(e => e.InvoiceAddressLine1)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine2)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine3)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAddressLine4)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceCity)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceCounty)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

            entity.Property(e => e.InvoicePostCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InvoicePostalName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.LinkedSalesOrderDocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LinkedSalesOrderId).HasColumnName("LinkedSalesOrderID");

            entity.Property(e => e.LinkedSopreturnId).HasColumnName("LinkedSOPReturnID");

            entity.Property(e => e.MandatoryCustom1).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom2).HasDefaultValueSql("((0))");

            entity.Property(e => e.MandatoryCustom3).HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.NetValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OrderDate).HasColumnType("datetime");

            entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.OrderDiscountPercent).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.OrderStatus)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ProFormaPrinted).HasDefaultValueSql("((0))");

            entity.Property(e => e.QuotePrinted).HasDefaultValueSql("((0))");

            entity.Property(e => e.QuoteStatus)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RequestedByUserId).HasColumnName("RequestedByUserID");

            entity.Property(e => e.RequestedByUserName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageDatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SalesOrderGenerated).HasDefaultValueSql("((0))");

            entity.Property(e => e.SalesOrderInternalPrinted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SalesOrderPrinted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SalesOrderType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SlcustomerAccountId).HasColumnName("SLCustomerAccountID");

            entity.Property(e => e.SodocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SODocumentNo");

            entity.Property(e => e.SoporderReturnId).HasColumnName("SOPOrderReturnID");

            entity.Property(e => e.SpareDate1).HasColumnType("datetime");

            entity.Property(e => e.SpareDate2).HasColumnType("datetime");

            entity.Property(e => e.SpareDate3).HasColumnType("datetime");

            entity.Property(e => e.SpareNumber1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareNumber2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareNumber3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareText1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpareText2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpareText3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Special).IsUnicode(false);

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.SysCountryCodeId).HasColumnName("SysCountryCodeID");

            entity.Property(e => e.SysTaxCodeId).HasColumnName("SysTaxCodeID");

            entity.Property(e => e.SystraderAnalysisValueId).HasColumnName("SYSTraderAnalysisValueID");

            entity.Property(e => e.TaxNumber)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TradeInValue)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.UseInvoiceAddress).HasDefaultValueSql("((1))");

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<SalesOrderAcknowledgementLayout>(entity =>
        {
            entity.ToTable("SalesOrderAcknowledgementLayout");

            entity.Property(e => e.SalesOrderAcknowledgementLayoutId).HasColumnName("SalesOrderAcknowledgementLayoutID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrderCrmdetail>(entity =>
        {
            entity.ToTable("SalesOrderCRMDetail");

            entity.Property(e => e.SalesOrderCrmdetailId).HasColumnName("SalesOrderCRMDetailID");

            entity.Property(e => e.CaseId).HasColumnName("CaseID");

            entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

            entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

            entity.Property(e => e.CrmuserCreatedById).HasColumnName("CRMUserCreatedByID");

            entity.Property(e => e.LeadId).HasColumnName("LeadID");

            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

            entity.Property(e => e.PersonId).HasColumnName("PersonID");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrderLine>(entity =>
        {
            entity.ToTable("SalesOrderLine");

            entity.Property(e => e.SalesOrderLineId).HasColumnName("SalesOrderLineID");

            entity.Property(e => e.AmendedDescription).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendedDescriptionText)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.Analysis1)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis10)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis11)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis12)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis13)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis14)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis15)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis16)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis17)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis18)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis19)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis2)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis20)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis3)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis4)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis5)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis6)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis7)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis8)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Analysis9)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.BillCoverFrom).HasColumnType("datetime");

            entity.Property(e => e.BillCoverTo).HasColumnType("datetime");

            entity.Property(e => e.Complimentary).HasDefaultValueSql("((0))");

            entity.Property(e => e.ContractEndDate).HasColumnType("datetime");

            entity.Property(e => e.ContractStartDate).HasColumnType("datetime");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId)
                .HasColumnName("CustomRouteID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddressId).HasColumnName("DeliveryAddressID");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.FulfilmentMethodId).HasColumnName("FulfilmentMethodID");

            entity.Property(e => e.IssuesNominalAccountId)
                .HasColumnName("IssuesNominalAccountID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LineStatus)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LineType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lineType");

            entity.Property(e => e.MarginPercent)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.NlnominalAccountId).HasColumnName("NLNominalAccountID");

            entity.Property(e => e.PostedCostingDetailId)
                .HasColumnName("PostedCostingDetailID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.PricingMultOfStockUnit)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.PricingUnitDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ProRata).HasDefaultValueSql("((0))");

            entity.Property(e => e.ProRataDate).HasColumnType("datetime");

            entity.Property(e => e.ProjectCodeId).HasColumnName("ProjectCodeID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.ProjectPhaseId).HasColumnName("ProjectPhaseID");

            entity.Property(e => e.ProjectStageId).HasColumnName("ProjectStageID");

            entity.Property(e => e.ProjectSubStageId).HasColumnName("ProjectSubStageID");

            entity.Property(e => e.ProjectVariationId).HasColumnName("ProjectVariationID");

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.QuantityDespatched).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.QuantityInvoiced)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.RejectReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

            entity.Property(e => e.SalesOrderType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SellingMultOfStockUnit)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.SellingUnitDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ShowCommentOnCustomerDocs).HasDefaultValueSql("((1))");

            entity.Property(e => e.SoporderReturnLineId).HasColumnName("SOPOrderReturnLineID");

            entity.Property(e => e.SopunitPrice)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("SOPUnitPrice")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SpareDate1).HasColumnType("datetime");

            entity.Property(e => e.SpareDate2).HasColumnType("datetime");

            entity.Property(e => e.SpareDate3).HasColumnType("datetime");

            entity.Property(e => e.SpareNumber1).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareNumber2).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareNumber3).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SpareText1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpareText2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpareText3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

            entity.Property(e => e.StockItemSupplierId)
                .HasColumnName("StockItemSupplierID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<SalesOrderPriceBand>(entity =>
        {
            entity.ToTable("SalesOrderPriceBand");

            entity.Property(e => e.SalesOrderPriceBandId).HasColumnName("SalesOrderPriceBandID");

            entity.Property(e => e.CurrentPriceBandId).HasColumnName("CurrentPriceBandID");

            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

            entity.Property(e => e.ReplacementPriceBandId).HasColumnName("ReplacementPriceBandID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrderReport>(entity =>
        {
            entity.ToTable("SalesOrderReport");

            entity.Property(e => e.SalesOrderReportId).HasColumnName("SalesOrderReportID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Report)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReportType).HasDefaultValueSql("((0))");

            entity.Property(e => e.SecurityLevel).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrderReportMapping>(entity =>
        {
            entity.ToTable("SalesOrderReportMapping");

            entity.Property(e => e.SalesOrderReportMappingId).HasColumnName("SalesOrderReportMappingID");

            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Discount)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OrderTotalPrice)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Qty)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SalesOrderReportId)
                .HasColumnName("SalesOrderReportID")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.TotalPrice)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UnitPrice)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrderShipping>(entity =>
        {
            entity.ToTable("SalesOrderShipping");

            entity.Property(e => e.SalesOrderShippingId).HasColumnName("SalesOrderShippingID");

            entity.Property(e => e.Carrier)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CollectDate).HasColumnType("datetime");

            entity.Property(e => e.DateRequired).HasColumnType("datetime");

            entity.Property(e => e.SalesOrderId).HasColumnName("SalesOrderID");

            entity.Property(e => e.Service)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ShippingType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SpecialInstructions)
                .HasMaxLength(600)
                .IsUnicode(false);

            entity.Property(e => e.TotalPalletWeight)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.VehicleType)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesOrderShippingLine>(entity =>
        {
            entity.ToTable("SalesOrderShippingLine");

            entity.Property(e => e.SalesOrderShippingLineId).HasColumnName("SalesOrderShippingLineID");

            entity.Property(e => e.PalletDimensions)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ParcelDimensions)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ParcelWeight)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SalesOrderShippingId).HasColumnName("SalesOrderShippingID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesQuoteLayout>(entity =>
        {
            entity.ToTable("SalesQuoteLayout");

            entity.Property(e => e.SalesQuoteLayoutId).HasColumnName("SalesQuoteLayoutID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ServiceNotification>(entity =>
        {
            entity.ToTable("ServiceNotification");

            entity.Property(e => e.ServiceNotificationId).HasColumnName("ServiceNotificationID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryTime).HasColumnType("datetime");

            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NotificationText).IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SystemMessageType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasIndex(e => e.SettingName, "Settings_Index");

            entity.Property(e => e.SettingId).HasColumnName("SettingID");

            entity.Property(e => e.SettingDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SettingName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SettingValue)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockItem>(entity =>
        {
            entity.ToTable("StockItem");

            entity.Property(e => e.StockItemId).HasColumnName("StockItemID");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.DefaultSupplierCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DefaultSupplierId).HasColumnName("DefaultSupplierID");

            entity.Property(e => e.DefaultSupplierStockCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.LineStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MaxLevel)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.MinLevel)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.ProductGroup)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

            entity.Property(e => e.RejectReason)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ReorderLevel)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageStockItemId).HasColumnName("SageStockItemID");

            entity.Property(e => e.StandardCostPrice)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.SupplierListPrice)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SupplierMinOrderQty)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SupplierUsualOrderQty)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

            entity.Property(e => e.Uom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UOM");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Warehouse)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseBin)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<SubsistenceGrade>(entity =>
        {
            entity.ToTable("SubsistenceGrade");

            entity.Property(e => e.SubsistenceGradeId).HasColumnName("SubsistenceGradeID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubsistenceIncidental>(entity =>
        {
            entity.HasKey(e => e.SubsistenceIncidentalsId);

            entity.Property(e => e.CurrencyIsocode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CurrencyISOCode");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.MinimumRequiredAttachments).HasDefaultValueSql("((0))");

            entity.Property(e => e.MinimumRequiredAttachmentsNoReceipt).HasDefaultValueSql("((0))");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Rate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubsistenceRate>(entity =>
        {
            entity.ToTable("SubsistenceRate");

            entity.Property(e => e.SubsistenceRateId).HasColumnName("SubsistenceRateID");

            entity.Property(e => e.AccommodationRateDiscountPercentage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.AccommodationRateType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BreakfastRateDiscountPercentage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BreakfastRateType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityId)
                .HasColumnName("CityID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ConferenceRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.Property(e => e.CurrencyIsocode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CurrencyISOCode");

            entity.Property(e => e.Day0HoursRate)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Day10HoursRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Day5HoursRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DinnerDiscount).HasDefaultValueSql("((0))");

            entity.Property(e => e.DinnerRateDiscountPercentage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DinnerRateType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DualMealRateDiscountPercentage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DualMealRateType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LunchRateDiscountPercentage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LunchRateType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OvernightDetentionRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OvernightReducedRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OvernightStandardRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(CONVERT([datetime],'1753-01-01 00:00:00.000'))");

            entity.Property(e => e.SubsistenceGradeId).HasColumnName("SubsistenceGradeID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Supplier");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

            entity.Property(e => e.AddressCity)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine4)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountBacsref)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("BankAccountBACSRef");

            entity.Property(e => e.BankAccountBic)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("BankAccountBIC");

            entity.Property(e => e.BankAccountIban)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("BankAccountIBAN");

            entity.Property(e => e.BankAccountName)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BankPaymentReference)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.BankSortCode)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ContactEmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ContactFaxAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactFaxCountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ContactFaxNumber)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactMobileAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactMobileCountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ContactMobileNumber)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactTelephoneAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactTelephoneCountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ContactTelephoneNumber)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactWebsite)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.County)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CurrentStepApprovalCount).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.ExpenseUserId).HasColumnName("ExpenseUserID");

            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LineStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.PaymentSettlementDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PaymentSettlementDiscount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PaymentSettlementTerms).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PlaccountId).HasColumnName("PLAccountID");

            entity.Property(e => e.PostCode)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.RejectReason)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.RequestedByName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Salutation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.SupplierAccountRef)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.SupplierName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SupplierShortName)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.SyscountryCodeId).HasColumnName("SYSCountryCodeID");

            entity.Property(e => e.SyscurrencyId).HasColumnName("SYSCurrencyID");

            entity.Property(e => e.SyspaymentTermsBasisId).HasColumnName("SYSPaymentTermsBasisID");

            entity.Property(e => e.TelephoneAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TelephoneCountryCode)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TelephoneNumber)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TradingDefaultNominalCodeId).HasColumnName("TradingDefaultNominalCodeID");

            entity.Property(e => e.TradingDefaultTaxCodeId).HasColumnName("TradingDefaultTaxCodeID");

            entity.Property(e => e.TradingOrderPriority)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TradingSyscountryCodeId).HasColumnName("TradingSYSCountryCodeID");

            entity.Property(e => e.TradingTaxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.WebSite)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SystemMessage>(entity =>
        {
            entity.ToTable("SystemMessage");

            entity.Property(e => e.SystemMessageId).HasColumnName("SystemMessageID");

            entity.Property(e => e.DisplayUntil).HasColumnType("datetime");

            entity.Property(e => e.Message)
                .HasMaxLength(3000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Theme>(entity =>
        {
            entity.ToTable("Theme");

            entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

            entity.Property(e => e.DefaultTheme).HasDefaultValueSql("((0))");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Selectable).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TimeInLieu>(entity =>
        {
            entity.ToTable("TimeInLieu");

            entity.Property(e => e.TimeInLieuId).HasColumnName("TimeInLieuID");

            entity.Property(e => e.AdjustmentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Narrative)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SourceForeignChildId)
                .HasColumnName("SourceForeignChildID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SourceForeignId).HasColumnName("SourceForeignID");

            entity.Property(e => e.SourceModule)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TimeRecord>(entity =>
        {
            entity.ToTable("TimeRecord");

            entity.Property(e => e.TimeRecordId).HasColumnName("TimeRecordID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.ForieignId).HasColumnName("ForieignID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.TaskDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Timesheet>(entity =>
        {
            entity.ToTable("Timesheet");

            entity.HasIndex(e => new { e.RequestedById, e.Deleted }, "IX_Timesheet_RequestedByID_Deleted");

            entity.HasIndex(e => new { e.WeekStartDate, e.RequestedById, e.SageDatabaseId, e.Deleted }, "IX_Timesheet_WeekStartDate_RequestedByID_SageDatabaseID_Deleted");

            entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EnteredById).HasColumnName("EnteredByID");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.FullyApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.HasAnalysisValues).HasDefaultValueSql("((0))");

            entity.Property(e => e.MigratedTimesheetId).HasColumnName("MigratedTimesheetID");

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.Narrative)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.Notes).IsUnicode(false);

            entity.Property(e => e.RequestedById).HasColumnName("RequestedByID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageTimesheetId).HasColumnName("SageTimesheetID");

            entity.Property(e => e.SentToSage).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

            entity.Property(e => e.Toiladjustment)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("TOILAdjustment")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.TspersonId).HasColumnName("TSPersonID");

            entity.Property(e => e.UpdateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrgentReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.WeekStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TimesheetDefault>(entity =>
        {
            entity.ToTable("TimesheetDefault");

            entity.Property(e => e.TimesheetDefaultId).HasColumnName("TimesheetDefaultID");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.System).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TimesheetLine>(entity =>
        {
            entity.ToTable("TimesheetLine");

            entity.HasIndex(e => new { e.SentToSage, e.ModuleString }, "IX_TimesheetLine_SentToSage_ModuleString");

            entity.HasIndex(e => new { e.TimesheetId, e.SentToSage, e.ModuleString }, "IX_TimesheetLine_TimesheetID_SentToSage_ModuleString");

            entity.Property(e => e.TimesheetLineId).HasColumnName("TimesheetLineID");

            entity.Property(e => e.AmendedTimesheetLineId)
                .HasColumnName("AmendedTimesheetLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Amendment).HasDefaultValueSql("((0))");

            entity.Property(e => e.BankHolidayId)
                .HasColumnName("BankHolidayID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ChargeRateId).HasColumnName("ChargeRateID");

            entity.Property(e => e.ConcurrentJobs).HasDefaultValueSql("((1))");

            entity.Property(e => e.ConstructLineTypeId).HasColumnName("ConstructLineTypeID");

            entity.Property(e => e.ConstructVariationId).HasColumnName("ConstructVariationID");

            entity.Property(e => e.CopiedFrom).HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CostRateId).HasColumnName("CostRateID");

            entity.Property(e => e.CostRateType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreatedByRule).HasDefaultValueSql("((0))");

            entity.Property(e => e.CustomRouteId).HasColumnName("CustomRouteID");

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.HolidayRequestLineId)
                .HasColumnName("HolidayRequestLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.HrabsenceId)
                .HasColumnName("HRAbsenceID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.JobManager)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LineStatus)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LineStatusId).HasColumnName("LineStatusID");

            entity.Property(e => e.LineType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryHolidayId)
                .HasColumnName("MandatoryHolidayID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ModuleString)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Narrative).IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.Original).HasDefaultValueSql("((0))");

            entity.Property(e => e.OriginalTimesheetLineId)
                .HasColumnName("OriginalTimesheetLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.OverBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.PayRateId).HasColumnName("PayRateID");

            entity.Property(e => e.PayrollPostingDate).HasColumnType("datetime");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.ProjectPhaseId).HasColumnName("ProjectPhaseID");

            entity.Property(e => e.ProjectStageId).HasColumnName("ProjectStageID");

            entity.Property(e => e.ProjectSubStageId).HasColumnName("ProjectSubStageID");

            entity.Property(e => e.QuantityComplete).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.RateOverridden).HasDefaultValueSql("((0))");

            entity.Property(e => e.RejectReason)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Rework).HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SentToSage).HasDefaultValueSql("((0))");

            entity.Property(e => e.SiJcvariationId)
                .HasColumnName("SiJCVariationID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SiOperationId).HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SiWorksOrderLineId).HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");

            entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

            entity.Property(e => e.TopLevelProjectId).HasColumnName("TopLevelProjectID");

            entity.Property(e => e.TransactionId)
                .HasColumnName("TransactionID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WofinishedItemQuantity)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("WOFinishedItemQuantity");
        });

        modelBuilder.Entity<TimesheetLineHour>(entity =>
        {
            entity.HasKey(e => e.TimesheetLineHoursId);

            entity.HasIndex(e => new { e.TimesheetLineId, e.Hours, e.PostedTransactionId }, "IX_TimesheetLineHours_TimesheetLineID_Hours_PostedTransactionID");

            entity.Property(e => e.TimesheetLineHoursId).HasColumnName("TimesheetLineHoursID");

            entity.Property(e => e.Deduction).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.Hours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.HoursHhmm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoursHHMM");

            entity.Property(e => e.MobileGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MobileGUID");

            entity.Property(e => e.Notes)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.PostedTransactionId).HasColumnName("PostedTransactionID");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.TimesheetLineId).HasColumnName("TimesheetLineID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TimesheetLineResourceHour>(entity =>
        {
            entity.HasKey(e => e.TimesheetLineResourceHoursId);

            entity.Property(e => e.TimesheetLineResourceHoursId).HasColumnName("TimesheetLineResourceHoursID");

            entity.Property(e => e.PostedTransactionId).HasColumnName("PostedTransactionID");

            entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

            entity.Property(e => e.TimesheetLineHoursId).HasColumnName("TimesheetLineHoursID");

            entity.Property(e => e.TimesheetLineId).HasColumnName("TimesheetLineID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TimesheetLockedWeek>(entity =>
        {
            entity.ToTable("TimesheetLockedWeek");

            entity.Property(e => e.TimesheetLockedWeekId).HasColumnName("TimesheetLockedWeekID");

            entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TimesheetPaymentLine>(entity =>
        {
            entity.ToTable("TimesheetPaymentLine");

            entity.HasIndex(e => new { e.LoginRecordLineId, e.Deleted }, "IX_TimesheetPaymentLine_LoginRecordLineID_Deleted");

            entity.HasIndex(e => new { e.TimesheetId, e.Deleted }, "IX_TimesheetPaymentLine_TimesheetID_Deleted");

            entity.Property(e => e.TimesheetPaymentLineId).HasColumnName("TimesheetPaymentLineID");

            entity.Property(e => e.LoginRecordLineId).HasColumnName("LoginRecordLineID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

            entity.Property(e => e.TimesheetLineId)
                .HasColumnName("TimesheetLineID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.WorkPatternPayRateId).HasColumnName("WorkPatternPayRateID");
        });

        modelBuilder.Entity<TimesheetPaymentLineHour>(entity =>
        {
            entity.HasKey(e => e.TimesheetPaymentLineHoursId);

            entity.HasIndex(e => new { e.TimesheetPaymentLineId, e.Deleted }, "IX_TimesheetPaymentLineHours_TimesheetPaymentLineID_Deleted");

            entity.Property(e => e.TimesheetPaymentLineHoursId).HasColumnName("TimesheetPaymentLineHoursID");

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.Hours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.HoursHhmm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoursHHMM");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.TimesheetPaymentLineId).HasColumnName("TimesheetPaymentLineID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => new { e.Deleted, e.Inactive }, "IX_User_Deleted_Inactive");

            entity.HasIndex(e => new { e.Deleted, e.Inactive, e.AllowLogin, e.UserName, e.SystemAccount }, "IX_User_Deleted_Inactive_AllowLogin_UserName_SystemAccount");

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.AccessAllDelegates).HasDefaultValueSql("((0))");

            entity.Property(e => e.AccessAllExpenseMeetings).HasDefaultValueSql("((0))");

            entity.Property(e => e.AccessAllNominals).HasDefaultValueSql("((0))");

            entity.Property(e => e.AccessAllProjectItemTypes).HasDefaultValueSql("((0))");

            entity.Property(e => e.AccessAllProjectItems).HasDefaultValueSql("((0))");

            entity.Property(e => e.AccessAllProjects).HasDefaultValueSql("((0))");

            entity.Property(e => e.AllowLogin).HasDefaultValueSql("((1))");

            entity.Property(e => e.AlternateUserId).HasColumnName("AlternateUserID");

            entity.Property(e => e.AnalysisCode1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode10)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode4)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode5)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode6)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode7)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode8)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode9)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AuthenticateGuid)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.CanSelectOtherPrivateVehicles).HasDefaultValueSql("((0))");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.Property(e => e.CreditCardPostingReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CurrentMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DefaultVehicleId).HasColumnName("DefaultVehicleID");

            entity.Property(e => e.DisableExpenseItemSagePosting).HasDefaultValueSql("((0))");

            entity.Property(e => e.DisableMileageItemSagePosting).HasDefaultValueSql("((0))");

            entity.Property(e => e.DistanceToHome).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.EmploymentStartDate).HasColumnType("datetime");

            entity.Property(e => e.ForcePasswordChange).HasDefaultValueSql("((0))");

            entity.Property(e => e.Forename)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FtcomparisonWorkPatternId)
                .HasColumnName("FTComparisonWorkPatternID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.FuelCardPostingReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FuelRateId).HasColumnName("FuelRateID");

            entity.Property(e => e.HistoricalBusinessMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.HistoricalPersonalMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.HolidayWorkPatternId)
                .HasColumnName("HolidayWorkPatternID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.MaximumAuthorisationValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.MaximumDailyTimesheetHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.MaximumOrderValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OnlyOneJobAtAtime).HasColumnName("OnlyOneJobAtATime");

            entity.Property(e => e.OverrideJobBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideJobCostHeaderBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideJobPeriodBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideJobPhaseBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideJobStageBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideJobSubStageBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideJobTopLevelBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideProjectBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideProjectItemBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideTopLevelCostItemBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideTopLevelProjectBudget).HasDefaultValueSql("((0))");

            entity.Property(e => e.OverrideYtdbudget).HasColumnName("OverrideYTDBudget");

            entity.Property(e => e.OvertimeHours2StartsAt).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OvertimeHours3StartsAt).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OvertimeHoursStartsAt).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ParentGroupOverrideAnnualBudget).HasDefaultValueSql("((1))");

            entity.Property(e => e.ParentGroupOverrideMonthlyBudget).HasDefaultValueSql("((1))");

            entity.Property(e => e.ParentGroupOverrideYtdbudget)
                .HasColumnName("ParentGroupOverrideYTDBudget")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.PartTime).HasDefaultValueSql("((0))");

            entity.Property(e => e.PasswordChangedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(CONVERT([datetime],'1753-01-01 00:00:00.000'))");

            entity.Property(e => e.PasswordExpiryDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(CONVERT([datetime],'1753-01-01 00:00:00.000'))");

            entity.Property(e => e.Pin)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReportingCategoryOverrideAnnualBudget).HasDefaultValueSql("((1))");

            entity.Property(e => e.ReportingCategoryOverrideMonthlyBudget).HasDefaultValueSql("((1))");

            entity.Property(e => e.ReportingCategoryOverrideYtdbudget)
                .HasColumnName("ReportingCategoryOverrideYTDBudget")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.SageDatabaseIdforPayroll)
                .HasColumnName("SageDatabaseIDForPayroll")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.SagePayrollReference)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SelfApprovalCheckBudgets).HasDefaultValueSql("((1))");

            entity.Property(e => e.SelfApprovalValue)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.StartMileage).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SubsistenceEnabled).HasDefaultValueSql("((1))");

            entity.Property(e => e.SubsistenceGradeId).HasColumnName("SubsistenceGradeID");

            entity.Property(e => e.SubtractRegularCommute).HasDefaultValueSql("((0))");

            entity.Property(e => e.Surname)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SystemAccount).HasDefaultValueSql("((0))");

            entity.Property(e => e.TelephoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TimeInLieuHoursAccrued).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TimeInLieuHoursMaximum).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TimeInLieuHoursMinimum).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TimeInLieuHoursStartsAt).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TimesheetHoursWorkPatternId)
                .HasColumnName("TimesheetHoursWorkPatternID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ToilbankPog).HasColumnName("TOILBankPOG");

            entity.Property(e => e.TwoFactorSecurityKey)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserGuid).HasDefaultValueSql("(newid())");

            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserPassword)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

            entity.Property(e => e.VehicleReg)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ViewAllSupplierFilterCodes).HasDefaultValueSql("((0))");

            entity.Property(e => e.WeeklyContractedHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.WelcomeEmailSent).HasDefaultValueSql("((0))");

            entity.Property(e => e.WorkPatternId)
                .HasColumnName("WorkPatternID")
                .HasDefaultValueSql("((-2147483648))");
        });

        modelBuilder.Entity<UserContract>(entity =>
        {
            entity.ToTable("UserContract");

            entity.Property(e => e.UserContractId).HasColumnName("UserContractID");

            entity.Property(e => e.ConstructDatabaseId).HasColumnName("ConstructDatabaseID");

            entity.Property(e => e.ContractId).HasColumnName("ContractID");

            entity.Property(e => e.ContractItemId).HasColumnName("ContractItemID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserCostingHeader>(entity =>
        {
            entity.ToTable("UserCostingHeader");

            entity.HasIndex(e => new { e.UserId, e.SageDatabaseId }, "IX_UserCostingHeader_UserID_SageDatabaseID");

            entity.Property(e => e.UserCostingHeaderId).HasColumnName("UserCostingHeaderID");

            entity.Property(e => e.CostingHeaderId).HasColumnName("CostingHeaderID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserCostingItem>(entity =>
        {
            entity.ToTable("UserCostingItem");

            entity.Property(e => e.UserCostingItemId).HasColumnName("UserCostingItemID");

            entity.Property(e => e.ApprovalValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CostingHeaderId)
                .HasColumnName("CostingHeaderID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CostingItemId).HasColumnName("CostingItemID");

            entity.Property(e => e.Expense)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.HolidayRequest)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Invoice)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.ItemValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Requisition)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SalesOrder)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Timesheet)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserCostingItemType>(entity =>
        {
            entity.ToTable("UserCostingItemType");

            entity.Property(e => e.UserCostingItemTypeId).HasColumnName("UserCostingItemTypeID");

            entity.Property(e => e.CostingItemTypeId).HasColumnName("CostingItemTypeID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserCreditCardExpense>(entity =>
        {
            entity.ToTable("UserCreditCardExpense");

            entity.Property(e => e.UserCreditCardExpenseId).HasColumnName("UserCreditCardExpenseID");

            entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserDepartment>(entity =>
        {
            entity.ToTable("UserDepartment");

            entity.Property(e => e.UserDepartmentId).HasColumnName("UserDepartmentID");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserEmail>(entity =>
        {
            entity.ToTable("UserEmail");

            entity.Property(e => e.UserEmailId).HasColumnName("UserEmailID");

            entity.Property(e => e.EmailThreadId).HasColumnName("EmailThreadID");

            entity.Property(e => e.SendAwaitingApproval).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendComplete).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendEmailRecords).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendFriday).HasDefaultValueSql("((1))");

            entity.Property(e => e.SendFullyAllocated).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendFullyApproved).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendGoodsReceived).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendMonday).HasDefaultValueSql("((1))");

            entity.Property(e => e.SendNoApprovers).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendOnHold).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendPartAllocated).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendPostedToSage).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendRejected).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendSaturday).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendSunday).HasDefaultValueSql("((0))");

            entity.Property(e => e.SendThursday).HasDefaultValueSql("((1))");

            entity.Property(e => e.SendTuesday).HasDefaultValueSql("((1))");

            entity.Property(e => e.SendWednesday).HasDefaultValueSql("((1))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserExpenseMeeting>(entity =>
        {
            entity.ToTable("UserExpenseMeeting");

            entity.Property(e => e.UserExpenseMeetingId).HasColumnName("UserExpenseMeetingID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserExpenseType>(entity =>
        {
            entity.ToTable("UserExpenseType");

            entity.Property(e => e.UserExpenseTypeId).HasColumnName("UserExpenseTypeID");

            entity.Property(e => e.CostingItemId)
                .HasColumnName("CostingItemID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");

            entity.Property(e => e.MaximumClaim).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Memo).IsUnicode(false);

            entity.Property(e => e.NlnominalAccountId).HasColumnName("NLNominalAccountID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Selectable).HasDefaultValueSql("((1))");

            entity.Property(e => e.SystaxRateId).HasColumnName("SYSTaxRateID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserExpenseTypeNominal>(entity =>
        {
            entity.ToTable("UserExpenseTypeNominal");

            entity.Property(e => e.UserExpenseTypeNominalId).HasColumnName("UserExpenseTypeNominalID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsUserDefault).HasDefaultValueSql("((0))");

            entity.Property(e => e.Memo)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.NlnominalAccountId).HasColumnName("NLNominalAccountID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserExpenseTypeId).HasColumnName("UserExpenseTypeID");
        });

        modelBuilder.Entity<UserFavourite>(entity =>
        {
            entity.ToTable("UserFavourite");

            entity.Property(e => e.UserFavouriteId).HasColumnName("UserFavouriteID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.EntityId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EntityID");

            entity.Property(e => e.FavouriteType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<UserFavouriteAddress>(entity =>
        {
            entity.ToTable("UserFavouriteAddress");

            entity.Property(e => e.UserFavouriteAddressId).HasColumnName("UserFavouriteAddressID");

            entity.Property(e => e.AddressDescription)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.AddressDetail)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserHoliday>(entity =>
        {
            entity.ToTable("UserHoliday");

            entity.Property(e => e.UserHolidayId).HasColumnName("UserHolidayID");

            entity.Property(e => e.BookedDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BookedHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BroughtForwardDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BroughtForwardHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CarriedForwardDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CarriedForwardHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.EntitlementDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.EntitlementHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PaidDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PaidHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

            entity.Property(e => e.PeriodStart).HasColumnType("datetime");

            entity.Property(e => e.SubmittedDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SubmittedHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TakenDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.TakenHours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.WrittenOffDays).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.WrittenOffHours).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<UserHolidayRule>(entity =>
        {
            entity.ToTable("UserHolidayRule");

            entity.Property(e => e.UserHolidayRuleId).HasColumnName("UserHolidayRuleID");

            entity.Property(e => e.AlreadyBookedUserId).HasColumnName("AlreadyBookedUserID");

            entity.Property(e => e.DenyUserId).HasColumnName("DenyUserID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserItemValue>(entity =>
        {
            entity.ToTable("UserItemValue");

            entity.Property(e => e.UserItemValueId).HasColumnName("UserItemValueID");

            entity.Property(e => e.ApprovalValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RequestValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.UserItemValueType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ValueTypeForeignId).HasColumnName("ValueTypeForeignID");
        });

        modelBuilder.Entity<UserJob>(entity =>
        {
            entity.ToTable("UserJob");

            entity.Property(e => e.UserJobId).HasColumnName("UserJobID");

            entity.Property(e => e.MaxAuthorisationValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.MaxLineValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.Sijcchdid).HasColumnName("SIJCCHDID");

            entity.Property(e => e.Sijcjobid).HasColumnName("SIJCJOBID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserMileageBalance>(entity =>
        {
            entity.ToTable("UserMileageBalance");

            entity.Property(e => e.UserMileageBalanceId).HasColumnName("UserMileageBalanceID");

            entity.Property(e => e.BalanceDate).HasColumnType("datetime");

            entity.Property(e => e.BusinessBalance).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BusinessBalancePrivate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.PersonalBalance).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserNominalAccount>(entity =>
        {
            entity.ToTable("UserNominalAccount");

            entity.HasIndex(e => new { e.UserId, e.SageDatabaseId }, "UserNominalAccount_Index");

            entity.Property(e => e.UserNominalAccountId).HasColumnName("UserNominalAccountID");

            entity.Property(e => e.MaxAuthorisationValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.MaxLineValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.NominalAccountId).HasColumnName("NominalAccountID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserOrderTemplate>(entity =>
        {
            entity.ToTable("UserOrderTemplate");

            entity.Property(e => e.UserOrderTemplateId).HasColumnName("UserOrderTemplateID");

            entity.Property(e => e.OrderTemplateDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.OrderTemplateId).HasColumnName("OrderTemplateID");

            entity.Property(e => e.SageDatabaseName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserPasswordHistory>(entity =>
        {
            entity.ToTable("UserPasswordHistory");

            entity.Property(e => e.UserPasswordHistoryId).HasColumnName("UserPasswordHistoryID");

            entity.Property(e => e.CreatedDate)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserProject>(entity =>
        {
            entity.ToTable("UserProject");

            entity.Property(e => e.UserProjectId).HasColumnName("UserProjectID");

            entity.Property(e => e.Expense)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.HolidayRequest)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Invoice)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.MaxAuthorisationValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.MaxLineValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.Property(e => e.ProjectItemId).HasColumnName("ProjectItemID");

            entity.Property(e => e.Requisition)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SalesOrder)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Timesheet)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserProjectItemType>(entity =>
        {
            entity.ToTable("UserProjectItemType");

            entity.Property(e => e.UserProjectItemTypeId).HasColumnName("UserProjectItemTypeID");

            entity.Property(e => e.ProjectItemTypeId).HasColumnName("ProjectItemTypeID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.ToTable("UserRole");

            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

            entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<UserSageDatabase>(entity =>
        {
            entity.ToTable("UserSageDatabase");

            entity.Property(e => e.UserSageDatabaseId).HasColumnName("UserSageDatabaseID");

            entity.Property(e => e.CcsStaffId).HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.ComponentWarehouseId)
                .HasColumnName("ComponentWarehouseID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.CreditCardSupplierAccountId)
                .HasColumnName("CreditCardSupplierAccountID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.DefaultDatabase).HasDefaultValueSql("((0))");

            entity.Property(e => e.DefaultDeliveryAddressId)
                .HasColumnName("DefaultDeliveryAddressID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.DefaultInvoiceAddressId)
                .HasColumnName("DefaultInvoiceAddressID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.DefaultNominalAccountId)
                .HasColumnName("DefaultNominalAccountID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.FirstRateMileageExpenseCategoryId)
                .HasColumnName("FirstRateMileageExpenseCategoryID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.FuelCardSupplierAccountId)
                .HasColumnName("FuelCardSupplierAccountID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.MileageNominalAccountId).HasColumnName("MileageNominalAccountID");

            entity.Property(e => e.OverrideDeliveryAddress).HasDefaultValueSql("((1))");

            entity.Property(e => e.OverrideInvoiceAddress).HasDefaultValueSql("((1))");

            entity.Property(e => e.OverrideNominalAccount).HasDefaultValueSql("((1))");

            entity.Property(e => e.PassengerRateMileageExpenseCategoryId)
                .HasColumnName("PassengerRateMileageExpenseCategoryID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.PlsupplierAccountId).HasColumnName("PLSupplierAccountID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SecondRateMileageExpenseCategoryId)
                .HasColumnName("SecondRateMileageExpenseCategoryID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.TatouchScreenDefault)
                .HasColumnName("TATouchScreenDefault")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.TspersonId)
                .HasColumnName("TSPersonID")
                .HasDefaultValueSql("((-2147483648))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserSelfApprovalValue>(entity =>
        {
            entity.ToTable("UserSelfApprovalValue");

            entity.Property(e => e.UserSelfApprovalValueId).HasColumnName("UserSelfApprovalValueID");

            entity.Property(e => e.ApprovalValue).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.ToTable("UserSetting");

            entity.Property(e => e.UserSettingId).HasColumnName("UserSettingID");

            entity.Property(e => e.LoadNominalAccountLists).HasDefaultValueSql("((1))");

            entity.Property(e => e.OrderTemplateAutoAddItemsWithQuantity).HasDefaultValueSql("((0))");

            entity.Property(e => e.PageCustomisation).HasDefaultValueSql("((0))");

            entity.Property(e => e.PoemailIncludeMe).HasColumnName("POEmailIncludeMe");

            entity.Property(e => e.ShowProjectSelectionOnExpenseEntry).HasDefaultValueSql("((1))");

            entity.Property(e => e.ShowQuickLinks)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.StockSelectionMode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ThemeName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserSubsistenceIncidental>(entity =>
        {
            entity.HasKey(e => e.UserSubsistenceIncidentalsId);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserSupplierFilterCode>(entity =>
        {
            entity.ToTable("UserSupplierFilterCode");

            entity.Property(e => e.UserSupplierFilterCodeId).HasColumnName("UserSupplierFilterCodeID");

            entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SupplierFilterCodeId).HasColumnName("SupplierFilterCodeID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserSystemSetting>(entity =>
        {
            entity.Property(e => e.UserSystemSettingId).HasColumnName("UserSystemSettingID");

            entity.Property(e => e.SettingId).HasColumnName("SettingID");

            entity.Property(e => e.SettingValue)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserTimeRule>(entity =>
        {
            entity.ToTable("UserTimeRule");

            entity.Property(e => e.UserTimeRuleId).HasColumnName("UserTimeRuleID");

            entity.Property(e => e.CostRateId).HasColumnName("CostRateID");

            entity.Property(e => e.CostingModule)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Day)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.EndAllowance).HasColumnType("datetime");

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.Hours).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.LunchEndTime).HasColumnType("datetime");

            entity.Property(e => e.LunchStartTime).HasColumnType("datetime");

            entity.Property(e => e.PayrollPayElementDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PayrollPayElementReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StartAllowance).HasColumnType("datetime");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserTimesheetSubmission>(entity =>
        {
            entity.ToTable("UserTimesheetSubmission");

            entity.Property(e => e.UserTimesheetSubmissionId).HasColumnName("UserTimesheetSubmissionID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.WeekStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserTimesheetTeamDefault>(entity =>
        {
            entity.ToTable("UserTimesheetTeamDefault");

            entity.Property(e => e.UserTimesheetTeamDefaultId).HasColumnName("UserTimesheetTeamDefaultID");

            entity.Property(e => e.Friday).HasDefaultValueSql("((0))");

            entity.Property(e => e.LinkedUserId).HasColumnName("LinkedUserID");

            entity.Property(e => e.Monday).HasDefaultValueSql("((0))");

            entity.Property(e => e.Saturday).HasDefaultValueSql("((0))");

            entity.Property(e => e.Sunday).HasDefaultValueSql("((0))");

            entity.Property(e => e.Thursday).HasDefaultValueSql("((0))");

            entity.Property(e => e.Tuesday).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.Wednesday).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.ToTable("UserType");

            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

            entity.Property(e => e.AdHocApprovalRoutes).HasDefaultValueSql("((0))");

            entity.Property(e => e.AdjustTimesheets).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendAddress).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendDelegates).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendDepartments).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendInvoices).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendNominalDescriptions).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendPostedRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendPostedSalesOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendProposedPayments).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendReports).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendSubmittedTimesheets).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendSystemSettings).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendTemplates).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendUserHolidayRules).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendUserNominalCodes).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendUserOrderTemplates).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendUserProjects).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendUserTypes).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendUserWarehouses).HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendWapprojects)
                .HasColumnName("AmendWAPProjects")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.AmendWorkPatterns).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApicanCreateNewCustomer)
                .HasColumnName("APICanCreateNewCustomer")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ApicanCreateNewExpenseSupplier)
                .HasColumnName("APICanCreateNewExpenseSupplier")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ApicanCreateNewStockItem)
                .HasColumnName("APICanCreateNewStockItem")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ApicanCreateNewSupplier)
                .HasColumnName("APICanCreateNewSupplier")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproveAbsences).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproveCustomers).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproveExpenseSuppliers).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproveExpenses).HasDefaultValueSql("((1))");

            entity.Property(e => e.ApproveHolidayRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproveProposedPayments).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproveRequisitions).HasDefaultValueSql("((1))");

            entity.Property(e => e.ApproveSalesOrders).HasDefaultValueSql("((1))");

            entity.Property(e => e.ApproveStockItems).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproveSuppliers).HasDefaultValueSql("((0))");

            entity.Property(e => e.ApproveTimesheets).HasDefaultValueSql("((1))");

            entity.Property(e => e.ArchiveRequests).HasDefaultValueSql("((1))");

            entity.Property(e => e.ArchiveSalesOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.AuthorisationRoute).HasDefaultValueSql("((0))");

            entity.Property(e => e.Authorise).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanConfirmFinalReceipt).HasDefaultValueSql("((1))");

            entity.Property(e => e.CanCreateJcjobs).HasColumnName("CanCreateJCJobs");

            entity.Property(e => e.CanDeleteAbsences).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanDeleteAllTemplates).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanEditApprovalHoldReasonsExpenses).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanEditApprovalHoldReasonsInvoices).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanEditEmploymentStartDate).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanEditJcjobAnalysisCodes).HasColumnName("CanEditJCJobAnalysisCodes");

            entity.Property(e => e.CanEditJcjobCustomFields).HasColumnName("CanEditJCJobCustomFields");

            entity.Property(e => e.CanEditJcjobs).HasColumnName("CanEditJCJobs");

            entity.Property(e => e.CanEditJcmemos).HasColumnName("CanEditJCMemos");

            entity.Property(e => e.CanEnterProjectRequisitionComments).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanImportCreditCardStatements).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanImportOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanMaintainCreditCards).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanMaintainVehicles).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanPerformYearEnd).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanPrintQuoteRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanSendEmail).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanUseJcoperations)
                .HasColumnName("CanUseJCOperations")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.CanViewAbsenceReports).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanViewAllAbsences).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanViewAllJcjobs).HasColumnName("CanViewAllJCJobs");

            entity.Property(e => e.CanViewBusinessUnitAbsences).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanViewDashboard).HasDefaultValueSql("((1))");

            entity.Property(e => e.CanViewJcjobCustomFields)
                .IsRequired()
                .HasColumnName("CanViewJCJobCustomFields")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.CanViewProjectRequisitionComments).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanViewProjectRequisitionReports).HasDefaultValueSql("((0))");

            entity.Property(e => e.CanViewSubContractorPos).HasColumnName("CanViewSubContractorPOs");

            entity.Property(e => e.CancelPostedOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.ChangeExpenseNominal).HasDefaultValueSql("((0))");

            entity.Property(e => e.ClearIpaddressLockouts)
                .HasColumnName("ClearIPAddressLockouts")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ConfirmGoodsReceived).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteAttachFromCompletedDocs).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteCustomerRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteExpenses).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteInvoices).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteProposedPayments).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteSalesOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteStockItemRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteSupplierRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeleteTimesheets).HasDefaultValueSql("((0))");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.EditProjectTimeEntry).HasDefaultValueSql("((0))");

            entity.Property(e => e.EditTimesheetsDuringApproval).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnableFailedDocumentsCommands).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnquiriesCostingAllocationReports).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnquiriesJobCosting).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnterAbsences).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnterAbsencesForAll).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnterAbsencesForBusinessUnit).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnterAbsencesForDelegates).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnterExpenses).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnterHolidayForAll).HasDefaultValueSql("((0))");

            entity.Property(e => e.EnterHolidayForDelegates).HasDefaultValueSql("((0))");

            entity.Property(e => e.ExpensesSelectTaxRate).HasDefaultValueSql("((1))");

            entity.Property(e => e.ExpensesViewReports).HasDefaultValueSql("((0))");

            entity.Property(e => e.GenerateTemplates).HasDefaultValueSql("((0))");

            entity.Property(e => e.HolStartingHoliday).HasDefaultValueSql("((0))");

            entity.Property(e => e.Hradmin)
                .HasColumnName("HRAdmin")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.HrdeleteCourses)
                .HasColumnName("HRDeleteCourses")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.HrdeleteDocuments)
                .HasColumnName("HRDeleteDocuments")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.HreditBankDetails)
                .HasColumnName("HREditBankDetails")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.HreditCourses)
                .HasColumnName("HREditCourses")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.HreditDocuments)
                .HasColumnName("HREditDocuments")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.HrnotifyEmployeeChanges)
                .HasColumnName("HRNotifyEmployeeChanges")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.InvoiceNotesPermission).HasDefaultValueSql("((0))");

            entity.Property(e => e.LockTimesheetWeeks).HasDefaultValueSql("((0))");

            entity.Property(e => e.MaintainUserRoles).HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileNewTimesheet).HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileNewTimesheetOthers).HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileTsdecimalEntry)
                .HasColumnName("MobileTSDecimalEntry")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.MobileUser).HasDefaultValueSql("((0))");

            entity.Property(e => e.PerformToilmonthEnd)
                .HasColumnName("PerformTOILMonthEnd")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.PostSalesOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.PostToSage).HasDefaultValueSql("((0))");

            entity.Property(e => e.PrintRequests).HasDefaultValueSql("((1))");

            entity.Property(e => e.PrintSalesOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.ProcessPayrollExpenses).HasDefaultValueSql("((0))");

            entity.Property(e => e.RecordPoinvoices).HasColumnName("RecordPOInvoices");

            entity.Property(e => e.RequisitionBatchNominalReplace).HasDefaultValueSql("((0))");

            entity.Property(e => e.RequisitionHideSupplierPricing).HasDefaultValueSql("((0))");

            entity.Property(e => e.RequisitionOutOfHours).HasDefaultValueSql("((0))");

            entity.Property(e => e.RequisitionReportAllOrderLines).HasDefaultValueSql("((1))");

            entity.Property(e => e.RequisitionReportGoni)
                .HasColumnName("RequisitionReportGONI")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.RequisitionReportGrhistory).HasColumnName("RequisitionReportGRHistory");

            entity.Property(e => e.RequisitionReportGrni)
                .HasColumnName("RequisitionReportGRNI")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.RequisitionReportLegacyAllOrderLines).HasDefaultValueSql("((1))");

            entity.Property(e => e.RequisitionReportLegacyApprovedOrders).HasDefaultValueSql("((1))");

            entity.Property(e => e.ResetUserPasswords).HasDefaultValueSql("((0))");

            entity.Property(e => e.SalesOrderGoodsDespatched).HasDefaultValueSql("((0))");

            entity.Property(e => e.SalesOrderNewCustomer).HasDefaultValueSql("((0))");

            entity.Property(e => e.SalesOrderNewQuote).HasDefaultValueSql("((0))");

            entity.Property(e => e.SalesOrderViewReports).HasDefaultValueSql("((0))");

            entity.Property(e => e.SopcanApproveQuote)
                .HasColumnName("SOPCanApproveQuote")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SopcanApproveReturn)
                .HasColumnName("SOPCanApproveReturn")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SopcanConvertQuote)
                .HasColumnName("SOPCanConvertQuote")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SopcanSubmitReturn)
                .HasColumnName("SOPCanSubmitReturn")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SopcanViewAllQuotes)
                .HasColumnName("SOPCanViewAllQuotes")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SopcanViewAllReturns)
                .HasColumnName("SOPCanViewAllReturns")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.SopstockBatchEntry).HasColumnName("SOPStockBatchEntry");

            entity.Property(e => e.SubmitHolidayRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmitRequest).HasDefaultValueSql("((0))");

            entity.Property(e => e.SubmitSubContractorPos).HasColumnName("SubmitSubContractorPOs");

            entity.Property(e => e.SwitchDelegates).HasDefaultValueSql("((1))");

            entity.Property(e => e.SystemAccount).HasDefaultValueSql("((0))");

            entity.Property(e => e.TahideFromCurrentActivity)
                .HasColumnName("TAHideFromCurrentActivity")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.TarequireSignIn)
                .HasColumnName("TARequireSignIn")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.TimesheetAddResources).HasDefaultValueSql("((0))");

            entity.Property(e => e.TimesheetCopyToTeam).HasDefaultValueSql("((0))");

            entity.Property(e => e.TimesheetNotRequired).HasDefaultValueSql("((0))");

            entity.Property(e => e.TimesheetReportByWeekAndUser).HasDefaultValueSql("((1))");

            entity.Property(e => e.TimesheetReportFlexi).HasDefaultValueSql("((1))");

            entity.Property(e => e.TimesheetReportLoginActivity).HasDefaultValueSql("((1))");

            entity.Property(e => e.TimesheetReportTimesheetLines).HasDefaultValueSql("((1))");

            entity.Property(e => e.TimesheetReportToilandOvertime)
                .HasColumnName("TimesheetReportTOILAndOvertime")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.TimesheetReportUnsubmitted).HasDefaultValueSql("((1))");

            entity.Property(e => e.TscanResetWaitingLines)
                .HasColumnName("TSCanResetWaitingLines")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.UpdateWorksOrdersFromTadashboard)
                .HasColumnName("UpdateWorksOrdersFromTADashboard")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ViewAllCustomerRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewAllHolidayRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewAllInvoices).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewAllOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewAllSalesOrders).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewAllStockItemRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewAllSupplierRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewAllTimesheets).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewClockedInUsers).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewCostToComplete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewDepartmentHolidayRequests).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewDepartmentTimesheets).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewEventLog).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewHolidayReport).HasDefaultValueSql("((0))");

            entity.Property(e => e.ViewRequests).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<UserTypeSystemSetting>(entity =>
        {
            entity.Property(e => e.UserTypeSystemSettingId).HasColumnName("UserTypeSystemSettingID");

            entity.Property(e => e.SettingId).HasColumnName("SettingID");

            entity.Property(e => e.SettingValue)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");
        });

        modelBuilder.Entity<UserVehicle>(entity =>
        {
            entity.ToTable("UserVehicle");

            entity.Property(e => e.UserVehicleId).HasColumnName("UserVehicleID");

            entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
        });

        modelBuilder.Entity<UserWarehouse>(entity =>
        {
            entity.ToTable("UserWarehouse");

            entity.Property(e => e.UserWarehouseId).HasColumnName("UserWarehouseID");

            entity.Property(e => e.AvailableForGoodsReceived).HasDefaultValueSql("((0))");

            entity.Property(e => e.AvailableForRequisitionSelection).HasDefaultValueSql("((0))");

            entity.Property(e => e.AvailableForSalesOrderSelection).HasDefaultValueSql("((0))");

            entity.Property(e => e.DefaultForGoodsReceived).HasDefaultValueSql("((0))");

            entity.Property(e => e.DefaultForRequisition).HasDefaultValueSql("((0))");

            entity.Property(e => e.DefaultForSalesOrder).HasDefaultValueSql("((0))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.SageDatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.Property(e => e.WarehouseName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserWeeklyContractedHour>(entity =>
        {
            entity.HasKey(e => e.UserWeeklyContractedHoursId);

            entity.Property(e => e.UserWeeklyContractedHoursId).HasColumnName("UserWeeklyContractedHoursID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.OvertimeHours2StartsAt).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OvertimeHours3StartsAt).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.OvertimeHoursStartsAt).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.WeeklyContractedHours).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<UserWorkPatternPayRate>(entity =>
        {
            entity.ToTable("UserWorkPatternPayRate");

            entity.Property(e => e.UserWorkPatternPayRateId).HasColumnName("UserWorkPatternPayRateID");

            entity.Property(e => e.ChargeRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.CostRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.ForeignChargeRateId).HasColumnName("ForeignChargeRateID");

            entity.Property(e => e.ForeignCostRateId).HasColumnName("ForeignCostRateID");

            entity.Property(e => e.ForeignPayRateId).HasColumnName("ForeignPayRateID");

            entity.Property(e => e.PayElementReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PayRate).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.WorkPatternPayRateId).HasColumnName("WorkPatternPayRateID");
        });

        modelBuilder.Entity<VNoDuplicateDoNo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("vNoDuplicateDoNos");

            entity.Property(e => e.PodocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PODocumentNo");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");
        });

        modelBuilder.Entity<ValueBand>(entity =>
        {
            entity.ToTable("ValueBand");

            entity.Property(e => e.ValueBandId).HasColumnName("ValueBandID");

            entity.Property(e => e.BandEnd).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.BandStart).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.ToTable("Vehicle");

            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

            entity.Property(e => e.AssetNumberReference)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BusinessMileage)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.CompanyPrivate)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DeliveryMileage)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.EngineCapacity)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FuelRateId).HasColumnName("FuelRateID");

            entity.Property(e => e.FuelType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InService).HasDefaultValueSql("((1))");

            entity.Property(e => e.PersonalMileage)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Registration)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Domain.Models.Version>(entity =>
        {
            entity.ToTable("Version");

            entity.Property(e => e.VersionId).HasColumnName("VersionID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.VersionNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Wapproject>(entity =>
        {
            entity.ToTable("WAPProject");

            entity.Property(e => e.WapprojectId).HasColumnName("WAPProjectID");

            entity.Property(e => e.AnalysisCode1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode10)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode11)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode12)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode13)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode14)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode15)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode16)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode17)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode18)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode19)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode2)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode20)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode4)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode5)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode6)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode7)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode8)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.AnalysisCode9)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WapprojectItem>(entity =>
        {
            entity.ToTable("WAPProjectItem");

            entity.Property(e => e.WapprojectItemId).HasColumnName("WAPProjectItemID");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WapprojectItemTypeId).HasColumnName("WAPProjectItemTypeID");
        });

        modelBuilder.Entity<WapprojectItemType>(entity =>
        {
            entity.ToTable("WAPProjectItemType");

            entity.Property(e => e.WapprojectItemTypeId).HasColumnName("WAPProjectItemTypeID");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WapprojectItemTypeDocumentType>(entity =>
        {
            entity.ToTable("WAPProjectItemTypeDocumentType");

            entity.Property(e => e.WapprojectItemTypeDocumentTypeId).HasColumnName("WAPProjectItemTypeDocumentTypeID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WapprojectItemTypeId).HasColumnName("WAPProjectItemTypeID");
        });

        modelBuilder.Entity<Wapqueue>(entity =>
        {
            entity.ToTable("WAPQueue");

            entity.Property(e => e.WapqueueId).HasColumnName("WAPQueueID");

            entity.Property(e => e.ActionType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ApproverId).HasColumnName("ApproverID");

            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ForeignChildId).HasColumnName("ForeignChildID");

            entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Waptask>(entity =>
        {
            entity.ToTable("WAPTask");

            entity.Property(e => e.WaptaskId).HasColumnName("WAPTaskID");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

            entity.Property(e => e.CostHeaderId).HasColumnName("CostHeaderID");

            entity.Property(e => e.CostItemId).HasColumnName("CostItemID");

            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.DocumentSubType)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DocumentTypeFriendly)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.ForeignChildId).HasColumnName("ForeignChildID");

            entity.Property(e => e.ForeignId).HasColumnName("ForeignID");

            entity.Property(e => e.ForeignParentId).HasColumnName("ForeignParentID");

            entity.Property(e => e.Notes)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.PhaseId).HasColumnName("PhaseID");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.StageId).HasColumnName("StageID");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<WarehouseNominalAccount>(entity =>
        {
            entity.ToTable("WarehouseNominalAccount");

            entity.Property(e => e.WarehouseNominalAccountId).HasColumnName("WarehouseNominalAccountID");

            entity.Property(e => e.CostCentreCode)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.CostCentreId).HasColumnName("CostCentreID");

            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

            entity.Property(e => e.OverrideCostCentre).HasDefaultValueSql("((1))");

            entity.Property(e => e.OverrideDepartment).HasDefaultValueSql("((1))");

            entity.Property(e => e.SageDatabaseId).HasColumnName("SageDatabaseID");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.Property(e => e.WarehouseName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkPattern>(entity =>
        {
            entity.ToTable("WorkPattern");

            entity.Property(e => e.WorkPatternId).HasColumnName("WorkPatternID");

            entity.Property(e => e.BreakAmount)
                .HasColumnType("decimal(18, 5)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.DeductX)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DefaultWorkPattern).HasDefaultValueSql("((0))");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.LoginRoundUpAllowance)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LoginRoundUpX)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LogoutRoundDownAllowance)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LogoutRoundDownX)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MoreThanXlate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MoreThanXLate");

            entity.Property(e => e.RoundDeduct)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WorkPatternName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.WorkPatternRuleId).HasColumnName("WorkPatternRuleID");

            entity.Property(e => e.WorkPatternType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkPatternDay>(entity =>
        {
            entity.ToTable("WorkPatternDay");

            entity.Property(e => e.WorkPatternDayId).HasColumnName("WorkPatternDayID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WorkPatternShiftId).HasColumnName("WorkPatternShiftID");
        });

        modelBuilder.Entity<WorkPatternDayShift>(entity =>
        {
            entity.ToTable("WorkPatternDayShift");

            entity.Property(e => e.WorkPatternDayShiftId).HasColumnName("WorkPatternDayShiftID");

            entity.Property(e => e.DayShiftType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Duration).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.NonWorking).HasDefaultValueSql("((0))");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WorkPatternDayId).HasColumnName("WorkPatternDayID");

            entity.Property(e => e.WorkPatternPayRateId).HasColumnName("WorkPatternPayRateID");
        });

        modelBuilder.Entity<WorkPatternPayRate>(entity =>
        {
            entity.ToTable("WorkPatternPayRate");

            entity.Property(e => e.WorkPatternPayRateId).HasColumnName("WorkPatternPayRateID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.PayRateName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkPatternRule>(entity =>
        {
            entity.ToTable("WorkPatternRule");

            entity.Property(e => e.WorkPatternRuleId).HasColumnName("WorkPatternRuleID");

            entity.Property(e => e.BreakAmount).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.HoursBeforeBreak).HasColumnType("decimal(18, 5)");

            entity.Property(e => e.Rate1Id).HasColumnName("Rate1ID");

            entity.Property(e => e.Rate1Label)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Rate2Id).HasColumnName("Rate2ID");

            entity.Property(e => e.Rate2Label)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Rate3Id).HasColumnName("Rate3ID");

            entity.Property(e => e.Rate3Label)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Rate4Id).HasColumnName("Rate4ID");

            entity.Property(e => e.Rate4Label)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WorkPatternRuleName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkPatternShift>(entity =>
        {
            entity.ToTable("WorkPatternShift");

            entity.Property(e => e.WorkPatternShiftId).HasColumnName("WorkPatternShiftID");

            entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.Property(e => e.UpdatedUser)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WorkPatternId).HasColumnName("WorkPatternID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
