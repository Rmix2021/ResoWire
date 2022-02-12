namespace ResoWire.Data
{
    public class Project : AuditTable
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public string Projectname { get; set; }
        public string Description { get; set; }

        [Required]
        public DateOnly StartDate { get; set;}
        public DateOnly TargetEndDate { get;set;}
        public DateOnly ActualEndDate { get; set; }

        public ICollection<Comment> Comments { get; init; } = new List<Comment>();

    }
}
