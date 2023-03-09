using PharmacyMedicine.Models;

Pharmacy pharmacy = new Pharmacy("Aptek Zeferan");
bool status = true;
while (status)
{
    Console.WriteLine("\n1.Add Medicinies\n" +
        "2.Show Medicinies\n" +
        "3.Show Medicinies via Category\n"+
        "q Quit");
    Console.Write("Please enter step Number : ");
    string step = Console.ReadLine();

    switch (step)
    {
        case "1":
            pharmacy.AddMedicine();
            Console.WriteLine("Added Medicine");
            break;
        case "2":
            if (pharmacy.MedicineCount == 0)
            {
                Console.WriteLine("Count of Medicine is null.Please add Medicine");
                break;
            }
            pharmacy.ShowMedicines();
            break;
            case "3":
            if (pharmacy.MedicineCount == 0)
            {
                Console.WriteLine("Count of Medicine is null.Please add Medicine");
                break;
            }
            Console.Write("Please enter Category : ");
            string category = Console.ReadLine();
            pharmacy.ShowMedicines(category);
            break;
        case "q":
            Console.WriteLine("Exiting....");
            status = false;
            break;
        default:
            break;
    }
}
