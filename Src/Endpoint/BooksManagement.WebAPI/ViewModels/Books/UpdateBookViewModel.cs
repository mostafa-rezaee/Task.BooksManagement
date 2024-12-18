namespace BooksManagement.WebAPI.ViewModels.Books
{
    public class UpdateBookViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
        public int PublishedYear { get; set; }
    }
}
