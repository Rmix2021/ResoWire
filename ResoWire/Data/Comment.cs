namespace ResoWire.Data
{
    public class Comment : AuditTable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(280)]
        public string CommentText { get; set; }


        [ForeignKey("IssueId")]
        public int? IssueId { get; set; }



        [NotMapped]
        public virtual Issue Issue { get; set; }

        public virtual List<Comment> Comments { get; set; }


    }
}
