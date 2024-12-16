using BooksManagement.Infrastructure.EFCore;
using Common.Domain.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Infrastructure.Repositories
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly BooksContext _context;

        public BaseRepository(BooksContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public Task<T?> GetTrackingAsync(Guid id)
        {
            return _context.Set<T>().AsTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
