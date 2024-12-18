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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
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

        public async Task<List<T>> GetAllAsync(string[] includes)
        {
            var _c = _context.Set<T>().AsNoTracking();
            for (var i = 0; i < includes.Length; i++)
            {
                _c = _c.Include(includes[i]);
            }
            return await _c.ToListAsync();
        }

        public async Task<T?> GetTrackingAsync(Guid id)
        {
            return await _context.Set<T>().AsTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<T?> GetTrackingAsync(Guid id, string[] includes)
        {
            var _c = _context.Set<T>().AsTracking();
            for (var i = 0; i < includes.Length; i++)
            {
                _c = _c.Include(includes[i]);
            }
            return await _c.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
