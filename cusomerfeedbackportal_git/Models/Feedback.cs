using System.ComponentModel.DataAnnotations;

namespace CustomerFeedbackPortal.Models
{
    public class Feedback
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        [StringLength(500)]
        public string Comments { get; set; }
    }
}