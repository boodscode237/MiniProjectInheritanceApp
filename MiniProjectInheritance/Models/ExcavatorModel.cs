namespace MiniProjectInheritance;

public class ExcavatorModel : InventoryItemModel, IRentable
{
    public void Excav() => Console.WriteLine("I  am digging");
    public void Rent()
    {
        QuantityInStock -= 1;
        Console.WriteLine($"This excavator has been rented!");
    }

    public void ReturnRental()
    {
        QuantityInStock += 1;
        Console.WriteLine("The excavator was returned");
    }
}