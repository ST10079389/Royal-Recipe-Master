using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    /// <summary>
    /// Interaction logic for ViewAllRecipes.xaml
    /// </summary>
    public partial class ViewAllRecipes : Window
    {
        //declare the list and object i will use in this window
        private List<RecipeInformation> recipes;
        private RecipeBook recipeBook = new RecipeBook();
        public ViewAllRecipes(List<RecipeInformation> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;//list passed from other window
        }
        //MENU BAR OPTIONS
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu(recipes);//takes you to the menu window
            menu.Show();
            this.Close();
        }
        private void ExitOption_Click_1(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();//closes the app
        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "";
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchBox.Text;
            recipeBook.DisplaySpecificRecipe(recipes, search);//searches for a recipe
            SearchBox.Text = "Enter Recipe Name";
        }
        private void inputFilter_GotFocus(object sender, RoutedEventArgs e)
        {
            inputFilter.Text = "";
        }
        //GRID
        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (filterBox.SelectedItem == null)
                {
                    // No filter option selected, display all recipes
                    RecipeBox.Items.Clear();
                    int total = 0;
                    var sortedRecipes = recipes.OrderBy(recipe => string.Join("", recipe.RecipeName)).ToList();

                    foreach (RecipeInformation recipe in sortedRecipes)
                    {
                        total = recipe.Calories.Sum();
                        string message = "Recipe Name: " + string.Join("", recipe.RecipeName)
                            + "\nTotal Calories: " + total + "\n" + recipeBook.CalorieDescription(total);
                        RecipeBox.Items.Add(message);
                    }
                }
                else
                {
                    string selectedOption = ((ComboBoxItem)filterBox.SelectedItem).Content.ToString();
                    RecipeBox.Items.Clear();
                    int total = 0;
                    if (selectedOption == "Alphabetically")
                    {
                        // Filter recipes alphabetically
                        var sortedRecipes = recipes.OrderBy(recipe => string.Join("", recipe.RecipeName)).ToList();

                        foreach (RecipeInformation recipe in sortedRecipes)
                        {
                            total = recipe.Calories.Sum();
                            string message = "Recipe Name: " + string.Join("", recipe.RecipeName)
                                + "\nTotal Calories: " + total + "\n" + recipeBook.CalorieDescription(total);
                            RecipeBox.Items.Add(message);
                        }
                    }
                    else if (selectedOption == "Ingredient Name")
                    {
                        // Filter recipes based on ingredient name
                        string ingredientName = inputFilter.Text;
                        var filteredRecipes = recipes.Where(recipe => recipe.RecipeIngredients.Contains(ingredientName)).ToList();

                        foreach (RecipeInformation recipe in filteredRecipes)
                        {
                            total = recipe.Calories.Sum();
                            string message = "Recipe Name: " + string.Join("", recipe.RecipeName)
                                + "\nTotal Calories: " + total + " calories " + "\n" + recipeBook.CalorieDescription(total);
                            RecipeBox.Items.Add(message);
                        }
                    }
                    else if (selectedOption == "Food Group")
                    {
                        // Filter recipes based on food group
                        string foodGroup = inputFilter.Text;
                        var filteredRecipes = recipes.Where(recipe => recipe.FoodGroup.Contains(foodGroup)).ToList();

                        foreach (RecipeInformation recipe in filteredRecipes)
                        {
                            total = recipe.Calories.Sum();
                            string message = "Recipe Name: " + string.Join("", recipe.RecipeName)
                                + "\nTotal Calories: " + total + "\n" + recipeBook.CalorieDescription(total);
                            RecipeBox.Items.Add(message);
                        }
                    }
                    else if (selectedOption == "Maximum Number of Calories")
                    {
                        // Filter recipes based on maximum calories
                        int max = int.Parse(inputFilter.Text);
                        var filteredRecipes = recipes.Where(recipe => recipe.Calories.Sum() <= max).ToList();

                        foreach (RecipeInformation recipe in filteredRecipes)
                        {
                            total = recipe.Calories.Sum();
                            string message = "Recipe Name: " + string.Join("", recipe.RecipeName)
                                + "\nTotal Calories: " + total + "\n" + recipeBook.CalorieDescription(total);
                            RecipeBox.Items.Add(message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. Please ensure you have entered the appropriate values.", "Error");
            }
        }
        private void NextButton_Click_1(object sender, RoutedEventArgs e)
        {
            //if the user would like to view more details about a specific recipe
            string name = RecipeNameBox.Text;
            bool found = false;
            var sortedRecipes = recipes.OrderBy(recipe => string.Join("", recipe.RecipeName)).ToList();

            foreach (RecipeInformation recipe in sortedRecipes)
            {
                if (recipe.RecipeName.Contains(name))
                {
                    found = true;
                    ViewRecipe viewRecipe = new ViewRecipe(recipes, name);
                    viewRecipe.Show();//searches for it and shows it in the view recipe window with all of its information
                    this.Close();
                }
            }
            if (!found)
            {
                MessageBox.Show("Soory, recipe could not be found.", "Result");//else it will show an error
            }
        }
    }
}
