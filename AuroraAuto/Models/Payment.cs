using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuroraAuto.Models
{
    public enum Method // Enum list to create a dropdown, limiting inputs to valid data only
    {
        [Display(Name = "Credit Card")]
        CreditCard,
        [Display(Name = "Apple Pay")]
        ApplePay,
        [Display(Name = "Google Pay")]
        GooglePay,
        [Display(Name = "AfterPay")]
        Afterpay
    }
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; } // Primary key for each payment made

        [Required]
        [DisplayName("Pay Amount")]
        [RegularExpression("^\\d{1,3}(\\.\\d{1,2})?$", ErrorMessage = "You have entered an incorrect value")] //Allows all positive numbers upto 999.99
        public decimal PayAmount { get; set; } //payment amount on order

        [Required]
        [DisplayName("Pay Method")]
        public required Method PayMethod { get; set; } // Enum list field

        [Required]
        [DisplayName("Pay Date")]
        public DateTime PayDate { get; set; }

    }
}
