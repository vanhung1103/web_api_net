using hungpvph28127.Data;
using hungpvph28127.Models;

namespace hungpvph28127.Respository
{
    public interface IBookRes
    {
        public Task<List<BookModel>> GetAllBooksAsync();
        public Task<BookModel> GetBooksAsync(int id);
        public Task<int> AddBooksAsync(BookModel model);
        public Task UpdateBooksAsync(int id, BookModel book);
        public Task DeleteBooksAsync(int id);
    }
}
