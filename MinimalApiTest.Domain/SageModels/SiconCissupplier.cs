using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCissupplier
    {
        public long SiconCissupplierId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public bool? IsSubcontractor { get; set; }
        public long? RateSiBespokeTypeId { get; set; }
        public string? Utr { get; set; }
        public string? VerificationNo { get; set; }
        public string? Nino { get; set; }
        public string? Crn { get; set; }
        public string? ContEmpRefNo { get; set; }
        public DateTime? ContVerficationDate { get; set; }
        public DateTime? ContOriginalVerficationDate { get; set; }
        public bool? IsLabourOnly { get; set; }
        public decimal? DefaultLabourPercentage { get; set; }
        public DateTime? LastReturnDate { get; set; }
        public string? TraderType { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? Surname { get; set; }
        public string? PartnershipUtr { get; set; }
        public string? PublicLiabilityInsuranceNumber { get; set; }
        public DateTime? CurrentPeriodExpiryDate { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public DateTime? SpareDateTime1 { get; set; }
        public DateTime? SpareDateTime2 { get; set; }
        public DateTime? SpareDateTime3 { get; set; }
        public DateTime? SpareDateTime4 { get; set; }
        public DateTime? SpareDateTime5 { get; set; }
        public string? SpareMemo1 { get; set; }
        public string? CisuploadedRequestFileName { get; set; }
        public string? CisuploadedResponseFileName { get; set; }
        public string? CishmrcresponseText { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? SubcontractorScheme { get; set; }
        public string? RateDescription { get; set; }
        public string? Title { get; set; }
        public string? Suffix { get; set; }
        public string? EmployerInsuranceNumber { get; set; }
        public DateTime? EmployerExpiryDate { get; set; }
        public bool? SubHasFixedPlaceOfBusiness { get; set; }
    }
}
