using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Konnect
{
    public class InventoryItem
    {
        private string shoe;
        private string shoeDesign;
        private string color;
        private string shoeCategory;

        private int shoesInStock;

        

        public InventoryItem(string shoeCategory, string shoe, string shoeDesign, string color, int shoesInStock)
        {

            this.shoe = shoe;
            this.shoeDesign = shoeDesign;
            this.color = color;
            this.shoesInStock = shoesInStock;
            this.shoeCategory = shoeCategory;

        }

        public string ShoeCategory { get => shoeCategory; set => shoeCategory = value; }
        public string Shoe { get => shoe; set => shoe = value; }
        public string ShoeDesign { get => shoeDesign; set => shoeDesign = value; }
        public string Color { get => color; set => color = value; }
        public int ShoesInStock { get => shoesInStock; set => shoesInStock = value; }

        public override string ToString()
        {
            return shoeCategory + " : " + shoe + " : " + shoeDesign + " : " + color;
        }

        public string shoeDetails()
        {
            return "Shoe Category: " + shoeCategory + " Shoe: " + shoe + " Shoe Design: " + shoeDesign + " Color: " + color + "Shoes in Stock: " + shoesInStock;
        }
        
     

        

        
    }
}
