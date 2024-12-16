using BooksManagement.Domain.Aggregates;
using Common.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Domain.Repositories
{
    public interface IBookRepository : IBaseRepository<Book>
    {
    }
}
