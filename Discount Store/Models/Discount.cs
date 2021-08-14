using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Discount_Store.Models
{
    public class Discount
    {
        [Key]
        public int ID { get; set; }
        public int Item_ID { get; set; }
        public int Item_Count { get; set; }
        public float New_Price { get; set; }
    }
}
