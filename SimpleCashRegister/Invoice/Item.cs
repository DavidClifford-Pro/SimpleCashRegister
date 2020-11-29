using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister.Invoice {
    class Item {
        private String itemName;
        private int amount;

        private Foods.Food foodReference;

        // Items object for each item in the invoice so we can keep track of what's what.
        public Item(String itemName, int amount) {
            this.itemName = itemName;
            this.amount = amount;
            LocateReference();
        }

        public String GetItemName() {
            return itemName;
        }

        public int GetAmount() {
            return amount;
        }

        public void AddMoreTo(int amount) {
            this.amount += amount;
        }

        public Foods.Food GetReferenceFood() {
            return foodReference;
        }

        private void LocateReference() {
            this.foodReference = Program.GetFoodRegistrar().GetFoodFromName(itemName);
        }

    }
}