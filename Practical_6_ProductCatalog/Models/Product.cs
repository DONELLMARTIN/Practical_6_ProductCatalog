using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_6_ProductCatalog.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDetails { get; set; }
        public String productCategory { get; set; }
        public String ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public String productimg { get; set; }
    }
}