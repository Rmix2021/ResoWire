namespace ResoWire.Data
{
    public class AuditTable
    {
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? DeletedOn { get; set; }

        
        public string CreatedBy { get; set; }
        public string CreatedById { get; set; }

        public string ModifiedById { get; set; }

        public IdentityUser ModifiedBy { get; set; }

        public string DeletedById { get; set; }
        public IdentityUser DeletedBy { get; set; }
    }
}
