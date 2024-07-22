using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    /// <summary>
    /// Interaction logic for RecipeInput.xaml
    /// </summary>
    public partial class RecipeInput : Window
    {
        //declaring varaibles and objects
        private static List<RecipeInformation> Recipes = new List<RecipeInformation>();//Recipes list used to save recipe data with the help of a constructor
        RecipeBook recipeBook = new RecipeBook();//used to call methods from another class
        public delegate void Count(int x);//delegate for calories
        private bool saveRecipe = true; // Flag variable to control saving
        List<int> Total = new List<int>();
        public RecipeInput()
        {
            InitializeComponent();
            InitializeFoodGroupComboBox();//used for the combobox food group
        }
        public void Warning()
        {
            // method used to calculate the sum of total calories and invoke a delegate to trigger a warning
            int sum = 0;
            // Calculating the sum of total calories by iterating over the 'Total' list
            for (int i = 0; i < Total.Count; i++)
            {
                sum += Total[i];
            }
            // Creating a delegate instance 'del' using the 'CalorieWarningDelegate' delegate type
            Count del = CalorieWarningDelegate;
            // Invoking the delegate and passing the sum of total calories as an argument
            del(sum);
        }
        public void CalorieWarningDelegate(int x)
        {
            // This method checks if the total calorie value (x) is greater than or equal to 300.
            // If it is, it prompts the user for confirmation to continue or not.
            if (x >= 300)
            {
                MessageBoxResult userInput = MessageBox.Show(recipeBook.CalorieDescription(x) + "\nDo you want to cancel this recipe?", "Cancel Recipe", MessageBoxButton.YesNo);
                // Check the user's input to determine the next course of action
                if (userInput == MessageBoxResult.No)
                {
                    //if they want to save the recipe it will be saved
                    Total.Clear();
                }
                else if (userInput == MessageBoxResult.Yes)
                {
                    Total.Clear();
                    saveRecipe = false; // Set the flag to false to cancel saving
                }
                else
                {
                    // If the user provides an invalid input, display an error message and return to the menu options
                    MessageBox.Show("Invalid input.");
                }
            }
        }
        private void InitializeFoodGroupComboBox()
        {
            // Added the food group options to the combo box
            FoodGroup.Items.Add(new ComboBoxItem() { Content = "Grains" });
            FoodGroup.Items.Add(new ComboBoxItem() { Content = "Vitamins" });
            FoodGroup.Items.Add(new ComboBoxItem() { Content = "Proteins" });
            FoodGroup.Items.Add(new ComboBoxItem() { Content = "Fats" });
            FoodGroup.Items.Add(new ComboBoxItem() { Content = "Dairy" });

            // Select the first item by default
            FoodGroup.SelectedIndex = 0;
        }
        // MENU BAR OPTIONS 
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
                Menu menu = new Menu(Recipes);//takes them to the menu window while passing the Recipes list
                menu.Show();
                this.Close();
        }
        private void ExitOption_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
            // Handles the exit option click event
        }
        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "";//when the user wants to search for a recipe 
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchBox.Text;
            recipeBook.DisplaySpecificRecipe(Recipes, search);//searches for a specific recipe
            SearchBox.Text = "Enter Recipe Name";
        }
        // GRID BAR OPTIONS
        private void IngredientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //user enters values which are displayed on a list box
                string group = "";
                string ingredient = IngredientBox.Text;
                string quantityInput = MeasurementBox.Text;
                string selectedValue = ((ComboBoxItem)FoodGroup.SelectedItem).Content.ToString();

                group = selectedValue; // Set the group directly to the selected value

                int calories = int.Parse(CalorieBox.Text);
                string input = $"{quantityInput} of {ingredient} belongs to {group} with {calories} calories.";
                ingredientsInfoBox.Items.Add(input);
            }
            catch (FormatException)//error handling
            {
                MessageBox.Show("Please enter a valid number for quantity or calories.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                //clears the boxes for the user to enter the next ingridients information
                IngredientBox.Clear();
                MeasurementBox.Clear();
                CalorieBox.Clear();
            }
        }
        private void AddStepButton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string step = StepsBox.Text;
                stepsListBox.Items.Add(step);//values are entered and displayed ona list box
            }
            catch (Exception ex)//error handling
            {
                MessageBox.Show($"An error occurred, please try again.");
            }
            finally
            {
                StepsBox.Clear();
            }
        }

        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)//method used to save the recipe from the lsit box 
        {
            //declaring all the lists to save the information
            List<string> RecipeName = new List<string>();
            List<string> RecipeIngredients = new List<string>();
            List<string> Steps = new List<string>();
            List<double> Quantity = new List<double>();
            List<double> OriginalQuantity = new List<double>();
            List<string> MeasurementIngredient = new List<string>();
            List<int> Calories = new List<int>();
            List<string> FoodGroup = new List<string>();
            List<int> OriginalCalories = new List<int>();
            try
            {
                string name = RecipeNameBox.Text;
                RecipeName.Add(name);
                int total = 0;
                foreach (var item in ingredientsInfoBox.Items)
                {
                    //with the list box it saves specific values at certain parts of the string
                    string ingredientInfo = item.ToString();
                    string[] parts = ingredientInfo.Split(' ');
                    string quantityInput = parts[0];
                    string measurementUnit = parts[1];
                    string ingredient = parts[3];
                    string group = parts[6];
                    string caloriesString = parts[8];
                    if (!double.TryParse(quantityInput, out double quantityValue))
                    {
                        MessageBox.Show($"Invalid quantity format for ingredient: {ingredient}");//error handling
                        return;
                    }
                    if (!int.TryParse(caloriesString, out int calories))
                    {
                        MessageBox.Show($"Invalid calories format for ingredient: {ingredient}");//error handling
                        return;
                    }
                    //all the recipes information is saved to a list
                    RecipeIngredients.Add(ingredient);
                    FoodGroup.Add(group);
                    Quantity.Add(quantityValue);
                    OriginalQuantity.Add(quantityValue);    
                    MeasurementIngredient.Add(measurementUnit);
                    Calories.Add(calories);
                    OriginalCalories.Add(calories);
                    Total.Add(calories);//calculates the total number of calories
                    Warning();//warns them if it is above 300 calories
                }
                foreach (var item in stepsListBox.Items)
                {
                    string step = item.ToString();
                    Steps.Add(step);//same here it saves all the steps to a list
                }
                if (!saveRecipe)
                {
                    // If User choses to cancel the recipe, so do not save it
                    MessageBox.Show("Recipe has been canceled.", "Recipe Canceled");
                    RecipeNameBox.Clear();
                    ingredientsInfoBox.Items.Clear();
                    stepsListBox.Items.Clear();
                    saveRecipe = true;
                    return;
                }
                //otherwise the recipe is saved
                RecipeInformation Recipe = new RecipeInformation(RecipeName, RecipeIngredients, MeasurementIngredient, Steps, Quantity, OriginalQuantity, FoodGroup, Calories, OriginalCalories);
                Recipes.Add(Recipe);
                MessageBox.Show("Recipe has been saved successfully", "Recipe Saved!");
                RecipeNameBox.Clear();
                ingredientsInfoBox.Items.Clear();
                stepsListBox.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred, please try again.");
            }
            finally
            {
                Menu menu = new Menu(Recipes);//takes them to the menu window while passing the Recipes list
                menu.Show();
                this.Close();
            }
        }
    }
}
