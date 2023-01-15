namespace MiniProjectInheritance;

public class InventoryItemModel: IInventoryItem
{
    public int QuantityInStock { get; set; }
    public string ProductName { get; set; }
}