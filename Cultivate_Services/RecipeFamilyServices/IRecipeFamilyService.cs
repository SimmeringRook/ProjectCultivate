using Cultivate_Entities;
using System.Collections.Generic;

namespace Cultivate_Services.RecipeFamilyServices
{
    public interface IRecipeFamilyService
    {
        IEnumerable<RecipeFamily> GetAll();
        IEnumerable<Recipe> GetAllRecipeVariants(long recipeFamilyID);
        RecipeFamily Get(long recipeFamilyID);
        void Insert(RecipeFamily newRecipeFamily);
        void Update(RecipeFamily changedRecipeFamily);
        void Delete(long recipeFamilyID);
    }
}
