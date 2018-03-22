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
        public int BaseNumberOfServings { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<string> Instructions { get; set; }

    }
}
