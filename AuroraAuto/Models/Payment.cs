using System.ComponentModel.DataAnnotations;

namespace AuroraAuto.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        public decimal PayAmount { get; set; }
        public string PayMethod { get; set; }
        public DateTime PayDate { get; set; }


        public Order Order { get; set; }

    }
}
