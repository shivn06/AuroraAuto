using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuroraAuto.Models
{
    public class Cart
    {
        public int CartID { get; set; }

        [DisplayName("Quantity")]
        [RegularExpression("^\\s*-?\\d{1,3}(\\.\\d{1,4})?\\s*$", ErrorMessage = "You have entered an incorrect value")]
        public int? Quantity { get; set; }

        [DisplayName("Total Price")]
        [RegularExpression("^\\s*-?\\d{1,3}(\\.\\d{1,4})?\\s*$", ErrorMessage = "You have entered an incorrect value")]
        public int? TotalPrice { get; set; }

        [DisplayName("Customer")]
        public int? CustomerID { get; set; }

        [DisplayName("Product Name")]
        public int? ProductID { get; set; }

        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
