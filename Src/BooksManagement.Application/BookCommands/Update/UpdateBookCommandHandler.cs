using BooksManagement.Domain.Repositories;
using Common.Application;
using Common.Application.Bases;

namespace BooksManagement.Application.BookCommands.Update
{
    public class UpdateBookCommandHandler : IBaseCommandHandler<UpdateBookCommand>
    {
        private readonly IBookRepository _bookRepository;

        public UpdateBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<OperationResult> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetTrackingAsync(request.Id);
            if (book == null) return OperationResult.NotFound();
            book.Edit(request.Title, request.AuthorId, request.PublishedYear);
            await _bookRepository.SaveAsync();
            return OperationResult.Success();
        }
    }
}
