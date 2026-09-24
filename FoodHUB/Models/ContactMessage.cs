using System.ComponentModel.DataAnnotations;

namespace FoodHUB.Models
{
    public class ContactMessage
    {
        [Required(ErrorMessage = "Your name is required.")]
        [Display(Name = "Full Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        [Display(Name = "Subject")]
        [StringLength(150)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter a message.")]
        [Display(Name = "Message")]
        [StringLength(2000, MinimumLength = 10, ErrorMessage = "Message must be between 10 and 2000 characters.")]
        public string Message { get; set; }
    }
}
