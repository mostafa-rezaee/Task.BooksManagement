using BooksManagement.Domain.Aggregates;
using BooksManagement.Domain.Repositories;
using BooksManagement.Query.AuthorQueries.DTO;
using BooksManagement.Query.BookQueries.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Query.BookQueries
{
    internal static class BookMapper
    {
        public static BookDto Map(this Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                PublishedYear = book.PublishedYear,
                Author = book.Author,
            };
        }
        public static List<BookDto> MapList(this List<Book> books)
        {
            return books.Select(x => new BookDto
            {
                Id = x.Id,
                Title = x.Title,
                AuthorId = x.AuthorId,
                PublishedYear = x.PublishedYear,
                Author = x.Author,
            }).ToList();
        }

    }
}
