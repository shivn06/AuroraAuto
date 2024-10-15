using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuroraAuto.Models
{
    public class Category
    {
        [Key] // "Key" attribute forces Asp.net to recognise this field as Primary Key for the Table created from this Model
        public int CategoryID { get; set; }

        [DisplayName("Category Name")] // this is the name that is displayed above the input box on the frontend
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } // reference to Product Model for 1 to many relationship from category table to product table
    }
}
