namespace AuroraAuto.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int CustomerID { get; set; }
        public decimal Pay_Amount { get; set; }
        public string Pay_Method { get; set; }
        public DateTime Pay_Date { get; set; }


        public Customer Customer { get; set; }
        public Order Order { get; set; }

    }
}
