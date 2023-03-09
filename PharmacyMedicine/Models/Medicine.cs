using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyMedicine.Models
{
    internal class Medicine
    {
        public string Name;
        public string Category;
        public int Price;

        public Medicine(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
