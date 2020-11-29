using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister.EatingAreas {
    class ZoneRegistrar {

        private List<EatingZone> areas = new List<EatingZone>();
        public ZoneRegistrar() {
            areas.Add(new EatingZone("Delivery Zone 1", 2));
            areas.Add(new EatingZone("Delivery Zone 2", 3));
            areas.Add(new EatingZone("Delivery Zone 3", 4));
            areas.Add(new EatingZone("Eat In / Pickup", 0));

        }

        public EatingZone GetZoneFromName(String zoneName) {
            foreach (EatingZone zone in areas) {
                if (zone.GetZoneName().ToLower() == zoneName.ToLower()) {
                    return zone;
                }

            }
            throw new NotValidItemException(zoneName.ToLower());

        }
    }
}
