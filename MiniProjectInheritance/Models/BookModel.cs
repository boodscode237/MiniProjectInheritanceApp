namespace MiniProjectInheritance;

public class BookModel : InventoryItemModel, IPurchasable
{
    public int NumberOfPages {get; set;}
    public void purchase()
    {
        QuantityInStock -= 1;
        Console.WriteLine("This book was purchased");
    }
}