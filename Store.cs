namespace ClassStore
{
    class Store
    {
        private static List<ClassItem.Item> items = new List<ClassItem.Item> { };

        // Here start methods
        // add/delete items to/from the collection
        public void AddItemToList(ClassItem.Item item)
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
                Console.WriteLine($"ERROR: Item Already Exist");
            }
        }

        public void DeleteItme(ClassItem.Item item)
        {

        }
    }
}