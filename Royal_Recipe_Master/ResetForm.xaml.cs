using System.Collections.Generic;
using System.Windows;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    /// <summary>
    /// Interaction logic for ResetForm.xaml
    /// </summary>
    public partial class ResetForm : Window
    {
        //declaring variables and objects
        private List<RecipeInformation> recipes;
        private RecipeBook recipeBook = new RecipeBook();
        public ResetForm(List<RecipeInformation> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;//used to pass the recipes list
        }
        //MENU BAR OPTIONS
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu(recipes);//takes them back to the menu
            menu.Show();
            this.Close();
        }
        private void ExitOption_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();//closes the app
        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "";//becomes blank when the user clicks it to enter the recipes name
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchBox.Text;
            recipeBook.DisplaySpecificRecipe(recipes, search);//allows the user to search for a specific recipe
            SearchBox.Text = "Enter Recipe Name";
        }
        //GRID
        private void AlterRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = RecipeNameBox.Text;//asks the user for the name of the recipe they would like to scale
            recipeBook.ResetQuantity(recipes, name);//calls a method in recipe book class to reset the recipe with the parameters recipes and the name of the recipe
        }
    }
}
