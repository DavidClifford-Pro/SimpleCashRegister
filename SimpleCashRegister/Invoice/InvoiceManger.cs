using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister.Invoice {
    class InvoiceManger {

        // This allows us to see the different items on the current order

        private double salesTax = 0.07;

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

        // Add an item to the order
        // If the item already is on the order, it will add more amount to the object.
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


        /*
         * Below here gets all the math values for us 
         * Subtotal
         * Delivery
         * Sales tax
         * Total cost
         */

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
            return (GetSubtotal() + GetDeliveryCost()) * salesTax;
        }

        public double GetTotalCost() {
            return GetSubtotal() + GetDeliveryCost() + GetSalesTax();
        }

    }


}