using System;
public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Initialized the properties with the values
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // Item price update with new price
        this.Price = newPrice;

    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // Increasing the stock when in adding additionalquantity
        this.QuantityInStock += additionalQuantity;
       
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {

        if (this.QuantityInStock == 0)
        {
            //If there are no items available in stock ,  display out of stock message.
            Console.WriteLine("Out of stock");
        }

        else
        {
            //decreasing the item stock by the quantity sold.
            this.QuantityInStock -= quantitySold;
        }
    }

    
    public bool IsInStock()
    {
        //Checking items are in stock

        if (QuantityInStock > 0)
        {
            return true;
            
        }
        return false;
    }

    // Print item details
    public void PrintDetails()
    {
        // Print Name
         Console.WriteLine($"Name:{this.ItemName}");

        //Print Id
        Console.WriteLine($"Id:{this.ItemId}");

        //Print Price
        Console.WriteLine($"Price:{this.Price}");

        //Print StockQuantity
        Console.WriteLine($"StockQuantity:{this.QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

      
        // Print Details for Item1 , Item2
        item1.PrintDetails();
        Console.WriteLine();
        item2.PrintDetails();
        Console.WriteLine("-------------");

        // Printing details after selling item1 , item2



        item1.SellItem(4);
        item1.PrintDetails();

        Console.WriteLine();

        item2.SellItem(5);
        item2.PrintDetails();
        Console.WriteLine("-------------");

        // Printing details after restocked Item1
        
        item1.RestockItem(1);
        item1.PrintDetails();
        Console.WriteLine("-------------");

        // Checking stock availability
        if (item2.IsInStock()==true)
        {
            Console.WriteLine("Item is available");
        }

        else
        {
            Console.WriteLine("Item is not available");
        }
        
    }
}
