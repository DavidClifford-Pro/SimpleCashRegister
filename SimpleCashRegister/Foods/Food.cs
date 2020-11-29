using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister.Foods {
    class Food {

        private String foodName;
        private double foodCost;
        private FoodTypes.FoodType foodType;
        
        public Food(String foodName, double cost, FoodTypes.FoodType foodType) {

            this.foodName = foodName;
            this.foodCost = cost;
            this.foodType = foodType;
        }

        public String GetFoodName() {
            return foodName;
        }

        public double GetFoodCost() {
            return foodCost;
        }

        public FoodTypes.FoodType GetFoodType() {
            return foodType;
        }

    }
}
