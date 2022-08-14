using Microsoft.AspNetCore.Mvc;
using ServerAPI.Model;
using ServerAPI.Repositories;

namespace ServerAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ServerControllers : ControllerBase
    {
        private readonly IServerRepositories _ServerRepositories;
        public ServerControllers(IServerRepositories ServerRepositories)
        {
            _ServerRepositories = ServerRepositories;
        }

        [HttpGet]
        public async Task<IEnumerable<Server>> Get()
        {
            return await _ServerRepositories.Get();   
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Server>> GetServer(int id)
        {
            return await _ServerRepositories.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Server>> PostServer([FromBody] Server server)
        {
            var newServer = await _ServerRepositories.Create(server);
            return server;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var serverToDelete = await _ServerRepositories.Get(id);
            if(serverToDelete != null)
                return NotFound();
            await _ServerRepositories.Delete(serverToDelete.id);
            return NoContent();
                        
        }

        [HttpPut]

        public async Task<ActionResult> PutServer(int id, [FromBody] Server server)
        {
            if(id == server.id)
                return BadRequest();
            await _ServerRepositories.Update(server);
            return NoContent();
        }
    }
}
