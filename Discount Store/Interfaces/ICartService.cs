using Discount_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount_Store.Interfaces
{
   public interface ICartService
    {
        void Add(Item item);
        void Remove(Item item);
        float GetTotal();
    }
}
