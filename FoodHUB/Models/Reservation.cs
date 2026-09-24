using System;
using System.ComponentModel.DataAnnotations;

namespace FoodHUB.Models
{
    public class Reservation
    {
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select a date.")]
        [DataType(DataType.Date)]
        [Display(Name = "Reservation Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please select a time.")]
        [Display(Name = "Preferred Time")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Please select the number of guests.")]
        [Range(1, 20, ErrorMessage = "Guest count must be between 1 and 20.")]
        [Display(Name = "Number of Guests")]
        public int Guests { get; set; }

        [Display(Name = "Special Requests")]
        [StringLength(500)]
        public string SpecialRequests { get; set; }
    }
}
