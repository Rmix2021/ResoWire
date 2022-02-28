namespace ResoWire.Services
{
    public class IssueService
    {
        readonly ResoWireDbContext _context;


        public IssueService(ResoWireDbContext context)
        {
            this._context = context;

        }

        public async Task<bool> AddNewIssueAsync(Issue issueName)
        {
            await _context.Issues.AddAsync(issueName);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateIssueAsync(Issue issue)
        {
            _context.Issues.Update(issue);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<List<Issue>> GetFilteredIssuesAsync(int Id)
        {
            var issueList = await _context.Issues.Where(x => x.RelatedToProjectId == Id).ToListAsync();

            return issueList;
        }

        public async Task<bool> DeleteIssueAsync(Issue issue)
        {
            _context.Remove(issue);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Issue> GetIssueAsync(int Id)
        {
            Issue issue = await _context.Issues.FirstOrDefaultAsync(c => c.IssueId.Equals(Id));
            return issue;
        }
           

        public async Task<List<Issue>> GetFilteredIssuesByCreatedByAsync(string createdBy)
        {
            return await this._context.Issues.Where(x => x.CreatedBy == createdBy).ToListAsync();
        }

        public async Task<List<Issue>> GetFilteredIssuesByCreatedOnAsync(DateTime createdOn)
        {
            return await this._context.Issues.Where(x => x.CreatedOn == createdOn).ToListAsync();
        }

        public async Task<List<Issue>> GetFilteredIssuesByDeletedByAsync(string deletedBy)
        {

            return await this._context.Issues.Where(x => x.DeletedBy == deletedBy).ToListAsync();
        }
    }
}
