using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuroraAuto.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
