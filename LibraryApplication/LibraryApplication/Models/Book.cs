using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }   
        public string Writer { get; set; } 
        public string Summary { get; set; }
        public string Publisher { get; set; }
        public int PublishedDate { get; set; }
    }
}