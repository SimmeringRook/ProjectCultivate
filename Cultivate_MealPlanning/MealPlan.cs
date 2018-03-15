using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_MealPlanning
{
    public class MealPlan
    {
        /* I should contain either:
         *      1) the information of what ingredients are needed and their measurements
         *      or
         *      2) A reference to the Recipe object, and the planned # of servings to be made
         * 
         * Also, I should have the date and (time/"meal time") for this 'meal'
         *      "Meal Time" = Breakfast, Lunch, Dinner
         *      
         *      
         *  Example 1):
         *      Dinner - 3/14/18: "Tacos"
         *      Servings: 2
         *      Ingredients         Amount
         *        Ground Beef         1/2 lbs
         *        Taco Shells         4 Shells
         *        Shredded Cheese     1/4 cup
         *        Taco Seasoning      1 packet
         * 
         *  Example 2):
         *      Dinner - 3/14/18
         *      Recipe: "Tacos"
         *      Servings: 2
         *      (Ingredients are then accessible through the Recipe object and
         *      quantities are adjusted based off the 'Servings' value)
         *      
         *      
         *  Method 1 would require 'stripping' the relevant recipe data from the associated Recipe object
         *  and poppulating it into the MealPlan properties.
         *  
         *  Method 2 only requires looking up the corresponding Recipe object and saving its reference.
         *  
         *  Either way, while MealPlan might be dependent on Recipe and Recipe's dependencies, it should be 
         *  a separate concept from Recipe and Ingredients entirely. Changes to the structure and behaviour
         *  of the MealPlan object should have no impact on the Recipe class or overall Recipe management. 
         *  The same should be true for Ingredients.
         */ 
    }
}
