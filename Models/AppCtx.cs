using System.Data.Entity;

namespace WebApplication1.Models
{
    public class AppCtx : DbContext
    {
        public AppCtx() : base("DefaultConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}