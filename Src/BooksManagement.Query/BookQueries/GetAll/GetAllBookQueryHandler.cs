using BooksManagement.Infrastructure.EFCore.BookConfigs;
using BooksManagement.Query.BookQueries.DTO;
using BooksManagement.Query.AuthorQueries.DTO;
using Common.Query.Bases;
using BooksManagement.Domain.Repositories;
using BooksManagement.Domain.Aggregates;

namespace BooksManagement.Query.BookQueries.GetAll
{
    public class GetAllBookQueryHandler : IBaseQueryHandler<GetAllBookQuery, List<BookDto>>
    {
        private readonly IBookRepository _bookRepository;

        public GetAllBookQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookDto>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var list = await _bookRepository.GetAllAsync([nameof(Book.Author)]);
            return list.MapList();
        }
    }
}
