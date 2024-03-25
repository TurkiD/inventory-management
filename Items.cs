namespace ClassItem
{
    class Item
    {
        public string Name { get; }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private DateTime Date;

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
            return $"Items Name: {Name} Quantity: {Quantity} Date: {Date}";
        }

        public static void Main(string[] args)
        {
            var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));

            Console.WriteLine(waterBottle.ToString());

        }
    }
}