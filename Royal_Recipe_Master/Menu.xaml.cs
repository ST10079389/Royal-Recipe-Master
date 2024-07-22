using System.Collections.Generic;
using System.Windows;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        //declaring variables and objects i will use
        private List<RecipeInformation> recipes;//ny using this i can easily pass a list from inputting the recipe to the next window and the next
        private RecipeBook recipeBook = new RecipeBook();
        public Menu(List<RecipeInformation> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;//passing the recipe list from input recipe window
        }
        //MENU BAR OPTIONS
        private void ExitOption_Click_1(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();//if the user wants to close the app
        }
        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "";
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchBox.Text;
            recipeBook.DisplaySpecificRecipe(recipes, search);//used to search for a specific recipe
            SearchBox.Text = "Enter Recipe Name";
        }
        //GRID OPTIONS
        private void RecipeButton_Click(object sender, RoutedEventArgs e)
        {
            RecipeInput input = new RecipeInput();//takes them to the window to enter another recipe
            input.Show();
            this.Close();
        }
        private void ViewAllButton_Click(object sender, RoutedEventArgs e)
        {
            if(recipes.Count == 0)//error handling if their is no recipe saved
            {
                MessageBox.Show("You must enter a Recipe First!", "Warning");
            }
            else
            {
                ViewAllRecipes viewAll = new ViewAllRecipes(recipes);//takes them to view all the recipes window
                viewAll.Show();
                this.Close();
            }
        }
        private void ScalingButton_Click(object sender, RoutedEventArgs e)
        {
            if (recipes.Count == 0)//error handling if their is no recipe saved
            {
                MessageBox.Show("You must enter a Recipe First!", "Warning");
            }
            else
            {
                ScallingForm scallingForm = new ScallingForm(recipes);//takes them to the scalling window
                scallingForm.Show();
                this.Close();
            }
        }
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            if (recipes.Count == 0)//error handling if their is no recipe saved
            {
                MessageBox.Show("You must enter a Recipe First!", "Warning");
            }
            else
            {
                ResetForm resetForm = new ResetForm(recipes);//takes them to reset a recipe
                resetForm.Show();
                this.Close();
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (recipes.Count == 0)//error handling if their is no recipe saved
            {
                MessageBox.Show("You must enter a Recipe First!", "Warning");
            }
            else
            {
                recipeBook.ClearAll(recipes);//takes them to a message which asks if they want to delete all recipes
            }
        }
    }
}
