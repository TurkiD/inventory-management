using ClassItem;
using ClassStore;
class Program
{
    public static void Main(string[] args)
    {
        // items example - You do not need to follow exactly the same
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
        var shoes = new Item("Nike", 300);

        var store = new Store(300);

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
        store.AddItem(shoes);

        store.DeleteItem(sunscreen);

        Console.WriteLine($"\nNumber of Items:\n {store.GetCurrentVolume()}");

        Console.WriteLine($"Items Searched:\n {store.FindItemByName(umbrella)}");

        Console.WriteLine();

        var sortedItems = store.SortByNameAsc();
        Console.WriteLine($"Sorted Items by name: ");
        foreach (var item in sortedItems)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine();

        var sortByDate = store.SortByDate(Store.SortOrder.Descending);
        foreach (var item in sortByDate)
        {
            Console.WriteLine($"{item}");

        }

        Console.WriteLine();

        var groupByDate = store.GroupByDate();
        foreach (var group in groupByDate)
        {
            if (group.Count > 0)
            {
                if (group == groupByDate[0])
                {
                    Console.WriteLine("New Arrival Items:");
                }
                else
                {
                    Console.WriteLine("Old Items:");
                }
                foreach (var item in group)
                {
                    Console.WriteLine($" - {item.Name}, Created: {item.Date.ToShortDateString()}");
                }
            }
        }
    }
}