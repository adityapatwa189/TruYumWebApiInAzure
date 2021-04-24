using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruYumWebApiInAzure.ViewModels
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool FreeDelivery { get; set; }
        public double Price { get; set; }
    }
}
