namespace Receipe_Finder;

public partial class AllReciepesPage : ContentPage
{
	private MockRecipeService _recipeService;
	public AllReciepesPage()
	{
		InitializeComponent();
		_recipeService = new MockRecipeService();
		LoadRecipes();
	}
	private async void LoadRecipes()
	{
		var recipes = await _recipeService.GetAllRecipesAsync();
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