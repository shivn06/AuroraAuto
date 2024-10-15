using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuroraAuto.Models
{
    public class Cart
    {
        public int CartID { get; set; } //Primary Key/ID field

        [DisplayName("Quantity")] 
        [RegularExpression("^(0|[1-9][0-9]{0,2})$", ErrorMessage = "You have entered an incorrect value")] // Allows only whole numbers upto 3 digits
        public int? Quantity { get; set; } // Cart Item Quantity field. 

        [DisplayName("Total Price")]
        [RegularExpression("^\\d{1,3}(\\.\\d{1,2})?$", ErrorMessage = "You have entered an incorrect value")] //Allows all positive numbers upto 999.99
        public int? TotalPrice { get; set; } // Total Price field of all items in cart

        [DisplayName("Customer")]
        public int? CustomerID { get; set; } // Foreign Key to Customer Table

        [DisplayName("Product Name")]
        public int? ProductID { get; set; } // Foreign Key to Product Table

        // The ? mark after the int datatype on all fields indicates that the field can be null as the cart can be left empty

        public Customer Customer { get; set; } = null!; // Reference to Customer table for foreign key
        public Product Product { get; set; } = null!;  // Reference to Product table for foreign key
    }
}
