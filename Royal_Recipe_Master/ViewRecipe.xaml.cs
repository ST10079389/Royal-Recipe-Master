using System.Collections.Generic;
using System.Linq;
using System.Windows;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    /// <summary>
    /// Interaction logic for ViewRecipe.xaml
    /// </summary>
    public partial class ViewRecipe : Window
    {
        //declare variables i will use to show information
        private List<RecipeInformation> recipes;
        private RecipeBook recipeBook = new RecipeBook();
        string name;
        public ViewRecipe(List<RecipeInformation> recipes, string name)
        {
            InitializeComponent();
            this.recipes = recipes;
            this.name = name;//passing in the list and the name they want to display
            PopulateRecipeInformation();//using a method to display a recipe
        }

        private void PopulateRecipeInformation()
        {
            //this method shows all the information about a specific recipe and displays in a list box 
            var sortedRecipes = recipes.OrderBy(recipe => string.Join("", recipe.RecipeName)).ToList();
            foreach (RecipeInformation recipe in sortedRecipes)
            {
                if(recipe.RecipeName.Contains(name))
                {
                    RecipeNameBox.Text = name;
                    for (int j = 0; j < recipe.RecipeIngredients.Count; j++)
                    {//i display all the information about that specifc recipe onto the list box
                        string ingredient = "- " + recipe.Quantity[j] + " " + recipe.MeasurementIngrident[j] + " of " + recipe.RecipeIngredients[j] + " has " + recipe.Calories[j] + " calories and belongs to " + recipe.FoodGroup[j];
                        IngredientsBox.Items.Add(ingredient);
                    }
                    for (int k = 0; k < recipe.Steps.Count; k++)
                    {//this gets displayed to a list box which allows the user to tick off when they done with a step
                        string message = $"{k+1}. " + recipe.Steps[k];
                        StepsBox.Items.Add(message);
                    }
                    int totalCalories = recipe.Calories.Sum();
                    CalorieBox.Text = totalCalories.ToString() + " Calories";//shows the toal calories
                    DescriptionBox.Text = (recipeBook.CalorieDescription(totalCalories));
                }
            }
        }
        //MENU BAR OPTIONS
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu(recipes);//takes them to the menu
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
            recipeBook.DisplaySpecificRecipe(recipes, search);//searches for a specific recipe
            SearchBox.Text = "Enter Recipe Name";
        }
    }
}
