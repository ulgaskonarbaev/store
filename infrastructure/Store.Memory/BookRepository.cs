using System;
using Store;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[]
        {
        new Book (1,"ISBN 12312-12312","D.Knuth","Art of Programming","description1",7.19m),
        new Book (2,"ISBN 13412-12312","H.Fowler","Refactoring","description2",12.45m),
        new Book (3,"ISBN 14512-12312","B.Kernighan","C Programming Language","description3",14.98m)

        };

        public Book[] GetAllByIds(IEnumerable<int> bookIds)
        {
           var foundBooks = from book in books
                            join bookId in bookIds on book.Id equals bookId
                            select book;
            return foundBooks.ToArray();
        }

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

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }


    }
}