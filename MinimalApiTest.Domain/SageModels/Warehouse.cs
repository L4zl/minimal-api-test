using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            PoporderReturnArches = new HashSet<PoporderReturnArch>();
            PoporderReturnLineArches = new HashSet<PoporderReturnLineArch>();
            PoporderReturnLines = new HashSet<PoporderReturnLine>();
            PoporderReturns = new HashSet<PoporderReturn>();
            PoprequisitionFulfilmentLines = new HashSet<PoprequisitionFulfilmentLine>();
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
            Stocktakes = new HashSet<Stocktake>();
            UserDefaultWarehouses = new HashSet<UserDefaultWarehouse>();
            WarehouseItems = new HashSet<WarehouseItem>();
        }

        public long WarehouseId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool UseForSalesTrading { get; set; }
        public string PostalName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string AddressLine2 { get; set; } = null!;
        public string AddressLine3 { get; set; } = null!;
        public string AddressLine4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string TelephoneNo { get; set; } = null!;
        public string FaxNo { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string WebAddress { get; set; } = null!;
        public DateTime? LastCompletedStocktake { get; set; }
        public long? CountryCodeId { get; set; }
        public long WarehouseTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public string City { get; set; } = null!;
        public string County { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SyscountryCode? CountryCode { get; set; }
        public virtual WarehouseType WarehouseType { get; set; } = null!;
        public virtual ICollection<PoporderReturnArch> PoporderReturnArches { get; set; }
        public virtual ICollection<PoporderReturnLineArch> PoporderReturnLineArches { get; set; }
        public virtual ICollection<PoporderReturnLine> PoporderReturnLines { get; set; }
        public virtual ICollection<PoporderReturn> PoporderReturns { get; set; }
        public virtual ICollection<PoprequisitionFulfilmentLine> PoprequisitionFulfilmentLines { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
        public virtual ICollection<Stocktake> Stocktakes { get; set; }
        public virtual ICollection<UserDefaultWarehouse> UserDefaultWarehouses { get; set; }
        public virtual ICollection<WarehouseItem> WarehouseItems { get; set; }
    }
}
