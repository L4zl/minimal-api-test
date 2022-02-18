﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmCostHeading
    {
        public MsmCostHeading()
        {
            BomCostSessionTotals = new HashSet<BomCostSessionTotal>();
            BomCosts = new HashSet<BomCost>();
            BomOperationSubcontractSuppliers = new HashSet<BomOperationSubcontractSupplier>();
            LabLabourResourceGroups = new HashSet<LabLabourResourceGroup>();
            LabLabourResources = new HashSet<LabLabourResource>();
            MachMachineResourceGroups = new HashSet<MachMachineResourceGroup>();
            MachMachineResources = new HashSet<MachMachineResource>();
            MseProductGroups = new HashSet<MseProductGroup>();
            MseStockItems = new HashSet<MseStockItem>();
            OpOperationSubcontractSuppliers = new HashSet<OpOperationSubcontractSupplier>();
            ToolToolingResourceGroups = new HashSet<ToolToolingResourceGroup>();
            ToolToolingResources = new HashSet<ToolToolingResource>();
        }

        /// <summary>
        /// Cost Heading Primary Key
        /// </summary>
        public long MsmCostHeadingId { get; set; }
        public long? MsmCostHeadingTypeId { get; set; }
        /// <summary>
        /// Cost Heading Name
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Primary Key for Nominal Account
        /// </summary>
        public long? NominalAccountId { get; set; }
        /// <summary>
        /// Nominal Account Number
        /// </summary>
        public string? NominalAccountNumber { get; set; }
        /// <summary>
        /// Nominal Cost Centre
        /// </summary>
        public string? NominalAccountCostCentre { get; set; }
        /// <summary>
        /// Nominal Department
        /// </summary>
        public string? NominalAccountDepartment { get; set; }
        public long? OverheadNominalAccountId { get; set; }
        public string? OverheadNominalAccountNumber { get; set; }
        public string? OverheadNominalAccountCostCentre { get; set; }
        public string? OverheadNominalAccountDepartment { get; set; }
        public decimal? Markup { get; set; }
        /// <summary>
        /// Overhead Recovery Percentage
        /// </summary>
        public decimal? OverheadRecoveryPercentage { get; set; }
        public bool? Reserved { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MsmCostHeadingType? MsmCostHeadingType { get; set; }
        public virtual ICollection<BomCostSessionTotal> BomCostSessionTotals { get; set; }
        public virtual ICollection<BomCost> BomCosts { get; set; }
        public virtual ICollection<BomOperationSubcontractSupplier> BomOperationSubcontractSuppliers { get; set; }
        public virtual ICollection<LabLabourResourceGroup> LabLabourResourceGroups { get; set; }
        public virtual ICollection<LabLabourResource> LabLabourResources { get; set; }
        public virtual ICollection<MachMachineResourceGroup> MachMachineResourceGroups { get; set; }
        public virtual ICollection<MachMachineResource> MachMachineResources { get; set; }
        public virtual ICollection<MseProductGroup> MseProductGroups { get; set; }
        public virtual ICollection<MseStockItem> MseStockItems { get; set; }
        public virtual ICollection<OpOperationSubcontractSupplier> OpOperationSubcontractSuppliers { get; set; }
        public virtual ICollection<ToolToolingResourceGroup> ToolToolingResourceGroups { get; set; }
        public virtual ICollection<ToolToolingResource> ToolToolingResources { get; set; }
    }
}
