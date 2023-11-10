namespace Receipe_Finder;

public partial class CarnivoreRecipesPage : ContentPage
{
    private MockRecipeService _recipeService;
	public CarnivoreRecipesPage()
	{
		InitializeComponent();
        _recipeService = new MockRecipeService();
        LoadCarnivoreRecipes();
    }

    public async void LoadCarnivoreRecipes()
    {
        var recipes = await _recipeService.GetCarnivoreRecipesAsync();
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