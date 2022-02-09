namespace MinimalApiTest.Domain.Models
{
    public partial class SalesOrderCrmdetail
    {
        public long SalesOrderCrmdetailId { get; set; }
        public long? SalesOrderId { get; set; }
        public long? CrmuserCreatedById { get; set; }
        public long? ChannelId { get; set; }
        public long? CompanyId { get; set; }
        public long? CaseId { get; set; }
        public long? PersonId { get; set; }
        public long? OpportunityId { get; set; }
        public long? CommunicationId { get; set; }
        public long? LeadId { get; set; }
        public long? ProjectId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
