﻿namespace AuroraAuto.Models
{
    public class Category
    {
        public int Category_ID { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
