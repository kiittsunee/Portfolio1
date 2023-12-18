using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
