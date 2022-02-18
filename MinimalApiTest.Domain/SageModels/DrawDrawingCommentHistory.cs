using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DrawDrawingCommentHistory
    {
        public long DrawDrawingCommentHistoryId { get; set; }
        public long DrawDrawingId { get; set; }
        public string? UserRevisionNumber { get; set; }
        public DateTime CommentDateTime { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string Comments { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual DrawDrawing DrawDrawing { get; set; } = null!;
    }
}
