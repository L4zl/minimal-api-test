using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAppQuestionAnswer
    {
        public long SiconAppQuestionAnswerId { get; set; }
        public long SiconAppointmentQuestionId { get; set; }
        public string AnswerText { get; set; } = null!;
    }
}
