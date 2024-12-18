using BooksManagement.Application.AuthorCommands.Add;
using BooksManagement.Application.AuthorCommands.Update;
using BooksManagement.Facade.Authors;
using BooksManagement.Query.AuthorQueries.DTO;
using BooksManagement.WebAPI.ViewModels.Authors;
using Common.API._Helper;
using Common.API.Bases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksManagement.WebAPI.Controllers
{
    public class AuthorsController : BaseApiController
    {
        private readonly IAuthorFacade _authorFacade;

        public AuthorsController(IAuthorFacade authorFacade)
        {
            _authorFacade = authorFacade;
        }

        [HttpGet]
        public async Task<ApiResult<List<AuthorDto>>> GetAuthorsQuery()
        {
            var list = await _authorFacade.GetAll();
            return QueryResult(list);
        }

        [HttpGet("{id}")]
        public async Task<ApiResult<AuthorDto?>> GetAuthorByIdQuery(Guid id)
        {
            var author = await _authorFacade.GetById(id);
            return QueryResult(author);
        }

        [HttpPost]
        public async Task<ApiResult> AddAuthorCommand(AddAuthorViewModel model)
        {
            var addResult = await _authorFacade.Add(new AddAuthorCommand(model.Name));
            return CommandResult(addResult);
        }

        [HttpPut]
        public async Task<ApiResult> UpdateAutorCommand(UpdateAuthorViewModel model)
        {
            var updateResult = await _authorFacade.Update(new UpdateAuthorCommand(model.Id, model.Name));
            return CommandResult(updateResult);
        }
    }
}
