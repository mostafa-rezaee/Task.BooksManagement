using BooksManagement.Domain.Aggregates;
using BooksManagement.Domain.Repositories;
using BooksManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Infrastructure.EFCore.AuthorConfings
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(BooksContext context) : base(context)
        {
        }
    }
}
