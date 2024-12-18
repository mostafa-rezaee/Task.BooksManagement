using BooksManagement.Domain.Unit.Test.Builders;
using Common.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Unit.Test
{
    public class BookTests
    {
        private readonly BookBuilder _bookBuilder;
        public BookTests()
        {
            _bookBuilder = new BookBuilder();
        }

        [Fact]
        public void Constructor_Must_Create_Author_Properties()
        {
            _bookBuilder.SetTitle("title1")
                .SetAuthorId(Guid.Parse("00000000-0000-0000-0000-000000000000"))
                .SetPublishedYear(1401);

            var book = _bookBuilder.Build();

            Assert.NotNull(book);
            Assert.Equal("title1", book.Title);
            Assert.Equal(Guid.Parse("00000000-0000-0000-0000-000000000000"), book.AuthorId);
            Assert.Equal(1401, book.PublishedYear);
        }

        [Fact]
        public void Constructor_Must_ThrowException_When_Name_Is_Empty()
        {
            var bookAction = () => _bookBuilder.SetTitle("")
            .SetAuthorId(Guid.Parse("00000000-0000-0000-0000-000000000000"))
            .SetPublishedYear(1401).Build();

            Assert.Throws<NullEmptyException>(bookAction);
        }

        [Fact]
        public void Edit_Must_Update_Book()
        {
            var book = _bookBuilder.SetTitle("test1")
                .SetAuthorId(Guid.Parse("00000000-0000-0000-0000-000000000000"))
                .SetPublishedYear(1401).Build();

            book.Edit("edited", Guid.Parse("00000000-0000-0000-0000-000000000001"), 1400);

            Assert.Equal("edited", book.Title);
            Assert.Equal(Guid.Parse("00000000-0000-0000-0000-000000000001"), book.AuthorId);
            Assert.Equal(1400, book.PublishedYear);
        }
    }
}
