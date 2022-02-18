using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Tsperson
    {
        public Tsperson()
        {
            PcprojectUserProfiles = new HashSet<PcprojectUserProfile>();
            TsauthGroupAuthorisers = new HashSet<TsauthGroupAuthoriser>();
            TsauthGroupMembers = new HashSet<TsauthGroupMember>();
            TsclaimSheets = new HashSet<TsclaimSheet>();
            TshumanResources = new HashSet<TshumanResource>();
            TsresourceHierarchyPeople = new HashSet<TsresourceHierarchyPerson>();
            TstimeRecords = new HashSet<TstimeRecord>();
            TsuserProfiles = new HashSet<TsuserProfile>();
        }

        public long TspersonId { get; set; }
        public string Title { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleNames { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string MobileNumber { get; set; } = null!;
        public string Ninumber { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string FileAsName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string TelephoneNumber { get; set; } = null!;
        public string FaxNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PcprojectUserProfile> PcprojectUserProfiles { get; set; }
        public virtual ICollection<TsauthGroupAuthoriser> TsauthGroupAuthorisers { get; set; }
        public virtual ICollection<TsauthGroupMember> TsauthGroupMembers { get; set; }
        public virtual ICollection<TsclaimSheet> TsclaimSheets { get; set; }
        public virtual ICollection<TshumanResource> TshumanResources { get; set; }
        public virtual ICollection<TsresourceHierarchyPerson> TsresourceHierarchyPeople { get; set; }
        public virtual ICollection<TstimeRecord> TstimeRecords { get; set; }
        public virtual ICollection<TsuserProfile> TsuserProfiles { get; set; }
    }
}
