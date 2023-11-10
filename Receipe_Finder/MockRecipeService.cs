using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipe_Finder
{
    public class MockRecipeService
    {
        private List<Recipe> _recipes = new List<Recipe>
        {
            new Recipe {Id = 1, Title = "Pasta Carbonara", Ingredients= "Pasta, Eggs, Bacon", Instructions = "Boil pasta, add other ingriendients.", IsCarnivore=true, IsVegan=false},
            new Recipe {Id = 2, Title = "Chicken Noodle Soup", Ingredients= "Noodles, Chicken, Veggies", Instructions = "Boil noodles, add other ingriendients.",  IsCarnivore=true, IsVegan=false},
            new Recipe {Id = 3, Title = "Tomato Soup", Ingredients= "Tomatoes, Veggie Broth, Veggies", Instructions = "Add to pot, Let is cook.",   IsCarnivore=false, IsVegan=true},
            new Recipe {Id = 4, Title = "Steak and Potatoes", Ingredients= "Steak, Potatoes, Veggies", Instructions = "Cook steak, Cook everything else." , IsCarnivore=true, IsVegan=false},
        };
        public async Task<IEnumerable<Recipe>> GetAllRecipesAsync()
        {
            await Task.Delay(1000);
            return _recipes;
        }
        public async Task<Recipe> GetRecipeByIdAsync(int id)
        {
            await Task.Delay(1000);
            return _recipes.Find(r => r.Id == id);
        }

        public async Task<IEnumerable<Recipe>> GetCarnivoreRecipesAsync()
        {
            var carnivoreRecipes = _recipes.Where(r => r.IsCarnivore).ToList();
            await Task.Delay(1000); // Simulate network delay
            return carnivoreRecipes;
        }

        public async Task<IEnumerable<Recipe>> GetVeganRecipesAsync()
        {
            var veganRecipes = _recipes.Where(r => r.IsVegan).ToList();
            await Task.Delay(1000); // Simulate network delay
            return veganRecipes;
        }
    }
}
