using Cultivate_Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cultivate_Repositories.EntityFramework.ModelMaps
{
    public class RecipeFamilyMap
    {
        public RecipeFamilyMap(EntityTypeBuilder<RecipeFamily> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.HasMany(t => t.RecipeVariants).WithOne();
        }
    }
}
