using BookStore_C.Models.Models;

namespace BookStore_C.BL.Services
{
    public class BookService {
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<Book> GetAllBooksByAuthor(int authorId)
        {
            return _bookRepository.GetAllBooksByAuthor(authorId);
        }
    }

}

