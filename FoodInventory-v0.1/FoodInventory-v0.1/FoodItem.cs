using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInventory_v0._1
{
    public class FoodItem
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public double Quantity { get; set; }
        public string QuantityType { get; set; }

        public DateTime Expiry { get; set; }
        public string ExpriyType { get; set; }

        public List<string> Tags = new List<string>();
    }
}
