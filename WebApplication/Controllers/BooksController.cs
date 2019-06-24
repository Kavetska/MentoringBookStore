using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonCosplay;
using AmazonCosplay.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private ApplicationContext _context;

        public BooksController(ApplicationContext context)
        {
            _context = context;
            if (!_context.Books.Any())
            {
                _context.Books.Add(new Book{AuthorId = 1, Title = "Arc of Triumph", Description = "Some description", Price = 23, PublishYear = 1948});
                _context.SaveChanges();
            }
        }
        // GET: api/books
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _context.Books.ToList();
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return NotFound();
            return new ObjectResult(book);
        }

        // POST api/books
        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            if (book == null)
                return BadRequest();
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok(book);
        }

        // PUT api/books
        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            if (book == null)
                return BadRequest();
            if (!_context.Books.Any(x => x.Id == book.Id))
                return NotFound();
            _context.Update(book);
            _context.SaveChanges();
            return Ok(book);
        }

        // DELETE api/books/5
            [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
                return NotFound();
            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok(book);
        }
    }
}
