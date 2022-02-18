using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiUserSetting
    {
        public long SiUserSettingId { get; set; }
        public long UserNumber { get; set; }
        public long? SiBespokeTypeId { get; set; }
        public string Text1 { get; set; } = null!;
        public string Text2 { get; set; } = null!;
        public string Text3 { get; set; } = null!;
        public string Text4 { get; set; } = null!;
        public string Text5 { get; set; } = null!;
        public string Text6 { get; set; } = null!;
        public string Text7 { get; set; } = null!;
        public string Text8 { get; set; } = null!;
        public string Text9 { get; set; } = null!;
        public string Text10 { get; set; } = null!;
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Number3 { get; set; }
        public double Number4 { get; set; }
        public double Number5 { get; set; }
        public double Number6 { get; set; }
        public double Number7 { get; set; }
        public double Number8 { get; set; }
        public double Number9 { get; set; }
        public double Number10 { get; set; }
        public string? Memo1 { get; set; }
        public string? Memo2 { get; set; }
        public string? Memo3 { get; set; }
        public string? Memo4 { get; set; }
        public string? Memo5 { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
