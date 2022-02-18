﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipment
    {
        public SiconEquipment()
        {
            SiconEquipmentCases = new HashSet<SiconEquipmentCase>();
        }

        public long SiconEquipmentId { get; set; }
        public long? ItemId { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public DateTime? WarrantyExpiryDate { get; set; }
        public DateTime? NextServiceDate { get; set; }
        public long? SiconSubLocationId { get; set; }
        public long? ItemTypeId { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string? Description { get; set; }
        public long? TraceableItemId { get; set; }
        public string? FreeTextSerialNumber { get; set; }
        public string? Idnumber { get; set; }
        public string? SpareText1 { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? SupplierName { get; set; }
        public DateTime? InstalledDate { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public int? ServiceIntervalDuration { get; set; }
        public string? ServiceIntervalMeasurement { get; set; }
        public long? OverrideSiSmslaid { get; set; }
        public long? SiconContractId { get; set; }
        public long? SiconContractLineId { get; set; }
        public long? AssociatedCustomer { get; set; }
        public string? AssociatedCustomerName { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public string? AnalysisCode6 { get; set; }
        public string? AnalysisCode7 { get; set; }
        public string? AnalysisCode8 { get; set; }
        public string? AnalysisCode9 { get; set; }
        public string? AnalysisCode10 { get; set; }
        public string? AnalysisCode11 { get; set; }
        public string? AnalysisCode12 { get; set; }
        public string? AnalysisCode13 { get; set; }
        public string? AnalysisCode14 { get; set; }
        public string? AnalysisCode15 { get; set; }
        public string? AnalysisCode16 { get; set; }
        public string? AnalysisCode17 { get; set; }
        public string? AnalysisCode18 { get; set; }
        public string? AnalysisCode19 { get; set; }
        public string? AnalysisCode20 { get; set; }
        public string? AnalysisCode21 { get; set; }
        public string? AnalysisCode22 { get; set; }
        public string? AnalysisCode23 { get; set; }
        public string? AnalysisCode24 { get; set; }
        public string? AnalysisCode25 { get; set; }
        public string? AnalysisCode26 { get; set; }
        public string? AnalysisCode27 { get; set; }
        public string? AnalysisCode28 { get; set; }
        public string? AnalysisCode29 { get; set; }
        public string? AnalysisCode30 { get; set; }
        public string? AnalysisCode31 { get; set; }
        public string? AnalysisCode32 { get; set; }
        public string? AnalysisCode33 { get; set; }
        public string? AnalysisCode34 { get; set; }
        public string? AnalysisCode35 { get; set; }
        public string? AnalysisCode36 { get; set; }
        public string? AnalysisCode37 { get; set; }
        public string? AnalysisCode38 { get; set; }
        public string? AnalysisCode39 { get; set; }
        public string? AnalysisCode40 { get; set; }
        public string? AnalysisCode41 { get; set; }
        public string? AnalysisCode42 { get; set; }
        public string? AnalysisCode43 { get; set; }
        public string? AnalysisCode44 { get; set; }
        public string? AnalysisCode45 { get; set; }
        public string? AnalysisCode46 { get; set; }
        public string? AnalysisCode47 { get; set; }
        public string? AnalysisCode48 { get; set; }
        public string? AnalysisCode49 { get; set; }
        public string? AnalysisCode50 { get; set; }
        public string? AnalysisCode51 { get; set; }
        public string? AnalysisCode52 { get; set; }
        public string? AnalysisCode53 { get; set; }
        public string? AnalysisCode54 { get; set; }
        public string? AnalysisCode55 { get; set; }
        public string? AnalysisCode56 { get; set; }
        public string? AnalysisCode57 { get; set; }
        public string? AnalysisCode58 { get; set; }
        public string? AnalysisCode59 { get; set; }
        public string? AnalysisCode60 { get; set; }
        public string? AnalysisCode61 { get; set; }
        public string? AnalysisCode62 { get; set; }
        public string? AnalysisCode63 { get; set; }
        public string? AnalysisCode64 { get; set; }
        public string? AnalysisCode65 { get; set; }
        public string? AnalysisCode66 { get; set; }
        public string? AnalysisCode67 { get; set; }
        public string? AnalysisCode68 { get; set; }
        public string? AnalysisCode69 { get; set; }
        public string? AnalysisCode70 { get; set; }
        public string? AnalysisCode71 { get; set; }
        public string? AnalysisCode72 { get; set; }
        public string? AnalysisCode73 { get; set; }
        public string? AnalysisCode74 { get; set; }
        public string? AnalysisCode75 { get; set; }
        public string? AnalysisCode76 { get; set; }
        public string? AnalysisCode77 { get; set; }
        public string? AnalysisCode78 { get; set; }
        public string? AnalysisCode79 { get; set; }
        public string? AnalysisCode80 { get; set; }
        public string? AnalysisCode81 { get; set; }
        public string? AnalysisCode82 { get; set; }
        public string? AnalysisCode83 { get; set; }
        public string? AnalysisCode84 { get; set; }
        public string? AnalysisCode85 { get; set; }
        public string? AnalysisCode86 { get; set; }
        public string? AnalysisCode87 { get; set; }
        public string? AnalysisCode88 { get; set; }
        public string? AnalysisCode89 { get; set; }
        public string? AnalysisCode90 { get; set; }
        public string? AnalysisCode91 { get; set; }
        public string? AnalysisCode92 { get; set; }
        public string? AnalysisCode93 { get; set; }
        public string? AnalysisCode94 { get; set; }
        public string? AnalysisCode95 { get; set; }
        public string? AnalysisCode96 { get; set; }
        public string? AnalysisCode97 { get; set; }
        public string? AnalysisCode98 { get; set; }
        public string? AnalysisCode99 { get; set; }
        public string? AnalysisCode100 { get; set; }
        public string? AnalysisCode101 { get; set; }
        public string? AnalysisCode102 { get; set; }
        public string? AnalysisCode103 { get; set; }
        public string? AnalysisCode104 { get; set; }
        public string? AnalysisCode105 { get; set; }
        public string? AnalysisCode106 { get; set; }
        public string? AnalysisCode107 { get; set; }
        public string? AnalysisCode108 { get; set; }
        public string? AnalysisCode109 { get; set; }
        public string? AnalysisCode110 { get; set; }
        public string? AnalysisCode111 { get; set; }
        public string? AnalysisCode112 { get; set; }
        public string? AnalysisCode113 { get; set; }
        public string? AnalysisCode114 { get; set; }
        public string? AnalysisCode115 { get; set; }
        public string? AnalysisCode116 { get; set; }
        public string? AnalysisCode117 { get; set; }
        public string? AnalysisCode118 { get; set; }
        public string? AnalysisCode119 { get; set; }
        public string? AnalysisCode120 { get; set; }
        public string? AnalysisCode121 { get; set; }
        public string? AnalysisCode122 { get; set; }
        public string? AnalysisCode123 { get; set; }
        public string? AnalysisCode124 { get; set; }
        public string? AnalysisCode125 { get; set; }
        public string? AnalysisCode126 { get; set; }
        public string? AnalysisCode127 { get; set; }
        public string? AnalysisCode128 { get; set; }
        public string? AnalysisCode129 { get; set; }
        public string? AnalysisCode130 { get; set; }
        public string? AnalysisCode131 { get; set; }
        public string? AnalysisCode132 { get; set; }
        public string? AnalysisCode133 { get; set; }
        public string? AnalysisCode134 { get; set; }
        public string? AnalysisCode135 { get; set; }
        public string? AnalysisCode136 { get; set; }
        public string? AnalysisCode137 { get; set; }
        public string? AnalysisCode138 { get; set; }
        public string? AnalysisCode139 { get; set; }
        public string? AnalysisCode140 { get; set; }
        public string? AnalysisCode141 { get; set; }
        public string? AnalysisCode142 { get; set; }
        public string? AnalysisCode143 { get; set; }
        public string? AnalysisCode144 { get; set; }
        public string? AnalysisCode145 { get; set; }
        public string? AnalysisCode146 { get; set; }
        public string? AnalysisCode147 { get; set; }
        public string? AnalysisCode148 { get; set; }
        public string? AnalysisCode149 { get; set; }
        public string? AnalysisCode150 { get; set; }
        public bool? Slaoverride { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public int? EquipmentStatus { get; set; }
        public long? BranchId { get; set; }
        public long? SiconFixedAssetId { get; set; }
        public long? ReplacementBinItemId { get; set; }
        public long? SiconEquipmentGroupId { get; set; }
        public long? CustomContact1 { get; set; }
        public long? CustomContact2 { get; set; }
        public long? CustomContact3 { get; set; }
        public long? CustomContact4 { get; set; }
        public long? CustomContact5 { get; set; }
        public long? CustomContact6 { get; set; }
        public long? CustomContact7 { get; set; }
        public long? CustomContact8 { get; set; }
        public long? CustomContact9 { get; set; }
        public long? CustomContact10 { get; set; }
        public long? SiSmserviceTemplateId { get; set; }
        public string? SopcaseCreationSeparator { get; set; }
        public long? SiconContactId { get; set; }
        public string? Notes { get; set; }
        public long? OwnerSiconContactPersonId { get; set; }
        public bool? UseMeterReadings { get; set; }
        public decimal? MeterReadingValue { get; set; }
        public long? SiconContractLineSupplierId { get; set; }
        public long? SiconCrmcompanyId { get; set; }
        public long? SiconCrmcompanyPersonId { get; set; }
        public long? SiconCrmendUserId { get; set; }
        public long? SiconCrmendUserPersonId { get; set; }

        public virtual ICollection<SiconEquipmentCase> SiconEquipmentCases { get; set; }
    }
}
