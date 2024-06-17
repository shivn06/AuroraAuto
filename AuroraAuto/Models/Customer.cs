using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace AuroraAuto.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("First Name")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "You have entered an Invalid Character")]
        public required string FirstName { get; set; }  // First Name Field

        [StringLength(30)]
        [DisplayName("Middle Name(s)")]
        public string? MiddleName { get; set; } // Optional Middle Name Field

        [Required]
        [StringLength(30)]
        [DisplayName("Last Name")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "You have entered an Invalid Character")]
        public required string LastName { get; set; } //Last Name Field  

        [Required]
        public required string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage = "Please enter a valid Phone Number")]
        public required string Phone { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        public required ICollection<Order> Orders { get; set; }
        public required ICollection<Cart> Carts { get; set; }

    }
}
