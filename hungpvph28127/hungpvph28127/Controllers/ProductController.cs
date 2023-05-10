using hungpvph28127.Models;
using hungpvph28127.Respository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hungpvph28127.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IBookRes _bookres;

        public ProductController(IBookRes bookRes) {
            _bookres = bookRes;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                return Ok(await _bookres.GetAllBooksAsync());
            }
            catch
            {

                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookres.GetBooksAsync(id);
            return book == null ? NotFound() : Ok(book);
        }
        [HttpPost]
        [Authorize]
         public async Task<IActionResult> AddNewBook(BookModel book)
        {
            try
            {
                var newBookid = await _bookres.AddBooksAsync(book);
                var books = await _bookres.GetBooksAsync(newBookid);
                return books == null ? NotFound() : Ok(books);
            }
            catch 
            {

                return BadRequest();
            }
           
        }
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateBook(int id, BookModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }
            await _bookres.UpdateBooksAsync(id,model);
            return Ok();
        }
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await _bookres.DeleteBooksAsync(id);
            return Ok();
        }
    }
}
