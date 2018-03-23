using Cultivate_Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Cultivate_Repositories.EntityFramework.ModelMaps
{
    public class RecipeMap
    {
        public RecipeMap(EntityTypeBuilder<Recipe> entityBuilder)
        {
            entityBuilder.HasKey(recipe => recipe.Id);

            entityBuilder.Property(recipe => recipe.Name).IsRequired();
            entityBuilder.Property(recipe => recipe.BaseNumberOfServings).IsRequired();

            entityBuilder.HasMany(recipe => recipe.Ingredients)
                .WithOne(i => i.Recipe)
                .HasForeignKey(i => i.RecipeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
