using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_Entities
{
    public class Recipe
    {
        /* Structure:
         *      -Name
         *      -Ingredients (A collection of references)
         *      -Number Of Servings Provided
         *      -Instructions
         */
          
        /*  Something to consider:
         *      Should the Recipe be responisible for varieties? Or have a Parent object that tracks
         *      varriations of similar recipes?
         *      
         *      Example:
         *          Taco 'Family'
         *              - Tacos (My varriation)
         *              - Tacos (Mother's varraition)
         *              
         *              Both require a lot of the same base ingredients, but differ by the inclusion 
         *              or exclusion of one or a few ingredients.
         *              
         *              My varriation adds bananna peppers.
         *              My mother's varriation does not include peppers, but adds cut lettuce.
         *          
         *          Also, what about Chicken instead of ground beef? etc
         */

        protected string Name;

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }

        public virtual bool AttemptSetName(string proposedName)
        {
            throw new NotImplementedException();
        }

        protected List<Ingredient> Ingredients;

        public virtual List<Ingredient> GetListOfIngredients()
        {
            throw new NotImplementedException();
        }

        public virtual bool AttemptUpdateToIngredientList(List<Ingredient> proposedChangedIngredientList)
        {
            throw new NotImplementedException();
        }

        protected int BaseNumberOfServings;
        public List<string> Instructions;
    }
}
