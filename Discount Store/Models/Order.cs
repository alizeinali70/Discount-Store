using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Discount_Store.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public Item Item { get; set; }
        public Discount Discount { get; set; }
    }
}
