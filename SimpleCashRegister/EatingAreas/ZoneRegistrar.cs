using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister.EatingAreas {
    class ZoneRegistrar {

        private List<EatingZone> areas = new List<EatingZone>();
        // Creates a zone registrar to handle what happens for each zone.
        // Created so later down the road this can be expanded to add location variables
        public ZoneRegistrar() {
            areas.Add(new EatingZone("Zone 1", 2));
            areas.Add(new EatingZone("Zone 2", 3));
            areas.Add(new EatingZone("Zone 3", 4));
            areas.Add(new EatingZone("Eat In / Pickup", 0));

        }

        // Gets the zone by the defined name.
        // Will throw custom exception if there is an issue
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
