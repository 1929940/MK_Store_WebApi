using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MK_Store_WebApi.Models;

namespace MK_Store_WebApi.Controllers
{
    public class ClientsController : ApiController
    {
        private MK_Store_WebApiContext db = new MK_Store_WebApiContext();

        //GET: api/Clients
        public IQueryable<ClientDTO> GetClients()
        {
            var output = from c in db.Clients
                         select new ClientDTO()
                         {
                             Id = c.Id,
                             FirstName = c.FirstName,
                             LastName = c.LastName,
                             Login = c.Login,
                             Email = c.Email,
                             Phone = c.Phone
                         };

            return output;
        }

        // GET: api/Clients/5
        [ResponseType(typeof(ClientDTO))]
        public async Task<IHttpActionResult> GetClient(string name, string surname, string login)
        {
            var client = await db.Clients.Select(c => new ClientDTO()
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Login = c.Login,
                Email = c.Email,
                Phone = c.Phone
            })
                .FirstOrDefaultAsync(
                x => (x.FirstName == name && x.LastName == surname && x.Login == login));
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        // PUT: api/Clients/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClient(int id, Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != client.Id)
            {
                return BadRequest();
            }

            db.Entry(client).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Clients
        [ResponseType(typeof(Client))]
        public async Task<IHttpActionResult> PostClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Clients.Add(client);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = client.Id }, client);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientExists(int id)
        {
            return db.Clients.Count(e => e.Id == id) > 0;
        }
    }
}