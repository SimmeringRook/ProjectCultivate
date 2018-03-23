using Cultivate_Entities;
using System.Collections.Generic;

namespace Cultivate_Services.RecipeServices
{
    public interface IRecipeService
    {
        IEnumerable<Recipe> GetAll();
        IEnumerable<Recipe> GetRecipeFamily();
        Recipe Get(long recipeId);
        void Insert(Recipe newRecipe);
        void Update(Recipe changedRecipe);
        void Delete(long recipeId);
    }
}
