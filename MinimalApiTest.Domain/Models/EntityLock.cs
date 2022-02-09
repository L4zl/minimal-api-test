namespace MinimalApiTest.Domain.Models
{
    public partial class EntityLock
    {
        public long EntityKey { get; set; }
        public string EntityType { get; set; } = null!;
        public long EntityUserId { get; set; }
        public string EntityLockSource { get; set; } = null!;
        public string EntityLockContext { get; set; } = null!;
        public DateTime EntityLockDate { get; set; }
    }
}
