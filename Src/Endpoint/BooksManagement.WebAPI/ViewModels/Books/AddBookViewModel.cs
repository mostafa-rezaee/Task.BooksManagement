namespace BooksManagement.WebAPI.ViewModels.Books
{
    public class AddBookViewModel
    {
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
        public int PublishedYear { get; set; }
    }
}
