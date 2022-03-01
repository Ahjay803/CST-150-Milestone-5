using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Sneaker_Konnect
{
    public partial class SneakerKonnect : Form
    {
       
        
        public SneakerKonnect()
        {
            InitializeComponent();
        }

        private void addSneakerButton_Click(object sender, EventArgs e)
        {
            ShoeItem myShoeItem = new ShoeItem(this);
            myShoeItem.ShowDialog();

            
        }

        public void RefreshAll()
        {
            sneakerKonnectListBox.Items.Clear();
            List<ItemEntry> addShoe = InventoryManger.GetItems();
            foreach(ItemEntry tlist in addShoe)
            {
               sneakerKonnectListBox.Items.Add(tlist);
            }
            this.Refresh();
        }

        private void restockSneakerButton_Click(object sender, EventArgs e)
        {
            RestockSneaker myRestockSneaker = new RestockSneaker(this, (ItemEntry) sneakerKonnectListBox.SelectedItem);
            myRestockSneaker.ShowDialog();
        }

        private void searchSneakerButton_Click(object sender, EventArgs e)
        {
            if (searchComboBox.SelectedItem == "shoe")
            {
                sneakerKonnectListBox.Items.Clear();
                List<ItemEntry> foundshoe = InventoryManger.Searchshoe(searchTextBox.Text);
                for(int i = 0; i < foundshoe.Count; i++)
                {
                    sneakerKonnectListBox.Items.Add(foundshoe[i]);
                }
            }
            if (searchComboBox.SelectedItem == "color")
            {
                sneakerKonnectListBox.Items.Clear();
                List<ItemEntry> foundshoe = InventoryManger.SearchShoeColor(searchTextBox.Text);
                for (int i = 0; i < foundshoe.Count; i++)
                {
                    sneakerKonnectListBox.Items.Add(foundshoe[i]);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeSneakerButton_Click(object sender, EventArgs e)
        {
            ItemEntry removeShoe = (ItemEntry)sneakerKonnectListBox.SelectedItem;
            InventoryManger.RemoveItem(removeShoe.ShoeCollection.Shoe);
            RefreshAll();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sneakerKonnectListBox.Items.Clear();
            RefreshAll();
        }

        private void SneakerKonnect_Load(object sender, EventArgs e)
        {

        }

        private void editSneakerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
