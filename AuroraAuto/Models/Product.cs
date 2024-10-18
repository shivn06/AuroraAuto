using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuroraAuto.Models
{
    public class Product
    {
        public int ProductID { get; set; }//Primary Key

        [DisplayName("Category Name")]
        [Required]
        public int CategoryID { get; set; } // Foreign Key

        [Column(TypeName = "nvarchar(100)")] // The file name for the image cannot exceed 100 characters.
        [DisplayName("Product Image")]
        public string ImageName { get; set; } // Name for image file

        [DisplayName("Product Image")]
        [Required]
        [NotMapped] // Removes the content of a field from being mapped into the database.
        public IFormFile ProductImage { get; set; } // Creates an Upload Image field for Product Images

        [DisplayName("Product Name")]
        [Required]
        public string ProductName { get; set; } // Name of Product

        [Required]
        [DisplayName("Price")]
        [RegularExpression("^\\d{1,3}(\\.\\d{1,2})?$", ErrorMessage = "You have entered an incorrect value")] //Allows all positive numbers upto 999.99
        public decimal Price { get; set; } // Price of Product

        [Required]
        [DisplayName("Stock")]
        [RegularExpression("^(0|[1-9][0-9]{0,2})$", ErrorMessage = "You have entered an incorrect value")] // Allows only whole numbers upto 3 digits
        public decimal Stock { get; set; } //Stock field - shows inventory amount of product

        public Category Category { get; set; } // Pulls Primary Key of Category Table into Product Table as Foreign Key
        public ICollection<Cart> Carts { get; set; } // 1 side of 1 to many relationship to cart table
    }
}
