using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace AuroraAuto.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required] // Does not allow the field to be left empty/null
        [StringLength(30)] // Only allows input of upto 30 characters
        [DisplayName("First Name")] // Sets the text that is displayed as the input field label
        [RegularExpression("^[a-zA-Z-' 1-9]+$", ErrorMessage = "You have entered an Invalid Character")] // Allows only Alphanumeric Characters
        public required string FirstName { get; set; }  // First Name Field

        [StringLength(30)]
        [DisplayName("Middle Name(s) - Optional")]
        [RegularExpression("^[a-zA-Z-' 1-9]+$", ErrorMessage = "You have entered an Invalid Character")] // Allows only Alphanumeric Characters
        public string? MiddleName { get; set; } // Optional Middle Name Field

        [Required]
        [StringLength(30)]
        [DisplayName("Last Name")]
        [RegularExpression("^[a-zA-Z-' 1-9]+$", ErrorMessage = "You have entered an Invalid Character")] // Allows only Alphanumeric Characters
        public required string LastName { get; set; } // Last Name Field  

        [Required]
        [StringLength(30)]
        [RegularExpression("^[a-zA-Z-' 1-9]+$", ErrorMessage = "You have entered an Invalid Character")] // Allows only Alphanumeric Characters
        public required string Address { get; set; } // Address Field

        [Required]
        [DataType(DataType.PhoneNumber)]
        // Regular Expression validates all NZ Phone Numbers written in any correct format upto 10 characters
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage = "Please enter a valid Phone Number")]
        public required string Phone { get; set; } // Phone Number Field

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; } // Email Field

        public required ICollection<Order> Orders { get; set; } // Relationship for 1 Customer to Many Orders 
        public required ICollection<Cart> Carts { get; set; } // Relationship for 1 Customer to Many Carts

    }
}
