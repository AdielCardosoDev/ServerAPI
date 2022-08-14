using ServerAPI.Model;

namespace ServerAPI.Repositories
{
    public interface IServerRepositories
    {
        Task<IEnumerable<Server>> Get();

        Task<Server> Get(int id);

        Task<Server> Create(Server server);

        Task Update(Server server);

        Task Delete(int id);

    }
}
