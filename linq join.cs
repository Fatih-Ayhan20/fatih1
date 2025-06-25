using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "Orhan Pamuk" },
                new Author { AuthorId = 2, Name = "Elif Şafak" },
                new Author { AuthorId = 3, Name = "Ahmet Ümit" }
            };

            List<Book> books = new List<Book>
            {
                new Book { BookId = 1, Title = "Kırmızı Saçlı Kadın", AuthorId = 1 },
                new Book { BookId = 2, Title = "Aşk", AuthorId = 2 },
                new Book { BookId = 3, Title = "Beyoğlu’nun En Güzel Abisi", AuthorId = 3 },
                new Book { BookId = 4, Title = "Masumiyet Müzesi", AuthorId = 1 }
            };

            var query = from book in books
                        join author in authors
                        on book.AuthorId equals author.AuthorId
                        select new
                        {
                            BookTitle = book.Title,
                            AuthorName = author.Name
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
            }
        }
    }
}