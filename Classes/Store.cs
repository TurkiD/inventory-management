using ClassItem;

namespace ClassStore
{
    class Store
    {
        private static List<ClassItem.Item> items = new List<ClassItem.Item> { };
        private int maxCapacity;
        public enum SortOrder
        {
            ASC,
            DEC
        }
        public Store(int maxCapacity)
        {
            this.maxCapacity = maxCapacity;
        }

        // add/delete items to/from the collection
        public void AddItem(Item item)
        {
            try
            {
                if (GetCurrentVolume() + item.Quantity > maxCapacity)
                {
                    throw new ArgumentOutOfRangeException();
                }
                ArgumentNullException.ThrowIfNull(item);

                bool isExist = items.Any((i) => i.Name == item.Name);
                if (isExist) { throw new ArgumentException(); }

                items.Add(item);
                Console.WriteLine($"Item {item.Name} Added");
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"ERROR: Quantity of The Item {item.Name} Is Exceeding The Store Limit");
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

        public void DeleteItem(Item item)
        {
            try
            {
                if (items.Count > 0)
                {
                    ClassItem.Item itemToBeDeleted = items.FirstOrDefault(i => i.Name == item.Name) ??
                    throw new ArgumentNullException();

                    items.Remove(itemToBeDeleted);
                    Console.WriteLine($"Item {itemToBeDeleted.Name} Deleted");
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"ERROR: Item Can Not Be Null");
            }
            catch (Exception)
            {
                Console.WriteLine($"ERROR: Can Not Delete Item From An Empty List");
            }
        }

        // Return the total amount of items
        public int GetCurrentVolume()
        {
            try
            {
                if (items.Count == 0)
                {
                    throw new Exception();
                }

                return items.Sum(item => item.Quantity);
            }
            catch (Exception)
            {
                Console.WriteLine($"ERROR: Item List Is Empty");
                return 0;
            }
        }

        // Need to improve
        public Item FindItemByName(Item item)
        {
            return items.FirstOrDefault(i => i.Name == item.Name) ?? throw new ArgumentNullException();
        }

        public List<Item> SortByNameAsc()
        {
            return items.OrderBy(item => item.Name).ToList();
        }

        public IEnumerable<Item> SortByDate(SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.ASC)
            {
                return items.OrderBy(item => item.Date);
            }
            return items.OrderByDescending(item => item.Date);
        }
    }
}