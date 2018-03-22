using System;

namespace Cultivate_Entities
{
    public class MealPlan : BaseEntity
    {
        /* Structure:
         *      Dinner - 3/14/18
         *      Recipe: "Tacos"
         *      Servings: 2
         *      (Ingredients are then accessible through the Recipe object and
         *      quantities are adjusted based off the 'Servings' value)
         */

        public string MealTime { get; set; }
        public DateTime DayForPlannedMeal { get; set; }
        public virtual Recipe PlannedRecipe { get; set; }
        public double PlannedServings { get; set; }

    }
}
