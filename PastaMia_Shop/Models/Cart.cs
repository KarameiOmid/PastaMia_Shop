using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastaMia_Shop.Models
{
    public class Cart
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public int OrderId { get; set; }
        public List<CartItem> CartItems { get; set; }


        public void AddItem(CartItem item)
        {
            if (CartItems.Exists(x => x.Item.Id == item.Id))
            {
                CartItems.Find(x => x.Item.Id == item.Id)
                    .Quntity += 1;
            }
            else
            {
                CartItems.Add(item);
            }
        }

        public void RemoveItem(int itemId)
        {
            var item = CartItems
                .SingleOrDefault(c => c.Item.Id == itemId);
            if (item?.Quntity <= 1)
            {
                CartItems.Remove(item);
            }
            else if (item != null)
            {
                item.Quntity -= 1;
            }
        }

    }
}
