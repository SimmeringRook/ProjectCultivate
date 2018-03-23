using Cultivate_Entities;
using Cultivate_Repositories.EntityFramework.ModelMaps;
using Microsoft.EntityFrameworkCore;

namespace Cultivate_Repositories.EntityFramework
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new RecipeFamilyMap(modelBuilder.Entity<RecipeFamily>());
            new RecipeMap(modelBuilder.Entity<Recipe>());
            new IngredientMap(modelBuilder.Entity<Ingredient>());

            new InventoryItemMap(modelBuilder.Entity<InventoryItem>());

            new MealPlanMap(modelBuilder.Entity<MealPlan>());
        }

    }
}
