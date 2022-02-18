using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAppQuestResponseAn
    {
        public long SiconAppQuestResponseAnsId { get; set; }
        public long SiconAppointmentId { get; set; }
        public long SiconAppointmentQuestionId { get; set; }
        public string? AnswerText { get; set; }
        public int? OrderVal { get; set; }
    }
}
