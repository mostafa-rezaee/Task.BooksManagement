using BooksManagement.Application.AuthorCommands.Add;
using BooksManagement.Application.AuthorCommands.Update;
using BooksManagement.Query.AuthorQueries.DTO;
using BooksManagement.Query.AuthorQueries.GetAll;
using BooksManagement.Query.AuthorQueries.GetById;
using Common.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Facade.Authors
{
    public class AuthorFacade : IAuthorFacade
    {
        private readonly IMediator _mediator;

        public AuthorFacade(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<OperationResult> Add(AddAuthorCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<OperationResult> Update(UpdateAuthorCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<AuthorDto?> GetById(Guid id)
        {
            return await _mediator.Send(new GetByIdAuthorQuery(id));
        }

        public async Task<List<AuthorDto>> GetAll()
        {
            return await _mediator.Send(new GetAllAuthorQuery());
        }
                
    }
}
