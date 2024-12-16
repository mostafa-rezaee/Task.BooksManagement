using BooksManagement.Query.AuthorQueries.DTO;
using Common.Query.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Query.AuthorQueries.GetById
{
    public record GetByIdAuthorQuery(Guid id) : IBaseQuery<AuthorDto?>;
}
