using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCashRegister {    
    static class Program {

        private static Foods.FoodRegistrar foodRegistrar;
        private static EatingAreas.ZoneRegistrar zoneRegistrar;

        private static Invoice.InvoiceManger invoiceManger;

        [STAThread]
        static void Main() {
            foodRegistrar = new Foods.FoodRegistrar();
            zoneRegistrar = new EatingAreas.ZoneRegistrar();
            invoiceManger = new Invoice.InvoiceManger();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Foods.FoodRegistrar GetFoodRegistrar() {
            return foodRegistrar;
        }

        public static EatingAreas.ZoneRegistrar GetZoneRegistrar() {
            return zoneRegistrar;
        }

        public static Invoice.InvoiceManger GetInvoiceManger() {
            return invoiceManger;
        }

    }
}
