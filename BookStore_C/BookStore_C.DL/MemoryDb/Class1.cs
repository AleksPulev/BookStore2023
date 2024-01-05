using BookStore_C.Models.Models;

namespace BookStore_C.DL.MemoryDb
{
    public static class StaticData {
    public static List<Book> BookData =
            new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Book 1",
                    AuthorId=1,
                    ReleaseDate = DateTime.Now
                },
               new Book()
                {
                    Id = 2,
                    Title = "Book 2",
                    AuthorId=2,
                    ReleaseDate = DateTime.Now
                },
               new Book()
                {
                    Id = 3,
                    Title = "Book 3",
                    AuthorId=3,
                    ReleaseDate = DateTime.Now
                },

            };
    public static List<Author> AuthorData =
            new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name = "Author 1",
                    BirthDay = DateTime.Now
                },
                new Author()
                {
                    Id = 2,
                    Name = "Author 2",
                    BirthDay = DateTime.Now
                },
                new Author()
                {
                    Id = 3,
                    Name = "Author 3",
                    BirthDay = DateTime.Now
                }
            };
    }
}
