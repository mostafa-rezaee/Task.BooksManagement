using BooksManagement.Application.AuthorCommands.Add;
using BooksManagement.Application.AuthorCommands.Update;
using BooksManagement.Query.AuthorQueries.DTO;
using Common.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Facade.Authors
{
    public interface IAuthorFacade
    {
        //Commands
        Task<OperationResult> Add(AddAuthorCommand command);
        Task<OperationResult> Update(UpdateAuthorCommand command);

        //Queries
        Task<AuthorDto?> GetById(Guid id);
        Task<List<AuthorDto>> GetAll();
    }
}
