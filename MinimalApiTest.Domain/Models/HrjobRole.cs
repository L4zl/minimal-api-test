namespace MinimalApiTest.Domain.Models
{
    public partial class HrjobRole
    {
        public long HrjobRoleId { get; set; }
        public long? UserId { get; set; }
        public long? JobRoleId { get; set; }
        public long? DepartmentId { get; set; }
        public long? RoleToReportTo { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal? YearlySalary { get; set; }
        public bool? IsCurrent { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsFullTime { get; set; }
        public decimal? ContractedHours { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string? NoticePeriod { get; set; }
        public string? NoticeDetails { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? ManagerInductionDate { get; set; }
        public DateTime? CompanyInductionDate { get; set; }
        public DateTime? ProbationDueDate { get; set; }
        public DateTime? ProbationReviewDate { get; set; }
        public bool? ProbationSuccessful { get; set; }
        public string? ProbationNotes { get; set; }
        public string? ContractType { get; set; }
        public string? Location { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public bool? RestrictiveCovenant { get; set; }
        public string? RestrictiveCovenantComments { get; set; }
        public bool? SecondaryContract { get; set; }
        public string? Notes { get; set; }
    }
}
