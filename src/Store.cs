class Store 
{
    private List<Item> _items;
    //CAN ADD NAME.
    public Store()
    {
        _items = new List<Item>();//yazan : _items=[];
    }
    public List<Item> GetItems()
    {
        return _items;
        // store.GetItems.Count???
    }
    public void AddItem(Item newItem)
    {
        // check whether new item (that you wanna add to _items, has the same name of the item in the array or not )
        // you can use Any() or Find() to check the name 
        if (!_items.Any(item => item.GetName() == newItem.GetName()))
        {
            _items.Add(newItem);
            Console.WriteLine($"Added: {newItem}");
        }
        else
        {
            Console.WriteLine($"You already have {newItem.GetName()}");
        }
    }
    public void Delete(Item item)
    {

        _items.Remove(item);
    }
    public int GetCurrentVolume()
    {
        // in C#, you can use method Sum() 
        int length = 0;
        _items.ForEach(Item =>
        {
            length += 1;
        });
        return length;
    }
    public Item? FindItemByName(string itemName)
    {
        // find() will find the first item of the array, if the item is found, stop
        // 
        return _items.Find(item => item.GetName() == itemName);
    }
    public List<Item> SortByNameAsc()
    {
        return _items;
    }
}


