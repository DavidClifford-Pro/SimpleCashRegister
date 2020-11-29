using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegister.Foods {
    class FoodRegistrar {

        private List<Food> foods = new List<Food>();

        // Creates a food registrar so we can keep track of all the different foods we offer
        public FoodRegistrar() {
            foods.Add(new Food("Burger", 5.99, FoodTypes.FoodType.FOOD));
            foods.Add(new Food("Fries", 2.99, FoodTypes.FoodType.FOOD));
            foods.Add(new Food("Soft Drink", 1.99, FoodTypes.FoodType.DRINK));
            foods.Add(new Food("Dessert", 2.99, FoodTypes.FoodType.FOOD));
        }

        // Gets the food object from the defined name
        // If we don't serve the food a custom exception will be thrown
        public Food GetFoodFromName(String foodName) {

            foreach (Food food in foods) {
                if (food.GetFoodName().ToLower().Equals(foodName.ToLower())) {
                    return food;
                }

            }
            throw new NotValidItemException(foodName.ToLower());

        }

    }
}
