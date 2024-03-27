enum SortOrder
{
    ASC,
    DESC
}
class Store<T> where T : Item
{
    private List<T> _items;
    private int _capacity;
    private readonly string _name;
    public Store(string name, int capacity)
    {
        _name = name;
        _capacity = capacity;
        _items = new List<T>();
    }
    public string GetName()
    {
        return _name;
    }
    public List<T> GetItems()
    {
        return _items;
    }
    public int GetCurrentVolume()
    {
        return _items.Sum(item => item.GetQuantity());
    }
    public void AddItem(T newItem)
    {
        if (GetCurrentVolume() + newItem.GetQuantity() >= _capacity)
        {
            throw new Exception("You reached the limit!.");
        }
        if (_items.Contains(newItem))
        {
            throw new Exception($"You already have {newItem.GetName()}");
        }
        _items.Add(newItem);
        Console.WriteLine($"Added:\n {newItem}");
    }
    public void Delete(T deletedItem)
    {
        T? deleted = _items.Find(item => item.GetName() == deletedItem.GetName());
        if (deleted is not null)
        {
            _items.Remove(deletedItem);
            Console.WriteLine($"{deletedItem.GetName()} is removed");
        }
        else
        {
            Console.WriteLine($"{deletedItem.GetName()} is not found");
        }
    }
    public List<T> SortByNameAsc()
    {
        var sorted = _items.OrderBy(item => item.GetName()).ToList();
        return sorted;
    }
    public void FindItemByName(string itemName)
    {
        T? found = _items.Find(item => item.GetName() == itemName);
        if (found is not null)
        {
            Console.WriteLine($"{found}");
        }
        else
        {
            Console.WriteLine($"{itemName} Not Found");
        }
    }
    public List<T> SortByDate(SortOrder sort)
    {
        if (sort is SortOrder.DESC)
        {
            var descSort = from item in _items
                           orderby item.GetDate() descending
                           select item;
            return descSort.ToList();
        }
        else if (sort is SortOrder.ASC)
        {
            var ascSort = from item in _items
                          orderby item.GetDate()
                          select item;
            return [.. ascSort];
        }
        else return _items;
    }
    public void GroupByDate()
    {
        var groupByMonth = (from item in _items
                            let currentDate = DateTime.Now
                            let category = (currentDate - item.GetDate()).TotalDays <= 90 ? "New Arrival Items" : "Old Items"
                            group item by category into newGroup
                            orderby newGroup.Key
                            select newGroup);
        foreach (var monthGroup in groupByMonth)
        {
            Console.WriteLine($"{monthGroup.Key} ( {monthGroup.Count()} ) : ");
            foreach (var item in monthGroup)
            {
                Console.WriteLine($" - {item.GetName()},\n Created: {item.GetDate()}\n");
            }
        }
    }
    public void Display(List<T>? listItems = null)
    {
        if (listItems is null)
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item.ToString() + '\n');
            }
        }
        else
        {
            foreach (var item in listItems)
            {
                Console.WriteLine(item.ToString() + '\n');
            }
        }
    }
    public List<T> SortByName(SortOrder sort)
    {
        if (sort is SortOrder.DESC)
        {
            var sorted = _items.OrderByDescending(item => item.GetName()).ToList();
            return sorted;
        }
        else
        {
            var sorted = _items.OrderBy(item => item.GetName()).ToList();
            return sorted;
        }
    }
}


