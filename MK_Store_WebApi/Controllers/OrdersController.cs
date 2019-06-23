using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MK_Store_WebApi.Models;

namespace MK_Store_WebApi.Controllers
{
    public class OrdersController : ApiController
    {
        private MK_Store_WebApiContext db = new MK_Store_WebApiContext();

        // GET: api/Orders
        public IQueryable<OrderDTO> GetOrders()
        {
            var output = db.Orders.Where(x => !x.Archive).Include(p => p.Product).Include(c => c.Client).Select(o => new OrderDTO()
            {
                Id = o.Id,
                ClientFirstName = o.Client.FirstName,
                ClientLastName = o.Client.LastName,
                ProductName = o.Product.Name,
                Date = o.Date,
                Price = o.Product.Price
            });

            return output;
        }

        // GET: api/Orders/5
        [ResponseType(typeof(OrderDTO))]
        public async Task<IHttpActionResult> GetOrder(int client_id)
        {
            IList<OrderDTO> OrdersList = await db.Orders.Where(x => client_id == x.Client_Id && !x.Archive)
                .Include(c => c.Client).Include(p => p.Product).Select(o => new OrderDTO()
                {
                    Id = o.Id,
                    ClientFirstName = o.Client.FirstName,
                    ClientLastName = o.Client.LastName,
                    ProductName = o.Product.Name,
                    Date = o.Date,
                    Price = o.Product.Price
                })
                .ToListAsync();
            if (OrdersList == null)
            {
                return NotFound();
            }

            return Ok(OrdersList);
        }

        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(order);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = order.Id }, order);
        }

        // DELETE: api/Orders/5
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> DeleteOrder(int id)
        {
            Order order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            order.Archive = true;

            db.Entry(order).State = EntityState.Modified;

            await db.SaveChangesAsync();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.Id == id) > 0;
        }
    }
}