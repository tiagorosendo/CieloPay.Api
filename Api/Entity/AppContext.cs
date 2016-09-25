using System.Data.Entity;

namespace Api.Entity
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}