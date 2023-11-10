namespace Receipe_Finder;

public partial class RecipeViewPage : ContentPage
{
	public RecipeViewPage(Recipe recipe)
	{
		InitializeComponent();
        titleLabel.Text = recipe.Title;
        ingredientsLabel.Text = $"Ingredients: {recipe.Ingredients}";
        instructionsLabel.Text = $"Instructions: {recipe.Instructions}";
    }
}