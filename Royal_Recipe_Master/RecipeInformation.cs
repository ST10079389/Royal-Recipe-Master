using System.Collections.Generic;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    public class RecipeInformation
    {
        // class used to make a constructor that will store all my information for each recipe properly
        // Properties to store recipe information
        public List<string> RecipeIngredients { get; set; }
        public List<string> RecipeName { get; set; }
        public List<string> MeasurementIngrident { get; set; }
        public List<double> Quantity { get; set; }
        public List<double> OriginalQuantity { get; set; }
        public List<string> Steps { get; set; }
        public List<string> FoodGroup { get; set; }
        public List<int> Calories { get; set; }
        public List<int> OriginalCalories { get; set; }

        // Class for holding recipe information in a constructor for specific recipes
        public RecipeInformation(List<string> RecipeName, List<string> RecipeIngredients, List<string> MeasurementIngrident, List<string> Steps, List<double> Quantity, List<double> OriginalQuantity, List<string> FoodGroup, List<int> Calories, List<int> OriginalCalories)
        {
            // Assigning values to the properties using constructor parameters
            this.RecipeIngredients = RecipeIngredients;
            this.RecipeName = RecipeName;
            this.MeasurementIngrident = MeasurementIngrident;
            this.Quantity = Quantity;
            this.OriginalQuantity = OriginalQuantity;
            this.Steps = Steps;
            this.FoodGroup = FoodGroup;
            this.Calories = Calories;
            this.OriginalCalories = OriginalCalories;
        }
    }
}
