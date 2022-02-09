namespace MinimalApiTest.Domain.Models
{
    public partial class HremployeeDetail
    {
        public long HremployeeDetailId { get; set; }
        public string? Aka { get; set; }
        public long? UserId { get; set; }
        public string? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Ninumber { get; set; }
        public string? EmployeeNumber { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public string? EmailAddress { get; set; }
        public string? HomePhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? MedicalInfo { get; set; }
        public string? Ethnicity { get; set; }
        public string? Religion { get; set; }
        public byte[]? Photo { get; set; }
        public string? PreviousSurname { get; set; }
        public string? Dlnumber { get; set; }
        public string? Dlexpiry { get; set; }
        public bool? Disability { get; set; }
        public string? DisabilityNotes { get; set; }
        public long? CountryId { get; set; }
        public bool? RtwdocumentsReceived { get; set; }
        public string? VehicleRegNo { get; set; }
    }
}
