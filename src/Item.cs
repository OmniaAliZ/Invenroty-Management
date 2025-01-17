class Item
{
    private int _id;
    private static int _counter = 0;
    private readonly string _name;
    private int _quantity { get; set; }
    private DateTime _date { get; } //? _createdAt OR _createdDate
    // public Item(string name, int quantity)
    // {
    //     _name = name;
    //     _quantity = quantity;
    //     _date = DateTime.Now;//.AddMilliseconds;
    // }
    // public Item(string name, int quantity, DateTime dateTime)
    // {
    //     _name = name;
    //     _quantity = quantity;
    //     _date = dateTime;
    // }
    public Item(string name, int quantity, DateTime dateTime = default)
    {
        if (quantity < 0) throw new ArgumentException("Quantity should be greater than 0! ");
        _name = name;
        _quantity = quantity;
        _id = Interlocked.Increment(ref _counter);
        _date = dateTime == default ? DateTime.Now : dateTime;// _date = dateTime is null ? DateTime.Now : (DateTime)dateTime; >>Arg:(..,..,DateTime? dateTime = null)
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetQuantity(int quantity)
    {
        if (quantity < 0) throw new ArgumentException("Quantity should be greater than 0! ");
        _quantity = quantity;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public override string? ToString()
    {
        return $"Item ({_id}) \nName:  {_name}\nQuantity:  {_quantity}\nCreated date:  \n{_date}\n";
    }
}
