using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DrawDrawing
    {
        public DrawDrawing()
        {
            BomDrawings = new HashSet<BomDrawing>();
            DrawDrawingCommentHistories = new HashSet<DrawDrawingCommentHistory>();
        }

        public long DrawDrawingId { get; set; }
        public string Reference { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public string? UserRevisionNumber { get; set; }
        public string? Location { get; set; }
        public string? DesignPackage { get; set; }
        public string? Author { get; set; }
        public string? Title { get; set; }
        public DateTime? EffectiveFromDate { get; set; }
        public DateTime? EffectiveToDate { get; set; }
        public string? IndexNumber { get; set; }
        public string? MediaType { get; set; }
        public string? StockCode { get; set; }
        public string? StockDescription { get; set; }
        public long? MseStockItemId { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerName { get; set; }
        public long? CustomerId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string Notes { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BomDrawing> BomDrawings { get; set; }
        public virtual ICollection<DrawDrawingCommentHistory> DrawDrawingCommentHistories { get; set; }
    }
}
