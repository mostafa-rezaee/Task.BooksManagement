using BooksManagement.Query.AuthorQueries.DTO;
using Common.Query.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Query.AuthorQueries.GetAll
{
    public record GetAllAuthorQuery : IBaseQuery<List<AuthorDto>>;
}
