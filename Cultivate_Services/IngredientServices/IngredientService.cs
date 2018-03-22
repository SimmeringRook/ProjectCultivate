using Cultivate_Entities;
using Cultivate_Repositories.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace Cultivate_Services.IngredientSerivces
{
    public class IngredientService : IIngredientService
    {
        private IEntityFrameworkRepository<Ingredient> ingredientRepository;

        public IngredientService(IEntityFrameworkRepository<Ingredient> ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository;
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return ingredientRepository.GetAll();
        }
        
        public IEnumerable<Ingredient> GetIngredientsForRecipe(long recipeId)
        {
            return ingredientRepository.GetAll().Where(ingredient => ingredient.Recipe.Id == recipeId);
        }

        public Ingredient Get(long id)
        {
            return ingredientRepository.Get(id);
        }

        public void Insert(Ingredient Ingredient)
        {
            ingredientRepository.Insert(Ingredient);
        }

        public void Update(Ingredient Ingredient)
        {
            ingredientRepository.Update(Ingredient);
        }

        public void Delete(long id)
        {
            Ingredient ingredient = Get(id);

            ingredientRepository.Remove(ingredient);
            ingredientRepository.SaveChanges();

            ingredient = null;
        }
    }
}
