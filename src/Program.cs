namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
            Console.WriteLine($"waterBottle {waterBottle}");


            // var laptop = new Item("Laptop", -50, new DateTime(2023, 1, 1));
            // Console.WriteLine($"waterBottle {laptop}");

            Store store = new();
            Console.WriteLine(store.GetItems().Count);
            store.AddItem(waterBottle);
            Console.WriteLine(store.GetItems().Count);
            // var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
            // var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
            // var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
            // var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
            // var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
            // var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
            // var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
            // var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
            // var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
            // var coffee = new Item("Coffee", 20);
            // var sandwich = new Item("Sandwich", 15);
            // var batteries = new Item("Batteries", 10);
            // var umbrella = new Item("Umbrella", 5);
            // var sunscreen = new Item("Sunscreen", 8);
        }
    }
}


// in store , there will be an array of _items, that contains Item object
// _items = [Item, Item, Item]
// _items = [{name: "laptop" , 20, default}, {name: "mac mini" , 20, "2024-03-24"}]
// one of the staff they wanna add new item = {name: "laptop" , 24, default}


