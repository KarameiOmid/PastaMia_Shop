using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastaMia_Shop.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quntity { get; set; }
        public decimal GetTotalPrice()
        {
            return Item.Price * Quntity;
        }
    }
}
