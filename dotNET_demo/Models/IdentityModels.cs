using Microsoft.AspNet.Identity.EntityFramework;

namespace dotNET_demo.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }
    public class Role : IdentityRole
    {

    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<dotNET_demo.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<dotNET_demo.Models.News> News { get; set; }
    }
}