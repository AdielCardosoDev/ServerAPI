using Microsoft.EntityFrameworkCore;
using ServerAPI.Model;

namespace ServerAPI.Repositories
{
    public class ServerRepositories : IServerRepositories
    {
        public readonly ServerContext _context;

        public ServerRepositories(ServerContext context)
        {
            _context = context;
        }

        public async Task<Server> Create(Server server)
        {
            _context.Server.Add(server);
            await _context.SaveChangesAsync();
            return server;
        }

        public async Task Delete(int id)
        {
            var serverToDelete = await _context.Server.FindAsync(id);

            _context.Server.Remove(serverToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Server>> Get()
        {
          return await _context.Server.ToListAsync();
        }

        public async Task<Server> Get(int id)
        {
           return await _context.Server.FindAsync(id);
        }

        public async Task Update(Server server)
        {
            _context.Entry(server).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            
        }
    }
}
