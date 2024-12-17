using BooksManagement.Domain.Repositories;
using BooksManagement.Infrastructure.EFCore.BookConfigs;
using BooksManagement.Query.BookQueries.DTO;
using Common.Query.Bases;

namespace BooksManagement.Query.BookQueries.GetByAuthor
{
    public class GetByAuthorQueryHandler : IBaseQueryHandler<GetByAuthorQuery, List<BookDto>>
    {
        private readonly IBookRepository _bookRepository;

        public GetByAuthorQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookDto>> Handle(GetByAuthorQuery request, CancellationToken cancellationToken)
        {
            var list = await _bookRepository.GetByAuthorId(request.authorId);
            return list.MapList();
        }
    }
}
