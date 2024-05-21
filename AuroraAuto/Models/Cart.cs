namespace AuroraAuto.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
    }
}
