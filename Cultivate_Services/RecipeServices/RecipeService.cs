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

        public IEnumerable<Recipe> GetAll()
        {
            var allRecipes = recipeRepository.GetAll();

            foreach (var recipe in allRecipes)
            {
                var ingredients = ingredientService.GetIngredientsForRecipe(recipe.Id).ToList();
                if (ingredients == null || ingredients[0] == null)
                    ingredients = new List<Ingredient>();
                recipe.Ingredients = ingredients;
            }

            return allRecipes;
        }

        public IEnumerable<Recipe> GetRecipeFamily()
        {
            throw new NotImplementedException();
        }

        public Recipe Get(long recipeId)
        {
            var tempRecipe = recipeRepository.Get(recipeId);
            tempRecipe.Ingredients = ingredientService.GetIngredientsForRecipe(recipeId).ToList();
            return tempRecipe;
        }

        public void Insert(Recipe newRecipe)
        {
            recipeRepository.Insert(newRecipe);
        }

        public void Update(Recipe changedRecipe)
        {
            recipeRepository.Update(changedRecipe);
        }

        /// <summary>
        /// Deleting the recipe will also remove any assocated ingredients from the database.
        /// </summary>
        /// <param name="recipeId"></param>
        public void Delete(long recipeId)
        {
            Recipe recipe = Get(recipeId);

            recipeRepository.Remove(recipe);
            recipeRepository.SaveChanges();

            recipe = null;
        }
    }
}
