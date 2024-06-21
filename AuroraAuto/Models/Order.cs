using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuroraAuto.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CartID { get; set; }
        public int PaymentID { get; set; }

        public Customer Customer { get; set; }
        public Cart Cart { get; set; }
        public Payment Payment { get; set; }
    }
}
