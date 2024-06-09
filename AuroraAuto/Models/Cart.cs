namespace AuroraAuto.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int? Quantity { get; set; }
        public int? TotalPrice { get; set; }
        public int? CustomerID { get; set; }
        public int? ProductID { get; set; }

        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public Order Order { get; set; } = null!;
    }
}
