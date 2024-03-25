class Program
{
    public static void Main(string[] args)
    {
        // items example - You do not need to follow exactly the same
        ClassItem.Item waterBottle = new ClassItem.Item("Water Bottle", 10, new DateTime(2023, 1, 1));
        ClassItem.Item chocolateBar = new ClassItem.Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
        ClassItem.Item notebook = new ClassItem.Item("Notebook", 5, new DateTime(2023, 3, 1));
        ClassItem.Item pen = new ClassItem.Item("Pen", 20, new DateTime(2023, 4, 1));
        ClassItem.Item tissuePack = new ClassItem.Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        ClassItem.Item chipsBag = new ClassItem.Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        ClassItem.Item sodaCan = new ClassItem.Item("Soda Can", 8, new DateTime(2023, 7, 1));
        ClassItem.Item soap = new ClassItem.Item("Soap", 12, new DateTime(2023, 8, 1));
        ClassItem.Item shampoo = new ClassItem.Item("Shampoo", 40, new DateTime(2023, 9, 1));
        ClassItem.Item toothbrush = new ClassItem.Item("Toothbrush", 50, new DateTime(2023, 10, 1));
        ClassItem.Item coffee = new ClassItem.Item("Coffee", 20);
        ClassItem.Item sandwich = new ClassItem.Item("Sandwich", 15);
        ClassItem.Item batteries = new ClassItem.Item("Batteries", 10);
        ClassItem.Item umbrella = new ClassItem.Item("Umbrella", 5);
        ClassItem.Item sunscreen = new ClassItem.Item("Sunscreen", 8);

        ClassStore.Store store = new ClassStore.Store();

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

        store.PrintItemList();
    }
}