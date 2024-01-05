using BookStore_C.Models.Models;

namespace BookStore_C.DL.Interfaces
{
    internal interface IBookRepository
    {
        Book? GetAllBooksByAuthor(int id);
    }
}
