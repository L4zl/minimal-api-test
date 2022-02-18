using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmssupplier
    {
        public long SiconDmssupplierId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public long ApplicationId { get; set; }
        public long SupplierId { get; set; }
        public bool Enabled { get; set; }
        public bool? OrderNumberMatching { get; set; }
        public bool? JobNumberMatching { get; set; }
        public bool? ItemLineExtraction { get; set; }
        public bool? Pogrnvalidation { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public string VatCodeZeroVatInvoices { get; set; } = null!;
        public bool? SecondReferenceValidation { get; set; }
        public bool Ftenabled { get; set; }
        public string Ftname { get; set; } = null!;
        public string Ftname2 { get; set; } = null!;
        public string Ftstreet { get; set; } = null!;
        public string Ftzip { get; set; } = null!;
        public string Ftcity { get; set; } = null!;
        public string FtcountryCode { get; set; } = null!;
        public string FtvatNo { get; set; } = null!;
        public string FtorgNo { get; set; } = null!;
        public string Ftpob { get; set; } = null!;
        public string Ftphone { get; set; } = null!;
        public string Ftfax { get; set; } = null!;
        public string Ftwww { get; set; } = null!;
        public string Ftemail { get; set; } = null!;
        public string Ftbankgiro { get; set; } = null!;
        public string Ftplusgiro { get; set; } = null!;
        public string Ftaccount { get; set; } = null!;
        public string Ftiban { get; set; } = null!;
        public string Ftswift { get; set; } = null!;
        public string Ftgln { get; set; } = null!;
        public string Ftslogan { get; set; } = null!;
        public string Ftcustom1 { get; set; } = null!;
        public string Ftcustom2 { get; set; } = null!;
        public string Ftcustom3 { get; set; } = null!;
        public string FtpobZip { get; set; } = null!;
        public bool? ReceiveInvoiceImagesOnly { get; set; }
    }
}
