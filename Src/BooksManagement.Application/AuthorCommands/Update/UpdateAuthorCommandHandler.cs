using BooksManagement.Domain.Repositories;
using Common.Application;
using Common.Application.Bases;

namespace BooksManagement.Application.AuthorCommands.Update
{
    public class UpdateAuthorCommandHandler : IBaseCommandHandler<UpdateAuthorCommand>
    {
        private readonly IAuthorRepository _authorRepository;

        public UpdateAuthorCommandHandler(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<OperationResult> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetTrackingAsync(request.Id);
            if (author == null) return OperationResult.NotFound();
            author.Edit(request.Name);
            await _authorRepository.SaveAsync();
            return OperationResult.Success();
        }
    }
}
