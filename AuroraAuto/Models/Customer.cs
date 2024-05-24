using System.Drawing;

namespace AuroraAuto.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Address { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }

        public required ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
