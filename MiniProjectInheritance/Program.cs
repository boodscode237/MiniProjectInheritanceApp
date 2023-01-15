using static System.Console;
namespace MiniProjectInheritance // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 52, ProductName = "Bugatti" };
            var book = new BookModel{ ProductName = "C# for newbies", NumberOfPages = 1210 };
            var excavator = new ExcavatorModel{ ProductName = "Bulldozer", QuantityInStock = 2 };
            
            rentables.Add(vehicle);
            rentables.Add(excavator);
            purchasables.Add(book);
            purchasables.Add(vehicle);
            
            Write("Do you want to rent or purchase: (rent, purchase) ");
            string decision = ReadLine();

            if (decision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    WriteLine($"item: {item.ProductName}");
                    WriteLine("Do you want to rent this item? (yes/no) ");
                    string wantToRent = ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }
                    
                    WriteLine("Do you want to return this item? (yes/no) ");
                    string wantToReturn = ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                    
                    
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    WriteLine($"Item: {item.ProductName}");
                    WriteLine("Do you want to purchase this item? (yes/no)");
                    string wantToPurchase = ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.purchase();
                    }
                    
                }
            }
            WriteLine("Done for this");
            ReadLine();
        }
    }
}