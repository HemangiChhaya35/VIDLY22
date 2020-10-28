using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    public class DB : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        //public DbSet<Rental> Rentals { get; set; }

        public DB()
            : base("DB", throwIfV1Schema: false)
        {
        }

        public static DB Create()
        {
            return new DB();
        }
    }
}