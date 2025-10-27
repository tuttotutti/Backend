using LeThiMinhTuoi_Lab3_APIBackend_newest_.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeThiMinhTuoi_Lab3_APIBackend_newest_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly List<Book> books = new List<Book> {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Year = 2008, Genre = "Programming" },
            new Book { Id = 2, Title = "Greenlights", Author = "Matthew McConoughy", Year = 2020, Genre = "Memoir" },
            new Book { Id = 3, Title = "To All The Things We Can Only See When We Slow Down", Author = "Haemin Sunim", Year = 2012, Genre = "Psychology" },
        };

        // get all books
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(books);
        }

        // get a book by Id
        [HttpGet("{id}")]
        public IActionResult GetBookById([FromRoute] int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                return Ok(book);
            }
            else
            {
                return NotFound();
            }
        }

        // add a book
        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            // on youtube, apparently it is ModelState.IsValid
            if(newBook == null)
            {
                return BadRequest("Book data is enpty");
            }

            // in real life, I guess Id is auto-generated, so no need to check if Id already exists

            books.Add(newBook);
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);
        }

        // update a book
        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromRoute] int id,[FromBody] Book updatedBook)
        {
            var exisitingBook = books.Find(b => b.Id == id);

            if(exisitingBook == null)
            {
                return NotFound();
            }

            exisitingBook.Title = updatedBook.Title;
            exisitingBook.Author = updatedBook.Author;
            exisitingBook.Year = updatedBook.Year;
            exisitingBook.Genre = updatedBook.Genre;

            return Ok(exisitingBook);
        }

        // delete a book
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var exisitingBook = books.Find(b => b.Id == id);

            if(exisitingBook == null)
            {
                return NotFound();
            }

            books.Remove(exisitingBook);

            return NoContent();
        }
    }

}
