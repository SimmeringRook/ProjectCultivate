using Cultivate_Repositories.EntityFramework;
using Cultivate_Services.IngredientSerivces;
using Cultivate_Services.RecipeFamilyServices;
using Cultivate_Services.RecipeServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cultivate_WindowsDesktop
{
    class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseInMemoryDatabase("TestingDb")
            );

            //TODO: Uncomment once service has been created
            //services.AddScoped<IInventoryItemService, InventoryItemService>();

            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IRecipeFamilyService, RecipeFamilyService>();
        }
    }
}
