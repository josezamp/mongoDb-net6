using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        /// <summary>
        /// Adds a new book.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateBook(BookDto book)
        {
            var result = await _bookService.AddBookAsync(book);
            return Ok(result);
        }

        /// <summary>
        /// Get a book by name.
        /// </summary>
        /// <param name="name">Book name.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetBook(string name)
        {
            var result = await _bookService.GetBook(name);
            return Ok(result);
        }
    }
}
