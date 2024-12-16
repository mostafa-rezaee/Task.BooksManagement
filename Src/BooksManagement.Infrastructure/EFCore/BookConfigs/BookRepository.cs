using BooksManagement.Domain.Aggregates;
using BooksManagement.Domain.Repositories;
using BooksManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Infrastructure.EFCore.BookConfigs
{
    internal class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(BooksContext context) : base(context)
        {
        }
    }
}
