using BooksManagement.Application.BookCommands.Add;
using BooksManagement.Application.BookCommands.Update;
using BooksManagement.Query.BookQueries.DTO;
using Common.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Facade.Books
{
    public interface IBookFacade
    {
        //Commands
        Task<OperationResult> Add(AddBookCommand command);
        Task<OperationResult> Update(UpdateBookCommand command);

        //Queries
        Task<BookDto?> GetById(Guid id);
        Task<List<BookDto>> GetByAuthorId(Guid authorId);
        Task<List<BookDto>> GetAll();

    }
}
