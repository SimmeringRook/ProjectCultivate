using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_Recipes
{
    public class Recipe
    {
        /*  I should contain information about the Recipe:
         *      -Name
         *      -Ingredients (A collection of references)
         *      -Number Of Servings Provided
         *      -Instructions
         *      -
         * 
         *  Something to consider:
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
    }
}
