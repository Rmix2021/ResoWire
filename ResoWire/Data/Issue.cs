namespace ResoWire.Data
{
    public class Issue : AuditTable
    {
        [Key]
        public int IssueId { get; set; }

        [Required]
        public string IssueSummary { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser IssueIdentifiedBy { get; set; }

        [Required]
        public DateOnly IdentifiedOn { get; set; }

        [ForeignKey("ProjectId")]
        public int RelatedToProjectId { get; set; }

        public ICollection<Comment> Comments { get; init; } = new List<Comment>();
    }
}


//issue_id number n/a Yes primary key A unique numeric ID
//that identifies an issue.
//Populated by a sequence
//using a trigger.
//issue_summary varchar2 255 Yes None A brief summary of the
//issue.
//issue_description varchar2 4000 No None A detailed description of
//the issue.
//identified_by_person_id number n/a Yes foreign key to People The user who identifies
//the issue.
//identified_date date n/a Yes None The date the issue was
//identified
//related_project number n/a Yes foreign key to Projects Project related to the
//issue.
//assigned_to integer n/a No foreign key to eba_it_
//people
//The person who owns
//this issue.
