using Common.Domain.Bases;
using Common.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Aggregates
{
    public class Book : BaseEntity
    {
        #region Properties
        public string Title { get; private set; } = string.Empty;
        public Guid AuthorId { get; private set; }
        public int PublishedYear { get; private set; }
        public Author Author { get; private set; }

        #endregion

        #region Constructors
        private Book() { }
        public Book(string title, Guid authorId, int publishedYear)
        {
            HandleValidating(title, authorId, publishedYear);
            Title = title;
            AuthorId = authorId;
            PublishedYear = publishedYear;
        }
        #endregion

        #region Methods
        public void Edit(string title, Guid authorId, int publishedYear)
        {
            HandleValidating(title, authorId, publishedYear);
            Title = title;
            AuthorId = authorId;
            PublishedYear = publishedYear;
        }
        private void HandleValidating(string title, Guid authorId, int publishedYear)
        {
            NullEmptyException.CheckNotEmpty(title, nameof(title));
            NullEmptyException.CheckNotEmpty(authorId, nameof(authorId));
            NullEmptyException.CheckNotEmpty(publishedYear, nameof(publishedYear));
        }
        #endregion

    }
}
