using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectArchiveUpdateVw
    {
        public long PcprojectItemId { get; set; }
        public long PcprojectArchiveStatusId { get; set; }
        public long PctopLevelParentId { get; set; }
    }
}
