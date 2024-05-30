namespace AuroraAuto.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string PImage { get; set; }
        public required string PName { get; set; }
        public required int Price { get; set; }
        public required int Stock { get; set; }
        public string CategoryID { get; set; }

        public Category Category { get; set; }
        public ICollection<Cart> Carts { get; set; }
    }
}
