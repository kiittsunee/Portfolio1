using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public int Rating { get; set; }
    }
}
