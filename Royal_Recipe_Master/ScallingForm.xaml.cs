using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    /// <summary>
    /// Interaction logic for ScallingForm.xaml
    /// </summary>
    public partial class ScallingForm : Window
    {
        //variables and object used in this window
        private List<RecipeInformation> recipes;
        private RecipeBook recipeBook = new RecipeBook();
        const double ScalingFactorHalf = 0.5;
        const double ScalingFactorDouble = 2.0;
        const double ScalingFactorTriple = 3.0;
        public ScallingForm(List<RecipeInformation> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;//passing the recipes list 
        }
        //MENU BAR OPTIONS
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu(recipes);//takes them to the menu window
            menu.Show();
            this.Close();
        }
        private void ExitOption_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();//closes the app
        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "";//when the user clicks on it to enter the recipe name
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string search = SearchBox.Text;
            recipeBook.DisplaySpecificRecipe(recipes, search);//allows the user to search for a recipe
            SearchBox.Text = "Enter Recipe Name";
        }
        //GRID
        private void AlterRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = RecipeNameBox.Text;
            ComboBoxItem selectedItem = (ComboBoxItem)scalebox.SelectedItem;
            string selectedValue = selectedItem?.Content?.ToString();

            if (!string.IsNullOrEmpty(selectedValue))
            {
                // Scales the recipe based on the user's selected option
                if (selectedValue.Equals("Scaling the quantity of your ingredients by 0.5"))
                {
                    recipeBook.QuantitySelection(recipes, name, ScalingFactorHalf);//calls the method from recipebook to properly scale it
                }
                else if (selectedValue.Equals("Scaling the quantity of your ingredients by 2"))
                {
                    recipeBook.QuantitySelection(recipes, name, ScalingFactorDouble);
                }
                else if (selectedValue.Equals("Scaling the quantity of your ingredients by 3"))
                {
                    recipeBook.QuantitySelection(recipes, name, ScalingFactorTriple);
                }
            }
            else
            {
                MessageBox.Show("Please select an option for scaling.", "Error");
            }
        }
    }
}
