using Cultivate_Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Cultivate_Repositories.EntityFramework.ModelMaps
{
    public class IngredientMap
    {
        public IngredientMap(EntityTypeBuilder<Ingredient> entityBuilder)
        {
            entityBuilder.HasKey(ingredient => ingredient.Id);

            entityBuilder.Property(ingredient => ingredient.Name).IsRequired();
            entityBuilder.Property(ingredient => ingredient.Amount).IsRequired();
            entityBuilder.Property(ingredient => ingredient.Measurement).IsRequired();
            entityBuilder.Property(ingredient => ingredient.RecipeID).IsRequired();

            entityBuilder.HasOne(ingredient => ingredient.Recipe)
                .WithMany(recipe => recipe.Ingredients)
                .HasForeignKey(ingredient => ingredient.RecipeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
