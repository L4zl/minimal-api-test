using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFaemployee
    {
        public long EmployeeId { get; set; }
        public string EmployeeNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Department { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string JobTitle { get; set; } = null!;
        public bool Removed { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
