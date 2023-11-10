namespace Receipe_Finder
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnAllRecipesTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AllReciepesPage());
        }
        private async void OnVeganRecipesTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VeganRecipesPage());
        }

        private async void OnCarnivoreRecipesTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarnivoreRecipesPage());
        }

    }
}