using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuroraAuto.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; } //Primary key for order creation

        [Required]
        [DisplayName("Customer")]
        public int CustomerID { get; set; } // Foreign key for the Customer that the order is linked to

        [Required]
        [DisplayName("Cart")]
        public int CartID { get; set; } // Foreign Key for cart which order is coming from

        [Required]
        [DisplayName("Payment")]
        public int PaymentID { get; set; } // Foreign key referencing the payment which was used for each order

        public Customer Customer { get; set; } // many side of 1 to many relationship to customer table
        public Cart Cart { get; set; } // many side of 1 to many relationship to cart table
        public Payment Payment { get; set; } // many side of 1 to many relationship to payment table
    }
}
