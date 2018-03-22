using Cultivate_Entities;
using System.Collections.Generic;

namespace Cultivate_Services.IngredientSerivces
{
    public interface IIngredientService
    {
        IEnumerable<Ingredient> GetAll();
        IEnumerable<Ingredient> GetIngredientsForRecipe(long recipeId);
        Ingredient Get(long id);
        void Insert(Ingredient newRecipe);
        void Update(Ingredient changedRecipe);
        void Delete(long id);
    }
}
