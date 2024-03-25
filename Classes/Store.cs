namespace ClassStore
{
    class Store
    {
        private static List<ClassItem.Item> items = new List<ClassItem.Item> { };

        // Here start methods
        // add/delete items to/from the collection
        public void AddItem(ClassItem.Item item)
        {
            try
            {
                if (item == null) { throw new ArgumentNullException(); }

                if (items.Contains(item)) { throw new ArgumentException(); }

                items.Add(item);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"ERROR: Item Can Not Be Null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"ERROR: Item {item.Name} Already Exist");
            }
        }

        public void DeleteItem(ClassItem.Item item)
        {
            try
            {
                if (!items.Contains(item)) { throw new ArgumentException(); }

                items.Remove(item);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"ERROR: Item {item.Name} Not Exist");
            }
        }

        // public override string ToString()
        // {
        //     return string.Join("\n", items);
        // }

        public void PrintItemList() {
            foreach (var item in items)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}