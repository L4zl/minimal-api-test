using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ConfirmationIntentType
    {
        public ConfirmationIntentType()
        {
            PoporderReturnLineArches = new HashSet<PoporderReturnLineArch>();
            PoporderReturnLines = new HashSet<PoporderReturnLine>();
            PopsettingDefaultFreeTextConfirmIntentNavigations = new HashSet<Popsetting>();
            PopsettingDefaultServLabConfirmIntentNavigations = new HashSet<Popsetting>();
            SoporderReturnLineArches = new HashSet<SoporderReturnLineArch>();
            SoporderReturnLines = new HashSet<SoporderReturnLine>();
            SopsettingDefaultFreeTextConfirmIntentNavigations = new HashSet<Sopsetting>();
            SopsettingDefaultServLabConfirmIntentNavigations = new HashSet<Sopsetting>();
        }

        public long ConfirmationIntentTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderReturnLineArch> PoporderReturnLineArches { get; set; }
        public virtual ICollection<PoporderReturnLine> PoporderReturnLines { get; set; }
        public virtual ICollection<Popsetting> PopsettingDefaultFreeTextConfirmIntentNavigations { get; set; }
        public virtual ICollection<Popsetting> PopsettingDefaultServLabConfirmIntentNavigations { get; set; }
        public virtual ICollection<SoporderReturnLineArch> SoporderReturnLineArches { get; set; }
        public virtual ICollection<SoporderReturnLine> SoporderReturnLines { get; set; }
        public virtual ICollection<Sopsetting> SopsettingDefaultFreeTextConfirmIntentNavigations { get; set; }
        public virtual ICollection<Sopsetting> SopsettingDefaultServLabConfirmIntentNavigations { get; set; }
    }
}
