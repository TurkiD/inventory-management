namespace ClassItem
{
    class Item
    {
        public string Name { get; }
        public int Quantity
        {
            get ;
            private set ; 
        }
        public DateTime Date { get; }

        public Item(string name, int quantity, DateTime date = default)
        {
            if (quantity < 0)
            {
                Console.WriteLine($"Quantity can not be negative");
            }
            Name = name;
            Quantity = quantity;
            Date = date == default ? DateTime.Now : date;
        }

        public override string ToString()
        {
            return $"Items Name: {Name}, Quantity: {Quantity}, Date: {Date}";
        }

    }
}