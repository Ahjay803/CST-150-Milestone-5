using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Konnect
{
    class InventoryManger
    {
        private static List<ItemEntry> shoeCollection = new List<ItemEntry>();



        public static void AddItem(InventoryItem shoeCategory)
        {
            if (shoeCollection.Count == 0)
            {
                shoeCollection.Add(new ItemEntry(shoeCategory));
                return;
            }

            for (int i = 0; i < shoeCollection.Count; i++)
            {
                ItemEntry entry = shoeCollection[i];
                if (entry.ShoeCollection.Shoe == shoeCategory.Shoe)
                {
                    Console.WriteLine("Shoe Already exists.");
                    Console.ReadLine();
                   
                    return;
                }
            }
            shoeCollection.Add(new ItemEntry(shoeCategory));
        }

        public static void RemoveItem(String shoe)
        {
            for (int i = 0; i < shoeCollection.Count; i++)
            {
                ItemEntry entry = shoeCollection[i];
                if (entry.ShoeCollection.Shoe == shoe)
                {
                    shoeCollection.RemoveAt(i);
                }
            }
        }

        public static void Restockshoe(String shoe, int update)
        {
            for (int i = 0; i < shoeCollection.Count; i++)
            {
                ItemEntry entry = shoeCollection[i];
                if (entry.ShoeCollection.Shoe == shoe)
                {
                    if (entry.shoesInStock + update >= 0)
                    {
                        entry.shoesInStock += update;
                    }
                }
            }
        }

        public static void DisplayShoes()
        {
            for (int i = 0; i < shoeCollection.Count; i++)
            {
                ItemEntry entry = shoeCollection[i];
                Console.WriteLine(entry);
                
            }
        }

        public static List<ItemEntry> GetItems()
        {
            return shoeCollection;
        }

        public static List<ItemEntry> Searchshoe (string shoe)
        {
            List<ItemEntry> foundShoe = new List<ItemEntry>();
            for(int i = 0; i < shoeCollection.Count; i++)
            {
                ItemEntry entry = shoeCollection[i];
                if(entry.ShoeCollection.Shoe == shoe)
                {
                    foundShoe.Add(entry);
                }
            }

            return foundShoe;
        }

        public static List<ItemEntry> SearchShoeColor (string color)
        {
            List<ItemEntry> foundShoe = new List<ItemEntry>();
            for (int i = 0; i < shoeCollection.Count; i++)
            {
                ItemEntry entry = shoeCollection[i];
                if (entry.ShoeCollection.Color == color)
                {
                    foundShoe.Add(entry);
                }
            }

            return foundShoe;
        }



    }
}
