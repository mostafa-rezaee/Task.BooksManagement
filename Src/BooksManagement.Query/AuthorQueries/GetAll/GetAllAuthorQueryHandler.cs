using BooksManagement.Domain.Repositories;
using BooksManagement.Query.AuthorQueries.DTO;
using Common.Query.Bases;

namespace BooksManagement.Query.AuthorQueries.GetAll
{
    public class GetAllAuthorQueryHandler : IBaseQueryHandler<GetAllAuthorQuery, List<AuthorDto>>
    {
        private readonly IAuthorRepository _authorRepository;

        public GetAllAuthorQueryHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<List<AuthorDto>> Handle(GetAllAuthorQuery request, CancellationToken cancellationToken)
        {
            var list = await _authorRepository.GetAllAsync();
            return list.Select(x => new AuthorDto { Id = x.Id, Name = x.Name }).ToList();
        }
    }
}
