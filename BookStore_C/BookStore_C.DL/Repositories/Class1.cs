using BookStore_C.DL.Interfaces;
using BookStore_C.Models.Models;

namespace BookStore_C.DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Book? GetAllBooksByAuthor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
