using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuroraAuto.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [DisplayName("Category Name")]
        [Required]
        public string CategoryID { get; set; }

        [DisplayName("Product Image")]
        [Required]
        public string ProductImage { get; set; }

        [DisplayName("Product Name")]
        [Required]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }

        public Category Category { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
