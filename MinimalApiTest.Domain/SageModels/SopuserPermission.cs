using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopuserPermission
    {
        public SopuserPermission()
        {
            UserDefaultWarehouses = new HashSet<UserDefaultWarehouse>();
        }

        public long SopuserPermissionId { get; set; }
        public long SopuserId { get; set; }
        public bool OverridePricesDiscounts { get; set; }
        public bool ViewProfitValues { get; set; }
        public bool ViewPriceCalculations { get; set; }
        public bool OverrideCreditHolds { get; set; }
        public bool OverrideFulfilmentMethod { get; set; }
        public bool OverrideConfirmationMethod { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool OverrideCostPrice { get; set; }
        public bool GeneratePurchaseOrders { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Sopuser Sopuser { get; set; } = null!;
        public virtual ICollection<UserDefaultWarehouse> UserDefaultWarehouses { get; set; }
    }
}
