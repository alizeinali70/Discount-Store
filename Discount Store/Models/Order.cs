using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Discount_Store.Models
{
    public class Order
    {
      public List<Item> items = new List<Item>();
    }
}
