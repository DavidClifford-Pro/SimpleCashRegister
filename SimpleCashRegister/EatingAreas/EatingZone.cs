using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister.EatingAreas {
    class EatingZone {

        private String zoneName;
        private double zoneCost;

        public EatingZone(String zoneName, double cost) {
            this.zoneName = zoneName;
            this.zoneCost = cost;
        }

        public String GetZoneName() {
            return zoneName;
        }

        public double GetCost() {
            return zoneCost;
        }
    }
}
