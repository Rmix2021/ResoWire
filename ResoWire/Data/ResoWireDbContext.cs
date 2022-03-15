namespace ResoWire.Data
{
    public class ResoWireDbContext : IdentityDbContext
    {
        public ResoWireDbContext(DbContextOptions<ResoWireDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Comment> Comments { get; set; }

        //"Pa$$w0rdpA44W0RD"


    }
}