using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcanalysisField
    {
        public PcanalysisField()
        {
            PcanalysisFieldListPcanalysisField1s = new HashSet<PcanalysisFieldList>();
            PcanalysisFieldListPcanalysisField2s = new HashSet<PcanalysisFieldList>();
            PcanalysisFieldListPcanalysisField3s = new HashSet<PcanalysisFieldList>();
            PcanalysisFieldListPcanalysisField4s = new HashSet<PcanalysisFieldList>();
            PcanalysisFieldListPcanalysisField5s = new HashSet<PcanalysisFieldList>();
            PcanalysisFieldValues = new HashSet<PcanalysisFieldValue>();
            PccostGroupAnalysisFields = new HashSet<PccostGroupAnalysisField>();
            PccostItemAnalysisFields = new HashSet<PccostItemAnalysisField>();
            PccostItemTypeAnalFieldSettings = new HashSet<PccostItemTypeAnalFieldSetting>();
            PcgroupLevelAnalFieldSettings = new HashSet<PcgroupLevelAnalFieldSetting>();
            PcprojectLvlAnalFieldSettings = new HashSet<PcprojectLvlAnalFieldSetting>();
        }

        public long PcanalysisFieldId { get; set; }
        public long PcanalysisFieldTypeId { get; set; }
        public string Name { get; set; } = null!;
        public bool SelectionMustAlwaysBeMade { get; set; }
        public bool MustSelectFromList { get; set; }
        public bool PromptToAddNewValues { get; set; }
        public bool? DisplayAllSelectionsForLookup { get; set; }
        public long? ProductGroupId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcanalysisFieldType PcanalysisFieldType { get; set; } = null!;
        public virtual ICollection<PcanalysisFieldList> PcanalysisFieldListPcanalysisField1s { get; set; }
        public virtual ICollection<PcanalysisFieldList> PcanalysisFieldListPcanalysisField2s { get; set; }
        public virtual ICollection<PcanalysisFieldList> PcanalysisFieldListPcanalysisField3s { get; set; }
        public virtual ICollection<PcanalysisFieldList> PcanalysisFieldListPcanalysisField4s { get; set; }
        public virtual ICollection<PcanalysisFieldList> PcanalysisFieldListPcanalysisField5s { get; set; }
        public virtual ICollection<PcanalysisFieldValue> PcanalysisFieldValues { get; set; }
        public virtual ICollection<PccostGroupAnalysisField> PccostGroupAnalysisFields { get; set; }
        public virtual ICollection<PccostItemAnalysisField> PccostItemAnalysisFields { get; set; }
        public virtual ICollection<PccostItemTypeAnalFieldSetting> PccostItemTypeAnalFieldSettings { get; set; }
        public virtual ICollection<PcgroupLevelAnalFieldSetting> PcgroupLevelAnalFieldSettings { get; set; }
        public virtual ICollection<PcprojectLvlAnalFieldSetting> PcprojectLvlAnalFieldSettings { get; set; }
    }
}
