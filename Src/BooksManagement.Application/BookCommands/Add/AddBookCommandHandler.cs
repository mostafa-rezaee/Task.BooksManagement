using BooksManagement.Domain.Aggregates;
using BooksManagement.Domain.Repositories;
using Common.Application;
using Common.Application.Bases;

namespace BooksManagement.Application.BookCommands.Add
{
    public class AddBookCommandHandler : IBaseCommandHandler<AddBookCommand>
    {
        private readonly IBookRepository _bookRepository;

        public AddBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<OperationResult> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Title, request.AuthorId, request.PublishedYear);
            await _bookRepository.AddAsync(book);
            await _bookRepository.SaveAsync();
            return OperationResult.Success();
        }
    }
}
