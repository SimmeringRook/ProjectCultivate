using System.Collections.Generic;
using System.Linq;
using Cultivate_Entities;
using Cultivate_Repositories.EntityFramework;
using Cultivate_Services.RecipeServices;

namespace Cultivate_Services.RecipeFamilyServices
{
    public class RecipeFamilyService : IRecipeFamilyService
    {
        private IEntityFrameworkRepository<RecipeFamily> recipeFamilyRepository;
        private IRecipeService recipeService;

        public RecipeFamilyService(IEntityFrameworkRepository<RecipeFamily> recipeFamilyRepository,
            IRecipeService recipeService)
        {
            this.recipeFamilyRepository = recipeFamilyRepository;
            this.recipeService = recipeService;
        }

        public IEnumerable<RecipeFamily> GetAll()
        {
            return recipeFamilyRepository.GetAll();
        }

        public IEnumerable<Recipe> GetAllRecipeVariants(long recipeFamilyID)
        {
            return recipeFamilyRepository.Get(recipeFamilyID).RecipeVariants;
        }

        public RecipeFamily Get(long recipeFamilyID)
        {
            return recipeFamilyRepository.Get(recipeFamilyID);
        }

        public void Insert(RecipeFamily newRecipeFamily)
        {
            recipeFamilyRepository.Insert(newRecipeFamily);
        }

        public void Update(RecipeFamily changedRecipeFamily)
        {
            recipeFamilyRepository.Update(changedRecipeFamily);
        }

        public void Delete(long recipeFamilyID)
        {
            RecipeFamily recipeFamily = Get(recipeFamilyID);

            IEnumerable<long> recipeIDs = GetAllRecipeVariants(recipeFamily.Id).Select(r => r.Id);

            foreach (long id in recipeIDs)
            {
                //Let the Recipe Service deal with removing all information for the recipe
                recipeService.Delete(id);
            }
            
            //At this point, no child objects/data remain that are associated with recipeFamily

            recipeFamilyRepository.Remove(recipeFamily);
            recipeFamilyRepository.SaveChanges();

            //null out the references to completely remove the objects from memeory.

            recipeIDs = null;
            recipeFamily = null;
        }
    }
}
