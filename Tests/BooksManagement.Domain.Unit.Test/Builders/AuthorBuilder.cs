using BooksManagement.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Unit.Test.Builders
{
    internal class AuthorBuilder
    {
        private string _name = "test";

        public AuthorBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public Author Build()
        {
            return new Author(_name);
        }
    }
}
