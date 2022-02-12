

namespace ResoWire.Data
{
    public class Person : AuditTable
    {
        [Key]
        public IdentityUser UserId { get; set; }
       
        [Required]
        public IdentityUser UserName { get; set; }

        public IdentityUser Email { get; set; }

        //UserClaim is UserRole
        public IdentityUserClaim<string> UserClaim { get; set; }

      

    }
}


