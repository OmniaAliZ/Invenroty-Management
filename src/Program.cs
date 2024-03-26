namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
            Console.WriteLine($"waterBottle {waterBottle}");

            var apple = new Item("Apple", 10, default);
            Console.WriteLine($"waterBottle {apple}");
            var mango = new Item("Mango", 10, new DateTime(2024, 1, 5));
            var laptop = new Item("Lap Top", 10, new DateTime(2020, 2, 5));
            // var laptop = new Item("Laptop", -50, new DateTime(2023, 1, 1));
            // Console.WriteLine($"waterBottle {laptop}");

            Store<Item> store = new(50);
            Console.WriteLine(store.GetItems().Count);
            store.AddItem(waterBottle);
            store.AddItem(waterBottle);
            store.AddItem(apple);
            store.AddItem(mango);
            store.AddItem(laptop);
            Console.WriteLine(store.GetItems().Count);
            List<Item> s = store.SortByNameAsc();
            store.Display(s);
            Console.WriteLine("++++++++++++++");
            List<Item> d = store.SortByDate(SortOrder.ASC);
            store.Display(d);
            Console.WriteLine("++++++++++++++++");
            store.Display(store.SortByDate(SortOrder.DESC));
            Console.WriteLine("++++++++++++++++");
            Console.WriteLine("GROUP DATE");
            store.GroupByDate();
            Console.WriteLine("++++++++++++++++");
            Console.WriteLine("count: " + store.GetCurrentVolume());
            store.FindItemByName("Water Bottle");
            store.FindItemByName("Apple");
            store.Display();
            store.Delete(apple);
            store.Display();
            Console.WriteLine("count: " + store.GetCurrentVolume());
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


