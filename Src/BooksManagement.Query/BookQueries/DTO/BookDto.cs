using BooksManagement.Query.AuthorQueries.DTO;
using Common.Query.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement.Query.BookQueries.DTO
{
    public class BookDto : BaseDTO
    {
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
        public int PublishedYear { get; set; }
        public AuthorDto Author { get; set; }
    }
}
