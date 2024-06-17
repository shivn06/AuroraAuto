namespace AuroraAuto.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public decimal PayAmount { get; set; }
        public string PayMethod { get; set; }
        public DateTime PayDate { get; set; }


        public required Order Order { get; set; }

    }
}
