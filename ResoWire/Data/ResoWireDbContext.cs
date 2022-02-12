namespace ResoWire.Data
{
    public class ResoWireDbContext : IdentityDbContext
    {
        public ResoWireDbContext(DbContextOptions<ResoWireDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData
               (
                new IdentityRole
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR".ToUpper()
                });

            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                        new IdentityUser
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "Admin1",
                            NormalizedUserName = "EUROTUNER1981@GMAIL.COM",
                            Email = "eurotuner1981@gmail.com",
                            NormalizedEmail = "EUROTUNER1981@GMAIL.COM".ToUpper(),
                            EmailConfirmed = true,
                            PasswordHash = hasher.HashPassword(null, "Pa$$w0rdpA44W0RD")
                        }
                    );
         


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );
            modelBuilder.Entity<IdentityUserRole<string>>()
             .HasKey(b => b.UserId);

            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(
                new IdentityRoleClaim<string>
                {
                    Id = 1,
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    ClaimType = "AdminOnly",
                    ClaimValue = "AdminOnly"

                }
            );
           

            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
                new IdentityUserClaim<string>
                {
                    Id = 1,
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    ClaimType = "AdminOnly",
                    ClaimValue = "AdminOnly"

                }
            );
            modelBuilder.Entity<IdentityUserClaim<string>>()
              .HasKey(b => b.UserId);

            
            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(b =>b.UserId);

            modelBuilder.Entity<IdentityUserToken<string>>()
                .HasKey(b => b.UserId);
        }
    }
}