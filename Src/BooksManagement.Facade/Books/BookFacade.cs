using BooksManagement.Application.BookCommands.Add;
using BooksManagement.Application.BookCommands.Update;
using BooksManagement.Query.AuthorQueries.GetById;
using BooksManagement.Query.BookQueries.DTO;
using BooksManagement.Query.BookQueries.GetAll;
using BooksManagement.Query.BookQueries.GetByAuthor;
using BooksManagement.Query.BookQueries.GetById;
using Common.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Facade.Books
{
    public class BookFacade : IBookFacade
    {
        private readonly IMediator _mediator;

        public BookFacade(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<OperationResult> Add(AddBookCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<OperationResult> Update(UpdateBookCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<BookDto?> GetById(Guid id)
        {
            return await _mediator.Send(new GetByIdBookQuery(id));
        }

        public async Task<List<BookDto>> GetByAuthorId(Guid authorId)
        {
            return await _mediator.Send(new GetByAuthorQuery(authorId));
        }

        public async Task<List<BookDto>> GetAll()
        {
            return await _mediator.Send(new GetAllBookQuery());
        }

                
    }
}
