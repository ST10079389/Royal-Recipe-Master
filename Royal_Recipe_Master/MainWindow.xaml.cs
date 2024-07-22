using System.Windows;
namespace ST10079389_Kaushil_Dajee_PROG6211POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RecipeButton_Click(object sender, RoutedEventArgs e)
        {
            //begins here and takes them to a window where they enter a recipe
            RecipeInput recipeInput = new RecipeInput();
            recipeInput.Show();
            this.Close();
        }
    }
}
