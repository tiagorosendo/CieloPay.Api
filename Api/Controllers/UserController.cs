using Api.Entity;
using System.Threading.Tasks;
using System.Web.Http;

namespace Api.Controllers
{
    public class UserController : ApiController
    {
        private AppContext _context;

        public UserController()
        {
            _context = new AppContext();
        }
        
        [HttpPost]
        public async Task<IHttpActionResult> Post(User user)
        {
            this._context.Users.Add(user);

            await this._context.SaveChangesAsync();

            return this.CreatedAtRoute("GetUser", user.Id, user);
        }

        [Route("api/user/{id}", Name = "GetUser")]
        [HttpGet]
        public async Task<User> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
