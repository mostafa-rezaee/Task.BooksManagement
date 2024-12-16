using BooksManagement.Domain.Repositories;
using BooksManagement.Query.AuthorQueries.DTO;
using Common.Query.Bases;

namespace BooksManagement.Query.AuthorQueries.GetById
{
    public class GetByIdAuthorQueryHandler : IBaseQueryHandler<GetByIdAuthorQuery, AuthorDto?>
    {
        private readonly IAuthorRepository _authorRepository;

        public GetByIdAuthorQueryHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<AuthorDto?> Handle(GetByIdAuthorQuery request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetTrackingAsync(request.id);
            if (author == null) return null;
            return new AuthorDto { Id = author.Id, Name = author.Name };
        }
    }
}
