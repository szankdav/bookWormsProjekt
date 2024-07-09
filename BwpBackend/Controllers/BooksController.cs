using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BwpBackend.Models;

namespace BwpBackend.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BwpDbContext _context;
        public BooksController(BwpDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return _context.Books.ToList();
        }

        // GET: api/Booka/1
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        // POST: api/Books
        [HttpPost]
        public ActionResult<Book> CreateBook(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }

            _context.Books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }
    }
}