using Cultivate_Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Cultivate_Repositories.EntityFramework.ModelMaps
{
    public class MealPlanMap
    {
        public MealPlanMap(EntityTypeBuilder<MealPlan> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.DayForPlannedMeal).IsRequired();
            entityBuilder.Property(t => t.MealTime).IsRequired();
            entityBuilder.Property(t => t.PlannedServings).IsRequired();
            entityBuilder.HasOne(t => t.PlannedRecipe).WithOne().HasForeignKey<Recipe>(r => r.Id);
        }
    }
}
