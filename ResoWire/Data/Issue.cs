namespace ResoWire.Data
{
    public class Issue : AuditTable
    {
        [Key]
        public int IssueId { get; set; }

        public string IssueName { get; set; }   

        [Required]
        public string IssueSummary { get; set; }

        [Required]
        public string Description { get; set; }
       
        public DateTime IdentifiedOn { get; set; }

        [ForeignKey("ProjectId")]
        public int RelatedToProjectId { get; set; }

        public string AssignedTo { get; set; }
    }
}
