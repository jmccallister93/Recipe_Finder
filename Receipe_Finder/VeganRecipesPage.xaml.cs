namespace Receipe_Finder;

public partial class VeganRecipesPage : ContentPage
{
    private MockRecipeService _recipeService;
    public VeganRecipesPage()
	{
		InitializeComponent();
        _recipeService = new MockRecipeService();
        LoadVeganRecipes();
    }

    public async void LoadVeganRecipes()
    {
        var recipes = await _recipeService.GetVeganRecipesAsync();
        recipesListView.ItemsSource = recipes;
    }

    private async void OnRecipeSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is Recipe selectedRecipe)
        {
            await Navigation.PushAsync(new RecipeViewPage(selectedRecipe));
        }
        ((ListView)sender).SelectedItem = null;
    }
}