using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CrmintegrationSetting
    {
        public long CrmintegrationSettingId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool DisplayProfitabilityInCrm { get; set; }
        public long CrmintegrationTypeId { get; set; }
        public long CrmintegrationSyncDateTypeId { get; set; }
        public DateTime? CrmintegrationSyncDate { get; set; }
        public string CrmmetaDataVersion { get; set; } = null!;
        public bool CheckCrmforDelete { get; set; }
        public string CrmwebServiceUrl { get; set; } = null!;
        public string Crmusername { get; set; } = null!;
        public string Crmpassword { get; set; } = null!;
        public int SyncStatus { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long CrmconfigurationTypeId { get; set; }
        public string CrmenbugatewayUrl { get; set; } = null!;

        public virtual CrmconfigurationType CrmconfigurationType { get; set; } = null!;
        public virtual CrmintegrationSyncDateType CrmintegrationSyncDateType { get; set; } = null!;
        public virtual CrmintegrationType CrmintegrationType { get; set; } = null!;
    }
}
