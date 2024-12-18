using BooksManagement.Application.BookCommands.Add;
using BooksManagement.Application.BookCommands.Update;
using BooksManagement.Facade.Books;
using BooksManagement.Query.BookQueries.DTO;
using BooksManagement.WebAPI.ViewModels.Books;
using Common.API._Helper;
using Common.API.Bases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksManagement.WebAPI.Controllers
{
    public class BooksController : BaseApiController
    {
        private readonly IBookFacade _bookFacade;

        public BooksController(IBookFacade bookFacade)
        {
            _bookFacade = bookFacade;
        }

        [HttpGet]
        public async Task<ApiResult<List<BookDto>>> GetBooksQuery()
        {
            var list = await _bookFacade.GetAll();
            return QueryResult(list);
        }

        [HttpGet("{id}")]
        public async Task<ApiResult<BookDto?>> GetBookByIdQuery(Guid id)
        {
            var book = await _bookFacade.GetById(id);
            return QueryResult(book);
        }

        [HttpGet("AuthorBooks/{id}")]
        public async Task<ApiResult<List<BookDto>>> GetBooksByAuthorIdQuery(Guid id)
        {
            var book = await _bookFacade.GetByAuthorId(id);
            return QueryResult(book);
        }

        [HttpPost]
        public async Task<ApiResult> AddBookCommand(AddBookViewModel model)
        {
            var addResult = await _bookFacade.Add(new AddBookCommand(
                model.Title,
                model.AuthorId,
                model.PublishedYear
                ));
            return CommandResult(addResult);
        }

        [HttpPut]
        public async Task<ApiResult> UpdateBookCommand(UpdateBookViewModel model)
        {
            var updateResult = await _bookFacade.Update(new UpdateBookCommand(
                model.Id,
                model.Title,
                model.AuthorId,
                model.PublishedYear
                ));
            return CommandResult(updateResult);
        }
    }
}
