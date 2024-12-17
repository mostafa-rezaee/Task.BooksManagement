using BooksManagement.Query.AuthorQueries.DTO;
using BooksManagement.Query.BookQueries.DTO;
using Common.Query.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Query.BookQueries.GetByAuthor
{
    public record GetByAuthorQuery(Guid authorId) : IBaseQuery<List<BookDto>>;
}
