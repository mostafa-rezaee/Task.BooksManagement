using BooksManagement.Domain.Repositories;
using BooksManagement.Infrastructure.EFCore.BookConfigs;
using BooksManagement.Query.BookQueries.DTO;
using Common.Query.Bases;

namespace BooksManagement.Query.BookQueries.GetById
{
    public class GetByIdBookQueryHandler : IBaseQueryHandler<GetByIdBookQuery, BookDto?>
    {
        private readonly IBookRepository _bookRepository;

        public GetByIdBookQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookDto?> Handle(GetByIdBookQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetTrackingAsync(request.id);
            if (book == null) return null;
            return book.Map();
        }
    }
}
