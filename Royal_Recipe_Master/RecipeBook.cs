using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    public class RecipeBook
    {//this class this most of the heavy lifting to make my application run smoothly
        public void DisplaySpecificRecipe(List<RecipeInformation> Recipes, string search)//the search method to display a specific recipe
        {//can display only one specific recipe
            string message = "";
            bool recipeFound = false;
            foreach (RecipeInformation recipe in Recipes)
            {//displays all the information
                if (recipe.RecipeName.Contains(search))
                {
                    recipeFound = true;
                    message += "Recipe Name: " + search + "\n";
                    message += "Ingredients:\n";

                    for (int i = 0; i < recipe.RecipeIngredients.Count; i++)
                    {//displays all the recipes information to a messagebox
                        string ingredient = recipe.Quantity[i] + " " + recipe.MeasurementIngrident[i] + " of " + recipe.RecipeIngredients[i] + " has " + recipe.Calories[i] + " calories and belongs to " + recipe.FoodGroup[i];
                        message += "- " + ingredient + "\n";
                    }

                    message += "Steps:\n";
                    for (int i = 0; i < recipe.Steps.Count; i++)
                    {
                        message += "- " + recipe.Steps[i] + "\n";
                    }

                    int totalCalories = recipe.Calories.Sum();//calculates the total calories
                    message += "Total Calories: " + totalCalories + "\n\n";
                }
            }
            if (!recipeFound)//error handling
            {
                message = "Sorry, could not find the recipe you are looking for. Please try again.";
            }
            else if (string.IsNullOrEmpty(message))
            {
                message = "Sorry, could not find that recipe. Please try again.";
            }

            MessageBox.Show(message, "Search Results");//displays here with everything
        }
        public void ResetQuantity(List<RecipeInformation> Recipes, string name)//reset method to reset a scalled recipe
        {
            string message = "";
            RecipeInformation recipe = Recipes.FirstOrDefault(r => r.RecipeName.Contains(name));
            if (recipe != null)
            {
                if (RecipeHasScaledQuantity(recipe))
                {//passes it to a method which scales that recipe
                    ResetRecipeQuantity(recipe);
                    message = "Success! The quantity of your ingredients has been reset to the original quantity.";
                }
                else
                {
                    message = "Cannot reset the quantity of a recipe that was never scaled.";
                }
            }
            else//error handling
            {
                message = "Recipe not found. Please try again.";
            }
            MessageBox.Show(message, "Results");
        }

        private bool RecipeHasScaledQuantity(RecipeInformation recipe)//if the recipe was not scalled in the first place
        {
            for (int i = 0; i < recipe.Quantity.Count; i++)
            {
                if (recipe.Quantity[i] != recipe.OriginalQuantity[i] || recipe.Calories[i] != recipe.OriginalCalories[i])
                {
                    return true;
                }
            }
            return false;//retruns the value
        }
        private void ResetRecipeQuantity(RecipeInformation recipe)//reset the calorie sif it is scalled
        {
            for (int i = 0; i < recipe.Quantity.Count; i++)
            {//resets all the calories and quanitity of a recipe
                recipe.Quantity[i] = recipe.OriginalQuantity[i];
                recipe.Calories[i] = recipe.OriginalCalories[i];
            }
        }
        public void QuantitySelection(List<RecipeInformation> Recipes, string name, double scalingFactor)//Scales the recipe
        {
            string message = "";
            RecipeInformation recipe = Recipes.FirstOrDefault(r => r.RecipeName.Contains(name));

            if (recipe != null)
            {
                ScaleQuantities(Recipes, scalingFactor);//passes it to a method which scalles the values
                string capitalizedRecipeName = char.ToUpper(name[0]) + name.Substring(1);//makes the first letter capital
                message = $"{capitalizedRecipeName} recipe has been scaled successfully!";
            }
            else
            {
                message = "Recipe could not be found. Please enter the correct name.";
            }
            MessageBox.Show(message, "Scaling Output");
        }
        public void ScaleQuantities(List<RecipeInformation> Recipes, double scalingFactor)
        {
            foreach (RecipeInformation recipe in Recipes)
            {
                // Scale the quantities based on what the user selects
                for (int i = 0; i < recipe.Quantity.Count; i++)
                {
                    recipe.Quantity[i] *= scalingFactor;
                    recipe.Calories[i] = (int)Math.Round(recipe.Calories[i] * scalingFactor);
                }
            }
        }
        public void ClearAll(List<RecipeInformation> Recipes)//clears all the data from the recipe
        {
            MessageBoxResult result = MessageBox.Show("Do you want to clear all the recipes?", "Clear All", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Recipes.Clear();
                    MessageBox.Show("All the data has been cleared", "Result");//deletes all the recipes and shows it in a messagebox called results
                }
                catch (Exception)
                {
                    MessageBox.Show("Sorry, data could not be cleared.", "Result");
                }
            }
            else
            {
                MessageBox.Show("Data clearing cancelled.", "Clear All");
            }
        }
        public string CalorieDescription(int total)//a calorie description based on the range of the recipes total calories
        {
            string message = string.Empty;
            if (total <= 300)//if its less then 300 calories
            {
                message = "Discover the magic of your low-calorie recipe, boasting a total of " + total + " calories. " +
                    "Whether you're seeking a wholesome snack or aiming for weight loss, this culinary masterpiece is a delicious choice that supports your goals.";
            }
            else if (total > 300 && total <= 1000)//if its between 300 and 1000 calories
            {
                message = "Indulge in the richness of your high-calorie recipe, featuring a total of " + total + " calories. " +
                    "Perfectly suited as a satisfying main course, this culinary delight is not recommended for weight loss purposes, but rather for those seeking a flavorful and hearty dining experience.";
            }
            else
            {//if its higher then 100 calories
                message = "Kindly note that your recipe contains a substantial amount of calories, totaling " + total + " calories. " +
                    "It is highly advised to consider scaling it down for the sake of your own health and well-being. Prioritizing your overall wellness, this step will contribute to maintaining a balanced diet and a healthier lifestyle.";
            }
            return message;
        }
    }
}
