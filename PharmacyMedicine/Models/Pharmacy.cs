using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyMedicine.Models
{
    internal class Pharmacy
    {
        public string Name;
        public Medicine[] medicines = { };
        public int MedicineCount = 0;

        public Pharmacy(string name) { 
            Name = name;
        }

       public  Medicine[] AddMedicine()
        {
            Array.Resize(ref medicines, MedicineCount+1);
            Console.Write("Enter Medicine Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Category : ");
            string category = Console.ReadLine();
            Console.Write("Enter Price : ");
            int price = 0;
            try
            {
                 price = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Price must be digits!!!");
            }
            
            while(!CheckNamePrice(name, price))
            {
                Console.WriteLine("Again!!!");
                Console.Write("Enter Medicine Name : ");
                name = Console.ReadLine();
                Console.Write("Enter Category : ");
                category = Console.ReadLine();
                Console.Write("Enter Price : ");
                try
                {
                    price = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Price must be digits!!!");
                }
            }
            medicines[MedicineCount] = new Medicine(name,category, price);
            MedicineCount++;
            return medicines;
        }
        public void ShowMedicines()
        {
            foreach (Medicine medicine in medicines)
            {
                Console.WriteLine("Medicine Name : " + medicine.Name + " Category : "+ medicine.Category + " Price : "+ medicine.Price);
            }
        }
       public  void ShowMedicines(string category)
        {
            int count = 0;
            foreach (Medicine medicine in medicines)
            {
                if(category == medicine.Category)
                {
                    Console.WriteLine("Medicine Name : " + medicine.Name + " Category : " + medicine.Category + " Price : " + medicine.Price);
                    count++;
                }             
            }
            if(count == 0)
            {
                Console.WriteLine("Bele category uzre derman tapilmadi");
                Console.WriteLine("Hazirki categoryiler : ");
                foreach (Medicine medicine in medicines)
                {
                    Console.WriteLine(medicine.Category);
                }
            }
        }

        bool CheckNamePrice(string name,int price)
        {
            if(name.Length  < 3) return false;
            if(price <= 0) return false;

            return true;
        }

    }
}
