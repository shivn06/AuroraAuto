namespace AuroraAuto.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public decimal PayAmount { get; set; }
        public string PayMethod { get; set; }
        public DateTime PayDate { get; set; }


        public required Customer Customer { get; set; }
        public required Order Order { get; set; }

    }
}
