namespace AuroraAuto.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CartID { get; set; }
        public int PaymentID { get; set; }
        public Payment? Payment { get; set; }

        public Customer Customer { get; set; }

        public Cart Cart { get; set; }
    }
}
