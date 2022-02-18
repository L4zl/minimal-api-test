using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ReportSession
    {
        public ReportSession()
        {
            ReportBomComparisonItems = new HashSet<ReportBomComparisonItem>();
            ReportBomComparisonResults = new HashSet<ReportBomComparisonResult>();
            ReportBomImplosionItems = new HashSet<ReportBomImplosionItem>();
            ReportBomImplosionResults = new HashSet<ReportBomImplosionResult>();
            ReportExplosionResults = new HashSet<ReportExplosionResult>();
            ReportExplosionSettings = new HashSet<ReportExplosionSetting>();
            ReportMaximumBuildItems = new HashSet<ReportMaximumBuildItem>();
            ReportMaximumBuildResults = new HashSet<ReportMaximumBuildResult>();
            ReportMaximumBuildWarehouses = new HashSet<ReportMaximumBuildWarehouse>();
            ReportTrialKittingOptions = new HashSet<ReportTrialKittingOption>();
            ReportTrialKittingResults = new HashSet<ReportTrialKittingResult>();
            ReportTrialKittingTasks = new HashSet<ReportTrialKittingTask>();
            ReportTrialKittingWarehouses = new HashSet<ReportTrialKittingWarehouse>();
            ReportUndoAllocationComponents = new HashSet<ReportUndoAllocationComponent>();
            ReportUndoAllocationFinishedItems = new HashSet<ReportUndoAllocationFinishedItem>();
        }

        public long ReportSessionId { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
        public int ProcessId { get; set; }
        public int TerminalServicesSessionId { get; set; }
        public string SessionGuid { get; set; } = null!;

        public virtual ICollection<ReportBomComparisonItem> ReportBomComparisonItems { get; set; }
        public virtual ICollection<ReportBomComparisonResult> ReportBomComparisonResults { get; set; }
        public virtual ICollection<ReportBomImplosionItem> ReportBomImplosionItems { get; set; }
        public virtual ICollection<ReportBomImplosionResult> ReportBomImplosionResults { get; set; }
        public virtual ICollection<ReportExplosionResult> ReportExplosionResults { get; set; }
        public virtual ICollection<ReportExplosionSetting> ReportExplosionSettings { get; set; }
        public virtual ICollection<ReportMaximumBuildItem> ReportMaximumBuildItems { get; set; }
        public virtual ICollection<ReportMaximumBuildResult> ReportMaximumBuildResults { get; set; }
        public virtual ICollection<ReportMaximumBuildWarehouse> ReportMaximumBuildWarehouses { get; set; }
        public virtual ICollection<ReportTrialKittingOption> ReportTrialKittingOptions { get; set; }
        public virtual ICollection<ReportTrialKittingResult> ReportTrialKittingResults { get; set; }
        public virtual ICollection<ReportTrialKittingTask> ReportTrialKittingTasks { get; set; }
        public virtual ICollection<ReportTrialKittingWarehouse> ReportTrialKittingWarehouses { get; set; }
        public virtual ICollection<ReportUndoAllocationComponent> ReportUndoAllocationComponents { get; set; }
        public virtual ICollection<ReportUndoAllocationFinishedItem> ReportUndoAllocationFinishedItems { get; set; }
    }
}
