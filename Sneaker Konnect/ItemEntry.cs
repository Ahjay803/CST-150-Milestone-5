using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Konnect
{
    public class ItemEntry
    {
        private InventoryItem shoeCollection;
        private int shoesInstock = 10;
       

        public ItemEntry(InventoryItem shoeCollection)
        {
            this.shoeCollection = shoeCollection;
            this.shoesInstock = shoesInstock;
        }

        public override string ToString()
        {
            return shoeCollection.ToString() + " : " + shoesInstock;
        }
        public InventoryItem ShoeCollection{ get => shoeCollection; set => shoeCollection = value; }
        public int shoesInStock { get => shoesInstock; set => shoesInstock = value; }
     
    }
}
