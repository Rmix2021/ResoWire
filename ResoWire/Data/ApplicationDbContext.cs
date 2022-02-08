using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ResoWire.Data
{
    public class ResoWireDbContext : IdentityDbContext
    {
        public ResoWireDbContext(DbContextOptions<ResoWireDbContext> options)
            : base(options)
        {
        }
    }
}