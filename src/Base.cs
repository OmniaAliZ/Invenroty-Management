public class Base {
    private readonly string _name;
    private int _quantity;
    private DateTime _date { get; }

    public Base(string name, int quantity, DateTime dateTime = default)
    {
        if (quantity < 0) throw new ArgumentException("Quantity should be greater than 0! ");
        _name = name;
        _quantity = quantity;
        _date = dateTime == default ? DateTime.Now : dateTime;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetQuantity(int quantity){
        _quantity = quantity;
    }
    public int GetQuantity(){
        return _quantity;
    }
}