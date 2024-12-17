using BooksManagement.Query.BookQueries.DTO;
using Common.Query.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Query.BookQueries.GetAll
{
    public record GetAllBookQuery : IBaseQuery<List<BookDto>>;
}
