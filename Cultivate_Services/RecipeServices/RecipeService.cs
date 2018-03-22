using Cultivate_Entities;
using Cultivate_Repositories.EntityFramework;
using Cultivate_Services.IngredientSerivces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cultivate_Services.RecipeServices
{
    public class RecipeService : IRecipeService
    {
        private IEntityFrameworkRepository<Recipe> recipeRepository;
        private IIngredientService ingredientService;

        public RecipeService(IEntityFrameworkRepository<Recipe> recipeRepository,
            IIngredientService ingredientService)
        {
            this.recipeRepository = recipeRepository;
            this.ingredientService = ingredientService;
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return recipeRepository.GetAll();
        }

        public IEnumerable<Recipe> GetRecipeFamily()
        {
            throw new NotImplementedException();
        }

        public Recipe Get(long recipeId)
        {
            return recipeRepository.Get(recipeId);
        }

        public void Insert(Recipe newRecipe)
        {
            recipeRepository.Insert(newRecipe);
        }

        public void Update(Recipe changedRecipe)
        {
            recipeRepository.Update(changedRecipe);
        }

        public void Delete(long recipeId)
        {
            Recipe recipe = Get(recipeId);

            IEnumerable<long> ingredientIDs = ingredientService.GetIngredientsForRecipe(recipe.Id).Select(i => i.Id);

            foreach (long id in ingredientIDs)
            {
                //Let the Ingredient Service deal with removing all information for the ingredients
                ingredientService.Delete(id);
            }

            //At this point, no child objects/data remain that are associated with recipe

            recipeRepository.Remove(recipe);
            recipeRepository.SaveChanges();

            //null out the references to completely remove the objects from memeory.

            ingredientIDs = null;
            recipe = null;
        }
    }
}
