using System.Linq;
using Cultivate_Entities;
using Cultivate_Repositories.EntityFramework;
using Cultivate_Services.IngredientSerivces;
using Cultivate_Services.RecipeServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cultivate_Services_Test
{
    /// <summary>
    /// Uses a Database Created in Memory for Testing.
    /// Tests are designed to cover the API interactions of the RecipeService
    /// </summary>
    [TestClass]
    public class RecipeServiceTests
    {
        private readonly string _databaseName = "RecipeServiceTesting";
        private DbContextOptions<ApplicationContext> _options;
        private EntityFrameworkRepository<Recipe> _recipeRepository;

        /// <summary>
        /// Creates a simple Reciple with basic information and two ingredients
        /// to test that the object can be inserted into
        /// the database and then verified its properties and relations to the 
        /// two ingredients were saved correctly and can be used properly.
        /// </summary>
        [TestMethod]
        public void Insert_RecipeWithIngredients_Into_Database()
        {
            //Arrange
            _options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: _databaseName)
                .Options;

            Ingredient groundBeef = new Ingredient()
            {
                Name = "Ground Beef",
                Amount = 0.5,
                Measurement = "lbs",

            };

            Ingredient tacoShell = new Ingredient()
            {
                Name = "Taco Shell",
                Amount = 4.0,
                Measurement = "each"
            };

            Recipe recipeToAdd = new Recipe()
            {
                Name = "Tacos",
                BaseNumberOfServings = 1.0,
                Ingredients =
                {
                    groundBeef,
                    tacoShell
                }
            };

            //Act
            using (var context = new ApplicationContext(_options))
            {
                var ingredientService = new IngredientService(
                    new EntityFrameworkRepository<Ingredient>(context)
                );
                
                _recipeRepository = new EntityFrameworkRepository<Recipe>(context);
                var recipeService = new RecipeService(_recipeRepository, ingredientService);

                recipeService.Insert(newRecipe: recipeToAdd);
            }

            //Assert
            //Use a separate instance of the context to verify correct data was saved to database
            using (var context = new ApplicationContext(_options))
            {
                var ingredientService = new IngredientService(
                    new EntityFrameworkRepository<Ingredient>(context)
                );
                _recipeRepository = new EntityFrameworkRepository<Recipe>(context);
                var recipeService = new RecipeService(_recipeRepository, ingredientService);

                //Verify Recipe was added
                Assert.AreEqual(1, recipeService.GetAll().Count());
                
                Recipe addedRecipe = recipeService.GetAll().Last();

                //Verify Recipe properties
                Assert.AreEqual(recipeToAdd.Name, addedRecipe.Name);
                Assert.AreEqual(recipeToAdd.BaseNumberOfServings, addedRecipe.BaseNumberOfServings);

                //Verify Ingredients are mapped correctly
                Assert.IsNotNull(addedRecipe.Ingredients);
                Assert.AreEqual(2, addedRecipe.Ingredients.Count());

                //Ingredient 1:
                Assert.IsNotNull(addedRecipe.Ingredients[0]);
                Assert.AreEqual(
                    groundBeef.Name,
                    addedRecipe.Ingredients[0].Name);
                Assert.AreEqual(
                    groundBeef.Amount,
                    addedRecipe.Ingredients[0].Amount);
                Assert.AreEqual(
                    groundBeef.Measurement,
                    addedRecipe.Ingredients[0].Measurement);

                //Ingredient 2:
                Assert.IsNotNull(addedRecipe.Ingredients[1]);
                Assert.AreEqual(
                    tacoShell.Name,
                    addedRecipe.Ingredients[1].Name);
                Assert.AreEqual(
                    tacoShell.Amount,
                    addedRecipe.Ingredients[1].Amount);
                Assert.AreEqual(
                    tacoShell.Measurement,
                    addedRecipe.Ingredients[1].Measurement);
            }
        }

        /// <summary>
        /// Looks up the previously created Recipe with two ingredients
        /// and then removes the recipe from the database. The OnCascadeDelete
        /// relatioship should remove the associated ingredients as well.
        /// </summary>
        [TestMethod]
        public void Remove_RecipeWithIngredients_From_Database()
        {
            //Arrange
            _options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: _databaseName)
                .Options;

            //Act
            using (var context = new ApplicationContext(_options))
            {
                var ingredientService = new IngredientService(
                    new EntityFrameworkRepository<Ingredient>(context)
                );

                _recipeRepository = new EntityFrameworkRepository<Recipe>(context);
                var recipeService = new RecipeService(_recipeRepository, ingredientService);

                var recipeToRemove = recipeService.GetAll().First();
                recipeService.Delete(recipeToRemove.Id);
            }

            //Assert
            //Use a separate instance of the context to verify correct data was saved to database
            using (var context = new ApplicationContext(_options))
            {
                var ingredientService = new IngredientService(
                    new EntityFrameworkRepository<Ingredient>(context)
                );
                _recipeRepository = new EntityFrameworkRepository<Recipe>(context);
                var recipeService = new RecipeService(_recipeRepository, ingredientService);

                //Verify Recipe was added
                Assert.AreEqual(0, recipeService.GetAll().Count());

                //Verify Cascade Delete worked properly
                Assert.AreEqual(0, ingredientService.GetAll().Count());
            }
        }

    }
}
