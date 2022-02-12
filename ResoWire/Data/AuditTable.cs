namespace ResoWire.Data
{
    public class AuditTable
    {
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? DeletedOn { get; set; }

        public IdentityUser CreatedBy { get; set; }
        public string CreatedById { get; set; }

        public string ModifiedById { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser ModifiedBy { get; set; }

        public string DeletedById { get; set; }
        public IdentityUser DeletedBy { get; set; }
    }
}
