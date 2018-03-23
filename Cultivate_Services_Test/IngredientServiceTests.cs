using Cultivate_Entities;
using Cultivate_Repositories.EntityFramework;
using Cultivate_Services.IngredientSerivces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Cultivate_Services_Test
{
    [TestClass]
    public class IngredientServiceTests
    {
        private readonly string _databaseName = "IngredientServiceTesting";
        private DbContextOptions<ApplicationContext> _options;
        private EntityFrameworkRepository<Ingredient> _ingredientRepository;
        [TestMethod]
        public void Insert_BasicIngredient_Into_Database()
        {
            //Arrange
            _options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: _databaseName)
                .Options;

            //Act
            using( var context = new ApplicationContext(_options))
            {
                _ingredientRepository = new EntityFrameworkRepository<Ingredient>(context);
                var ingredientService = new IngredientService(_ingredientRepository);

                ingredientService.Insert(
                    Ingredient: new Ingredient() { Name = "Sauce", Amount = 1.0, Measurement = "Cup" }
                );
            }

            //Assert
            //Use a separate instance of the context to verify correct data was saved to database
            using (var context = new ApplicationContext(_options))
            {
                _ingredientRepository = new EntityFrameworkRepository<Ingredient>(context);
                var ingredientService = new IngredientService(_ingredientRepository);

                Assert.AreEqual(1, ingredientService.GetAll().Count());
                Ingredient addedIngredient = ingredientService.GetAll().First();
                Assert.AreEqual("Sauce", addedIngredient.Name);
                Assert.AreEqual(1.0, addedIngredient.Amount);
                Assert.AreEqual("Cup", addedIngredient.Measurement);
            }
        }

        [TestMethod]
        public void Remove_BasicIngredient_From_Database()
        {
            //Arrange
            _options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(databaseName: _databaseName)
                .Options;

            //Act
            using (var context = new ApplicationContext(_options))
            {
                _ingredientRepository = new EntityFrameworkRepository<Ingredient>(context);
                var ingredientService = new IngredientService(_ingredientRepository);

                ingredientService.Delete(1);
            }

            //Assert
            //Use a separate instance of the context to verify correct data was saved to database
            using (var context = new ApplicationContext(_options))
            {
                _ingredientRepository = new EntityFrameworkRepository<Ingredient>(context);
                var ingredientService = new IngredientService(_ingredientRepository);

                Assert.AreEqual(0, ingredientService.GetAll().Count());
                Ingredient addedIngredient = ingredientService.GetAll().FirstOrDefault();
                Assert.IsNull(addedIngredient);
            }
        }
    }
}
