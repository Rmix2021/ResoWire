namespace ResoWire.Data
{
    public class Comment : AuditTable
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        public bool IsProjectComment { get; set; }

        [Required]
        public bool IsIssueComment { get; set; }


    }
}
