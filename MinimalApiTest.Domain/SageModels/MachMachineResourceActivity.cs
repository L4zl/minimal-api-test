using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MachMachineResourceActivity
    {
        public long MachMachineResourceActivityId { get; set; }
        public long MachMachineResourceId { get; set; }
        public long MachMachineResourceActivityTypeId { get; set; }
        public string? Reference { get; set; }
        public DateTime ThisActivityDate { get; set; }
        public DateTime? NextActivityDate { get; set; }
        public bool Archived { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public string Result { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual MachMachineResource MachMachineResource { get; set; } = null!;
        public virtual MachMachineResourceActivityType MachMachineResourceActivityType { get; set; } = null!;
    }
}
