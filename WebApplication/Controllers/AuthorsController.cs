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
    public class AuthorsController : Controller
    {
        private ApplicationContext _context;

        public AuthorsController(ApplicationContext context)
        {
            _context = context;
            if (!_context.Authors.Any())
            {
                _context.Authors.Add(new Author{FirstName = "Erich", LastName = "Remark"});
                _context.SaveChanges();
            }
        }
        // GET: api/authors
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return _context.Authors.ToList();
        }

        // GET api/authors/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Author author = _context.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null)
                return NotFound();
            return new ObjectResult(author);
        }

        // POST api/authors
        [HttpPost]
        public IActionResult Post([FromBody]Author author)
        {
            if (author == null)
                return BadRequest();
            _context.Authors.Add(author);
            _context.SaveChanges();
            return Ok(author);
        }

        // PUT api/authors
        [HttpPut]
        public IActionResult Put([FromBody]Author author)
        {
            if (author == null)
                return BadRequest();
            if (!_context.Authors.Any(x => x.Id == author.Id))
                return NotFound();
            _context.Update(author);
            _context.SaveChanges();
            return Ok(author);
        }

        // DELETE api/authors/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var author = _context.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null)
                return NotFound();
            _context.Authors.Remove(author);
            _context.SaveChanges();
            return Ok(author);
        }
    }
}
