using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscountryCode
    {
        public SyscountryCode()
        {
            CustDeliveryAddressAddressCountryCodes = new HashSet<CustDeliveryAddress>();
            CustDeliveryAddressCountryCodes = new HashSet<CustDeliveryAddress>();
            ModeOfTransports = new HashSet<ModeOfTransport>();
            NatureOfTransCodes = new HashSet<NatureOfTransCode>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
            PlsupplierLocationAddressCountries = new HashSet<PlsupplierLocation>();
            PlsupplierLocationSyscountryCodes = new HashSet<PlsupplierLocation>();
            PopdocDelAddressArches = new HashSet<PopdocDelAddressArch>();
            PopdocDelAddresses = new HashSet<PopdocDelAddress>();
            PopordReturnLineDelAddrArches = new HashSet<PopordReturnLineDelAddrArch>();
            PopordReturnLineDelAddresses = new HashSet<PopordReturnLineDelAddress>();
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            SlcustomerLocationAddressCountries = new HashSet<SlcustomerLocation>();
            SlcustomerLocationSyscountryCodes = new HashSet<SlcustomerLocation>();
            SopdocDelAddressArches = new HashSet<SopdocDelAddressArch>();
            SopdocDelAddresses = new HashSet<SopdocDelAddress>();
            StockItemSuppliers = new HashSet<StockItemSupplier>();
            StockItems = new HashSet<StockItem>();
            SyscompanyLocations = new HashSet<SyscompanyLocation>();
            SyscountryCodeTaxMasks = new HashSet<SyscountryCodeTaxMask>();
            TemstandardTaxCodes = new HashSet<TemstandardTaxCode>();
            TermsOfDeliveries = new HashSet<TermsOfDelivery>();
            Warehouses = new HashSet<Warehouse>();
        }

        public long SyscountryCodeId { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? CompanyTaxRegistrationNumber { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool Eu { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string Code3 { get; set; } = null!;

        public virtual ICollection<CustDeliveryAddress> CustDeliveryAddressAddressCountryCodes { get; set; }
        public virtual ICollection<CustDeliveryAddress> CustDeliveryAddressCountryCodes { get; set; }
        public virtual ICollection<ModeOfTransport> ModeOfTransports { get; set; }
        public virtual ICollection<NatureOfTransCode> NatureOfTransCodes { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
        public virtual ICollection<PlsupplierLocation> PlsupplierLocationAddressCountries { get; set; }
        public virtual ICollection<PlsupplierLocation> PlsupplierLocationSyscountryCodes { get; set; }
        public virtual ICollection<PopdocDelAddressArch> PopdocDelAddressArches { get; set; }
        public virtual ICollection<PopdocDelAddress> PopdocDelAddresses { get; set; }
        public virtual ICollection<PopordReturnLineDelAddrArch> PopordReturnLineDelAddrArches { get; set; }
        public virtual ICollection<PopordReturnLineDelAddress> PopordReturnLineDelAddresses { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<SlcustomerLocation> SlcustomerLocationAddressCountries { get; set; }
        public virtual ICollection<SlcustomerLocation> SlcustomerLocationSyscountryCodes { get; set; }
        public virtual ICollection<SopdocDelAddressArch> SopdocDelAddressArches { get; set; }
        public virtual ICollection<SopdocDelAddress> SopdocDelAddresses { get; set; }
        public virtual ICollection<StockItemSupplier> StockItemSuppliers { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<SyscompanyLocation> SyscompanyLocations { get; set; }
        public virtual ICollection<SyscountryCodeTaxMask> SyscountryCodeTaxMasks { get; set; }
        public virtual ICollection<TemstandardTaxCode> TemstandardTaxCodes { get; set; }
        public virtual ICollection<TermsOfDelivery> TermsOfDeliveries { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
