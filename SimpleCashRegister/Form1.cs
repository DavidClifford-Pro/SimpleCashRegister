using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCashRegister {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) {
            String remove = "";
            foreach (ListViewItem item in listView1.SelectedItems) {
                listView1.Items.Remove(item);
                remove = item.Text;
                break;
            }
            if (remove != "") {
                Program.GetInvoiceManger().RemoveItem(remove);
            }
            UpdateCosts();
        }

        private void quantityLabel_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e) { }

        private void addToInvoiceButton_Click(object sender, EventArgs e) {
            // Add item to viewer

            // Check item variables for addition
            
            // Quantity
            decimal quantity = numericUpDown.Value;

            if (Convert.ToInt32(quantity) <= 0) {
                return;
            }

            // Name of item to add
            String itemName = "";

            if (burgerButton.Checked) {
                itemName = burgerButton.Text;
            }else if (friesRadio.Checked){
                itemName = friesRadio.Text;
            }else if (softDrinkRadio.Checked) {
                itemName = softDrinkRadio.Text;
            }else if (dessertRadio.Checked) {
                itemName = dessertRadio.Text;
            } else {
                Console.WriteLine("Error");
                return;
            }

           Invoice.Item returnedItem = Program.GetInvoiceManger().AddItem(itemName, Convert.ToInt32(quantity));

            // First check if the viewer has the item to begin with

                foreach (ListViewItem item in listView1.Items) {
                if (item.Text.Equals(itemName)) {
                    // We found it. Now we need to set a new value
                    listView1.Items.Remove(item);
                    ListViewItem item1 = new ListViewItem(itemName);
                    item1.SubItems.Add("" + returnedItem.GetAmount());
                    item1.SubItems.Add("$" + returnedItem.GetReferenceFood().GetFoodCost());
                    item1.SubItems.Add("$" + (returnedItem.GetAmount() * returnedItem.GetReferenceFood().GetFoodCost()));
                    listView1.Items.Add(item1);
                    UpdateCosts();
                    return;
                }
            }
            ListViewItem item2 = new ListViewItem(itemName);
            item2.SubItems.Add("" + returnedItem.GetAmount());
            item2.SubItems.Add("$" + returnedItem.GetReferenceFood().GetFoodCost());
            item2.SubItems.Add("$" + (returnedItem.GetAmount() * returnedItem.GetReferenceFood().GetFoodCost()));
            listView1.Items.Add(item2);
            UpdateCosts();

        }

        private void exitButton_Click(object sender, EventArgs e) {
            System.Environment.Exit(1);
        }

        private void burgerButton_CheckedChanged(object sender, EventArgs e) { }

        private void friesRadio_CheckedChanged(object sender, EventArgs e) { }

        private void clearButton_Click(object sender, EventArgs e) {
            // Clear invoice information
            Program.GetInvoiceManger().ClearInvoice();
            // Clear the table
            foreach (ListViewItem item in listView1.Items) {
                listView1.Items.Remove(item);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void UpdateCosts() {
            subtotalText.Text = "$" + Program.GetInvoiceManger().GetSubtotal();
            deliveryText.Text = "$" + Program.GetInvoiceManger().GetDeliveryCost();
            salesTaxText.Text = "$" + Program.GetInvoiceManger().GetSalesTax();
            totalText.Text = "$" + Program.GetInvoiceManger().GetTotalCost();
        }

        // Zone 1
        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            UpdatePickupLocation();
        }

        // Zone 2
        private void zone2Radio_CheckedChanged(object sender, EventArgs e) {
            UpdatePickupLocation();
        }

        // Zone 3
        private void zone3Radio_CheckedChanged(object sender, EventArgs e) {
            UpdatePickupLocation();
        }

        // Eat in / Pickup
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e) {
            UpdatePickupLocation();
        }

        private void UpdatePickupLocation() {
            if (zone1Radio.Checked) {
                Program.GetInvoiceManger().UpdateDeliveryLocation(zone1Radio.Text);
            }else if (zone2Radio.Checked) {
                Program.GetInvoiceManger().UpdateDeliveryLocation(zone2Radio.Text);
            }else if (zone3Radio.Checked) {
                Program.GetInvoiceManger().UpdateDeliveryLocation(zone3Radio.Text);
            } else {
                Program.GetInvoiceManger().UpdateDeliveryLocation(eatInRadio.Text);
            }
            UpdateCosts();
        }
    }
}
