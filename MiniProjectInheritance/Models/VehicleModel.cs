namespace MiniProjectInheritance;

public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
{
    public decimal DealerFee { get; set; }
    public void purchase()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This vehicle has been purchased");
    }

    public void Rent()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This vehicle has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock += 1;
        Console.WriteLine("This vehicle has been purchased");
    }
}