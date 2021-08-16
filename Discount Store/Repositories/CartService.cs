using Discount_Store.Data;
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
        private readonly ApplicationDbContext _db;

        public CartService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Item item)
        {
            _db.Add(item);
            _db.SaveChanges();
        }
        public void Remove(Item item)
        {
            var selected_item = _db.Items.FirstOrDefault(x => x.SKU == item.SKU);
            if (selected_item != null)
            {
                _db.Remove(selected_item);
                _db.SaveChanges();
            }
        }
        public float GetTotal()
        {
            var all_orders = _db.Items.ToList();
            float total = 0;
            var vaseCount = all_orders.Where(x => x.SKU == "Vase").Count();
            var bigmugCount = all_orders.Where(x => x.SKU == "Big mug").Count();
            var NapkinspackCount = all_orders.Where(x => x.SKU == "Napkins pack").Count();

            foreach (var item in all_orders)
            {
                if (bigmugCount >= 2)
                {
                    if (item.SKU == "Big mug")
                        item.Price = (float)(0.75);
                }

                if (NapkinspackCount >= 3)
                {
                    if (item.SKU == "Napkins pack")
                        item.Price = (float)(0.30);
                }

                total += item.Price;
            }

            return total;
        }
      
    }
}
