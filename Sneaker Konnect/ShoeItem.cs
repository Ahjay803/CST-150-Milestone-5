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
    public partial class ShoeItem : Form
    {
        private SneakerKonnect parentForm;
        
        public ShoeItem(SneakerKonnect parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void shoesInStockLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void addSneakerButton_Click(object sender, EventArgs e)
        {
            string shoeCategory = shoeCategoryTextBox.Text;
            string shoe = shoeTextBox.Text;
            string shoeDesign = shoeDesignTextBox.Text;
            string color = colorTextBox.Text;
            int shoesInStock;

            if(int.TryParse(quantityTextBox.Text, out shoesInStock))
            {
                int shoeItem = (int)shoeItemComboBox.SelectedItem;
                InventoryItem item = new InventoryItem(shoeCategory, shoe, shoeDesign, color, shoesInStock);
                InventoryManger.AddItem(item);
                
                parentForm.RefreshAll();

                this.Close();
            }
            else
            {
                MessageBox.Show("Sneaker has been added!");
            }

        }

        private void ShoeItem_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                shoeItemComboBox.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
