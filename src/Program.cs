﻿namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
            var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
            var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
            var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
            var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
            var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
            var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
            var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
            var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
            var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
            var coffee = new Item("Coffee", 20);
            var sandwich = new Item("Sandwich", 15);
            var batteries = new Item("Batteries", 10);
            var umbrella = new Item("Umbrella", 5);
            var sunscreen = new Item("Sunscreen", 8);

            var store = new Store<Item>("Wish", 300);

            Console.WriteLine("++++++++++++++++");
            store.AddItem(waterBottle);
            store.AddItem(chocolateBar);
            store.AddItem(notebook);
            store.AddItem(pen);
            store.AddItem(tissuePack);
            store.AddItem(chipsBag);
            store.AddItem(sodaCan);
            store.AddItem(soap);
            store.AddItem(shampoo);
            store.AddItem(toothbrush);
            store.AddItem(coffee);
            store.AddItem(sandwich);
            store.AddItem(batteries);
            store.AddItem(umbrella);
            store.AddItem(sunscreen);
            Console.WriteLine("++++++++++++++++");

            var collectionSortedByDate = store.SortByDate(SortOrder.DESC);
            store.Display(collectionSortedByDate);
            Console.WriteLine("++++++++++++++++");

            store.GroupByDate();
            Console.WriteLine("++++++++++++++++");

            // store.Display(store.SortByDate(SortOrder.DESC));
            // Console.WriteLine("++++++++++++++++");

            // int page = 1, itemsPerPage = 4, currentPage =(page -1)* itemsPerPage;
            // var items = store.GetItems();
            // var paginated = items
            // .Select(i => i)
            // .Skip(1)//starting item
            // .Take(4);//items per page

            // foreach (var item in paginated)
            // {
            //     System.Console.WriteLine(item.GetName() + '\n' + item.GetQuantity());
            // }
        }
    }
}


