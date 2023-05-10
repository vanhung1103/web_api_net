using AutoMapper;
using hungpvph28127.Data;
using hungpvph28127.Models;
using hungpvph28127.Respository;
using Microsoft.EntityFrameworkCore;

namespace hungpvph28127.Res
{
    public class BookRes : IBookRes
    {
        public readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public BookRes(BookStoreContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<int> AddBooksAsync(BookModel model)
        {
            var newBook = _mapper.Map<Book>(model);
            _context.Books!.Add(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;
        }

        public async Task DeleteBooksAsync(int id)
        {
            var deleteBook = _context.Books!.SingleOrDefault(x => x.Id == id);
            if (deleteBook != null)
            {
                _context.Books!.Remove(deleteBook);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<BookModel>> GetAllBooksAsync()
        {
           var books = await _context.Books!.ToListAsync();
            return _mapper.Map<List<BookModel>>(books);
        }

        public async Task<BookModel> GetBooksAsync(int id)
        {
            var books = await _context.Books!.FindAsync(id);
            return _mapper.Map<BookModel>(books);
        }

        public async Task UpdateBooksAsync(int id, BookModel book)
        {
            if (id == book.Id)
            {
                var updateBook = _mapper.Map<Book>(book);
                _context.Books!.Update(updateBook);
                await _context.SaveChangesAsync();
            }
            
        }
    }
}
