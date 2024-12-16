using Common.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Application.BookCommands.Update
{
    public class UpdateBookCommand : IBaseCommand
    {
        public UpdateBookCommand(Guid id, string title, Guid authorId, int publishedYear)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
            PublishedYear = publishedYear;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
        public int PublishedYear { get; set; }
    }
}
