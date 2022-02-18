namespace MinimalApiTest.Application.Contracts.Timesheets;

public class TimesheetSummaryResponse
{
    public string SageDatabaseId { get; set; } = null!;
    public long SiconTimesheetId { get; set; }
    public DateTime? WeekStartDate { get; set; }
    public int CalendarWeekNumber { get; set; }
    public int FinancialWeekNumber { get; set; }
    public long? SiconEmployeeId { get; set; }
    public long? SiconTimesheetStatusId { get; set; }
    public string Notes { get; set; } = null!;
    public DateTime? FullyApprovedDate { get; set; }
    public string? UpdateStatus { get; set; }
    public bool Deleted { get; set; }
    public string LastUpdatedByUserId { get; set; } = null!;
    public DateTime? LastUpdatedDateTime { get; set; }
}

