﻿using System.ComponentModel;

namespace AuroraAuto.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
