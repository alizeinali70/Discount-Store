using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Discount_Store.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string SKU { get; set; }
        public float Price { get; set; }
    }
}
