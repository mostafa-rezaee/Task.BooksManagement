using BooksManagement.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Unit.Test.Builders
{
    internal class BookBuilder
    {
        private string _title = "title";
        private Guid _authorId = Guid.NewGuid();
        private int _publishedYear = 1400;

        public BookBuilder SetTitle(string title)
        {
            _title = title;
            return this;
        }

        public BookBuilder SetAuthorId(Guid authorId)
        {
            _authorId = authorId;
            return this;
        }

        public BookBuilder SetPublishedYear(int publishedYear)
        {
            _publishedYear = publishedYear;
            return this;
        }

        public Book Build()
        {
            return new Book(_title, _authorId, _publishedYear);
        }
    }
}
