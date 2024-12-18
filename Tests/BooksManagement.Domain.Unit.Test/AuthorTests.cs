using BooksManagement.Domain.Unit.Test.Builders;
using Common.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Unit.Test
{
    public class AuthorTests
    {
        private AuthorBuilder _authorBuilder;
        public AuthorTests()
        {
            _authorBuilder = new AuthorBuilder();
        }

        [Fact]
        public void Constructor_Must_Create_Author_Properties()
        {
            _authorBuilder.SetName("test1");

            var author = _authorBuilder.Build();

            Assert.NotNull(author);
            Assert.Equal("test1", author.Name);
        }

        [Fact]
        public void Constructor_Must_ThrowException_When_Name_Is_Empty()
        {
            var authorAction = () => _authorBuilder.SetName("").Build();

            Assert.Throws<NullEmptyException>(authorAction);
        }

        [Fact]
        public void Edit_Must_Update_Author()
        {
            var author = _authorBuilder.SetName("TEST2").Build();

            author.Edit("edited");

            Assert.Equal("edited", author.Name);
        }
    }
}
