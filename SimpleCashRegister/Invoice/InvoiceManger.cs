using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister.Invoice {
    class InvoiceManger {

        private List<Item> items = new List<Item>();

        private String pickUpZoneName = "Eat In / Pickup";

        public InvoiceManger() {}

        public void ClearInvoice() {
            items.Clear();
        }

        public List<Item> GetInvoiceItems() {
            return items;
        }

        public void RemoveItem(String itemToRemove) {
            foreach (Item item in items) {
                if (item.GetItemName().ToLower().Equals(itemToRemove.ToLower())) {
                    items.Remove(item);
                }
            }
        }

        public void AddItem(String itemToAdd, int amount) {
            foreach (Item item in items) {
                if (item.GetItemName().ToLower().Equals(itemToAdd.ToLower())) {
                    item.AddMoreTo(amount);
                    return;
                }
            }
            // If we get here we need to create a new item
            items.Add(new Item(itemToAdd, amount));
        }

        public double GetSubtotal() {
            double cost = 0;
            foreach (Item item in items) {
                cost += item.GetAmount();
            }

            return cost;
        }

        public double GetDeliveryCost() {
            return Program.GetZoneRegistrar().GetZoneFromName(pickUpZoneName).GetCost();
        }

        public double GetSalesTax() {
            return (GetSubtotal() + GetDeliveryCost()) * 1.07; 
        }

        public double GetTotalCost() {
            return GetSubtotal() + GetDeliveryCost() + GetSalesTax();
        }

    }


}