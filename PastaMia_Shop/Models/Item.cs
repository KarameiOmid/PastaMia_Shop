using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastaMia_Shop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int QuntityInStock { get; set; }

    }
}
