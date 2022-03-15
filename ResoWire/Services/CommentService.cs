namespace ResoWire.Services
{
    public class CommentService
    {
        readonly ResoWireDbContext _context;


        public CommentService(ResoWireDbContext context)
        {
            this._context = context;

        }

        public async Task<bool> AddNewCommentAsync(Comment commentText)
        {
            await _context.Comments.AddAsync(commentText);
            await _context.SaveChangesAsync();
            return true;
        }

    

        public async Task<bool> UpdateCommentAsync(Comment commentText)
        {
            _context.Comments.Update(commentText);
            await _context.SaveChangesAsync();
            return true;
        }

        

        public async Task<List<Comment>> GetFilteredCommentsAsync(int Id)
        {
            var commentList = await _context.Comments.Where(x => x.IssueId == Id).ToListAsync();

            return commentList;
        }

        public async Task<bool> DeleteCommentAsync(Comment commentText)
        {
            _context.Remove(commentText);
            await _context.SaveChangesAsync();
            return true;
        }

     
    }
}
