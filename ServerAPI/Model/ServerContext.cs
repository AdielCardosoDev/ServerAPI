using Microsoft.EntityFrameworkCore;

namespace ServerAPI.Model
{
    public class ServerContext : DbContext
    {
        public ServerContext(DbContextOptions<ServerContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Server> Server { get; set; }
    }
}
