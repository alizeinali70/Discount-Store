using Discount_Store.Interfaces;
using Discount_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount_Store.Repositories
{
    public class CartService : ICartService
    {
        Order order = new Order();

        public void Add(Item item)
        {
            order.items.Add(item);
        }
        public void Remove(Item item)
        {
            throw new NotImplementedException();
        }
        public double GetTotal()
        {
            throw new NotImplementedException();
        }
    }
}
