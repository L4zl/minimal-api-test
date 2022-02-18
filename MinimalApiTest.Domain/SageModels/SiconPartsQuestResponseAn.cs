using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPartsQuestResponseAn
    {
        public long SiconPartsQuestResponseAnsId { get; set; }
        public long? SiconPartsQuestResponseId { get; set; }
        public long? SiconPartsQuestionId { get; set; }
        public string? AnswerText { get; set; }
        public int? OrderVal { get; set; }
        public bool? Inactive { get; set; }
        public string? Username { get; set; }
    }
}
