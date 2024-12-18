using BooksManagement.Domain.Aggregates;
using BooksManagement.Domain.Repositories;
using BooksManagement.Infrastructure.EFCore.BookConfigs;
using BooksManagement.Query.BookQueries.DTO;
using Common.Query.Bases;

namespace BooksManagement.Query.BookQueries.GetById
{
    public class GetByIdBookQueryHandler : IBaseQueryHandler<GetByIdBookQuery, BookDto?>
    {
        private readonly IBookRepository _bookRepository;

        public GetByIdBookQueryHandler(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookDto?> Handle(GetByIdBookQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetTrackingAsync(request.id, [nameof(Book.Author)]);
            if (book == null) return null;
            return book.Map();
        }
    }
}
