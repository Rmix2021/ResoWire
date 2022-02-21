
namespace ResoWire.Services
{
    public class ProjectService
    {
        readonly ResoWireDbContext _context;
      

        public ProjectService(ResoWireDbContext context)
        {
            this._context = context;
           
        }

        public async Task<bool> AddNewProjectAsync(Project name)
        {
            await _context.Projects.AddAsync(name);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateProjectAsync(Project project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Project>> GetAllProjectsAsync()
        {
            var projectList = await _context.Projects.ToListAsync();
            return projectList;
        }
        public async Task<bool> DeleteProjectAsync(Project project)
        {
            _context.Remove(project);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Project> GetProjectAsync(int Id)
        {
            Project project = await _context.Projects.FirstOrDefaultAsync(c => c.ProjectId.Equals(Id));
            return project;
        }



        public List<Project> GetFilteredProjects(string projectName)
        {

            return this._context.Projects.Where(x => x.Projectname == projectName).ToList();
        }

        public List<Project> GetFilteredProjectsByCreatorUserName(string creatorUserName)
        {

            return this._context.Projects.Where(x => x.CreatedBy.UserName == creatorUserName).ToList();
        }

        public List<Project> GetFilteredProjectsByCreatorId(string CreatorId)
        {

            return this._context.Projects.Where(x => x.CreatedById == CreatorId).ToList();
        }

        public List<Project> GetFilteredProjectsByStartDate(DateTime startDate)
        {

            return this._context.Projects.Where(x => x.StartDate == startDate).ToList();
        }   
        
    }
}
