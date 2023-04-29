using System;
using Store;
using System.Linq;
namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[] 
        {
        new Book (1,"ISBN 12312-12312","D.Knuth","Art of Programming"),
        new Book (2,"ISBN 13412-12312","H.Fowler","Refactoring"),
        new Book (3,"ISBN 14512-12312","B.Kernighan","C Programming Language")

        };

       

        public Book[] GetAllByIsbn(string isbn)
        {
          return books.Where(book => book.Isbn == isbn)
                .ToArray();
        }

   

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                   || book.Title.Contains(query))
                 .ToArray();
        }
    }
}