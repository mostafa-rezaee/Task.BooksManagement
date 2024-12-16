using Common.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Application.BookCommands.Add
{
    public class AddBookCommand : IBaseCommand
    {
        public AddBookCommand(string title, Guid authorId, int publishedYear)
        {
            Title = title;
            AuthorId = authorId;
            PublishedYear = publishedYear;
        }

        public string Title { get; set; }
        public Guid AuthorId { get; set; }
        public int PublishedYear { get; set; }
    }
}
