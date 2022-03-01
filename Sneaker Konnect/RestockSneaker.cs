using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sneaker_Konnect
{
    public partial class RestockSneaker : Form
    {
        private SneakerKonnect parent1;
        private ItemEntry shoeRestock;

        public RestockSneaker(SneakerKonnect parent1, ItemEntry shoeRestock)
        {

            this.parent1 = parent1;
            this.shoeRestock = shoeRestock;
            InitializeComponent();

        }

        private void restockSneakerButton_Click(object sender, EventArgs e)
        {
            int shoeStockUD = int.Parse(quantityTextBox.Text.ToString());
            InventoryManger.Restockshoe(shoeRestock.ShoeCollection.Shoe, shoeStockUD);
            parent1.RefreshAll();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestockSneaker_Load(object sender, EventArgs e)
        {
            if(shoeRestock == null)
            {
                MessageBox.Show("Select shoe to restock!");
                this.Close();
            }
            else
            {
                
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
