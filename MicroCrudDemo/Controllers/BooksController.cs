using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MicroCrudDemo.Context;
using MicroCrudDemo.Model;

namespace MicroCrudDemo.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly CrudContext context;

        public BooksController(CrudContext Context)
        {
            context = Context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return context.Books.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return context.Books.FirstOrDefault(b => b.Id == id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Book value)
        {
            context.Books.Add(value);
            context.SaveChanges();
            return StatusCode(201, value.Id);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Book value)
        {
            if (context.Books.Any(n => n.Id == id))
            {
                value.Id = 0;
            }
            context.Books.Add(value);
            context.SaveChanges();
            return StatusCode(201, value.Id);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = context.Books.FirstOrDefault(n => n.Id == id);
            if (book != null)
            {
                context.Books.Remove(book);
                return StatusCode(202);
            }
            else
            {
                return StatusCode(403);
            }
        }
    }
}
