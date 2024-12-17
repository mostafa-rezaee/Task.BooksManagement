using BooksManagement.Domain.Aggregates;
using BooksManagement.Domain.Repositories;
using BooksManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Infrastructure.EFCore.BookConfigs
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private readonly BooksContext _context;
        public BookRepository(BooksContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetByAuthorId(Guid authorId)
        {
            return await _context.Books.Where(x => x.AuthorId == authorId).ToListAsync();
        }
    }
}
