using System.Collections.Generic;

namespace Cultivate_Entities
{
    public class Recipe : BaseEntity
    {
        /* Structure:
         *      -Name
         *      -Ingredients (A collection of references)
         *      -Number Of Servings Provided
         *      -Instructions
         */
        public string Name { get; set; }
        public double BaseNumberOfServings { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Instructions { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}
