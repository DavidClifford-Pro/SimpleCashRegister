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

        public void UpdateDeliveryLocation(String newLocation) {
            this.pickUpZoneName = newLocation;
        }

        public void RemoveItem(String itemToRemove) {
            Item located = null;
            foreach (Item item in items) {
                if (item.GetItemName().ToLower().Equals(itemToRemove.ToLower())) {
                    located = item;
                    break;
                }
            }
            if (located != null) {
                items.Remove(located);
            }
        }

        public Item AddItem(String itemToAdd, int amount) {
            foreach (Item item in items) {
                if (item.GetItemName().ToLower().Equals(itemToAdd.ToLower())) {
                    item.AddMoreTo(amount);
                    Console.WriteLine("Added: " + itemToAdd + " amount: " + amount);
                    return item;
                }
            }
            // If we get here we need to create a new item
            Item i = new Item(itemToAdd, amount);
            items.Add(i);
            Console.WriteLine("Added: " + itemToAdd + " amount: " + amount);
            return i;
            
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
            return (GetSubtotal() + GetDeliveryCost()) * .07; 
        }

        public double GetTotalCost() {
            return GetSubtotal() + GetDeliveryCost() + GetSalesTax();
        }

    }


}