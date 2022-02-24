namespace ResoWire.Data
{
    public class Project : AuditTable
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public string Projectname { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime TargetEndDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        
        public string AssignedTo { get; set; }



    }
}
