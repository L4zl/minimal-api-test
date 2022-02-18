﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PssearchField
    {
        public long PssearchFieldId { get; set; }
        public long PssearchId { get; set; }
        public long PsfieldDescriptorId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PsfieldDescriptor PsfieldDescriptor { get; set; } = null!;
        public virtual Pssearch Pssearch { get; set; } = null!;
    }
}