// first, create an interface : base 
// from this, we create other classes that implements from base interface
// when using generics containts, we will apply this interface

using Microsoft.VisualBasic;

class Store<T> where T : Item
{
    private List<T> _items;
    private int _capacity;
    //CAN ADD NAME.
    public Store(int capacity)
    {
        _capacity = capacity;
        _items = new List<T>();//yazan : _items=[];
    }
    public List<T> GetItems()
    {
        return _items;
    }
    public void Display(List<T>? listItems = null)
    {
        if (listItems is null)
        {
            foreach (var item in _items)
            {
                Console.WriteLine('\n' + item.ToString() + '\n');
            }
        }
        else
        {
            foreach (var item in listItems)
            {
                Console.WriteLine('\n' + item.ToString() + '\n');
            }
        }
    }
    public void AddItem(T newItem)
    {
        if (GetCurrentVolume() + newItem.GetQuantity() >= _capacity)//!CHECK
        {
            Console.WriteLine("You reached the limit!.");
        }
        else
        {
            if (!_items.Any(item => item.GetName() == newItem.GetName()))// if(!_items.Contains(newItem)){ } //* other way?
            {
                _items.Add(newItem);
                Console.WriteLine($"Added: {newItem}");
            }
            else
            {
                Console.WriteLine($"You already have {newItem.GetName()}");
            }
        }
    }

    public List<T> SortByDate(string way) //!CHECK
    {
        if (way.Equals("desc", StringComparison.CurrentCultureIgnoreCase))
        {
            var descSort = from item in _items
                           orderby item.GetDate() descending
                           select item;
            return descSort.ToList();
        }
        else
        {
            var ascSort = from item in _items
                          orderby item.GetDate()
                          select item;
            return ascSort.ToList();
        }
    }
    public void GroupByDate()
    {
        var groupByMonth = from item in _items
                           group item by item.GetDate().Month into newGroup
                           orderby newGroup.Key
                           select newGroup;
        foreach (var monthGroup in groupByMonth)
        {
            Console.WriteLine($"Key: {monthGroup.Key}");
            foreach (var item in monthGroup)
            {
                Console.WriteLine($"\t{item}");
            }
        }
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
    public int GetCurrentVolume()
    {
        return _items.Sum(item => item.GetQuantity());
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
    public List<T> SortByNameAsc()
    {
        return _items.OrderBy(item => item.GetName()).ToList();

    }
}


