namespace ClassItems
{
    class Items
{
    public string Name { get; }
    private int quantity;
    public int Quantity 
    { 
        get { return quantity; } 
        set { quantity = value; }
    }
    private DateTime Date;

    public Items(string name, int quantity, DateTime date = default ) {
        if (quantity < 0)
        {
            Console.WriteLine($"Quantity can not be negative");
        }
        Name = name;
        Quantity = quantity;
        Date = date == default ? DateTime.Now : date;
    }

}
}