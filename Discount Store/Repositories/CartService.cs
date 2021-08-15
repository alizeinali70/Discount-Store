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
            _db.Remove(selected_item);
            _db.SaveChanges();
        }
        public double GetTotal()
        {
            var all_orders = _db.Items.ToList();
            double total = 0;
            var vaseCount = all_orders.Where(x => x.SKU == "Vase").Count();
            var bigmugCount = all_orders.Where(x => x.SKU == "Big mug").Count();
            var NapkinspackCount = all_orders.Where(x => x.SKU == "Napkins pack").Count();
            
            foreach (var item in all_orders)
            {

            }

            return total;
        }
    }
}
