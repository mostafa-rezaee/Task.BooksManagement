using BooksManagement.Domain.Aggregates;
using BooksManagement.Domain.Repositories;
using Common.Application;
using Common.Application.Bases;

namespace BooksManagement.Application.AuthorCommands.Add
{
    public class AddAuthorCommandHandler : IBaseCommandHandler<AddAuthorCommand>
    {
        private readonly IAuthorRepository _authorRepository;

        public AddAuthorCommandHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<OperationResult> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = new Author(request.Name);
            await _authorRepository.AddAsync(author);
            await _authorRepository.SaveAsync();
            return OperationResult.Success();
        }
    }
}
