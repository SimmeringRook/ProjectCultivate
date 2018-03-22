using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cultivate_Entities;

namespace Cultivate_Recipes
{
    public class Recipe : Cultivate_Entities.Recipe
    {
        /// <summary>
        /// I should contain the business logic for Recipe.
        /// 
        /// This means I should be the one who validates data, eg:
        /// Does the user's input for the "Name" statisfiy the naming requirements?
        /// </summary>

        //TODO: Find the place where this all belongs

        //public override string GetName()
        //{
        //    return this.Name;
        //}

        //public override bool AttemptSetName(string proposedName)
        //{
        //    /* At the very least, I should call the relevant function from
        //     * Cultivate_Utilities to validate the string
        //     * 
        //     * Should this also involve a call to the Repository to see if 
        //     * the name is already enuse? and Prevent duplicate records here?
        //     */ 
        //    return base.AttemptSetName(proposedName);
        //}

        //public override List<Cultivate_Entities.Ingredient> GetListOfIngredients()
        //{
        //    //This list should be using the subclass of Cultivate_Recipes.Ingredients
        //    //not Cultivate_Entities.Ingredients

        //    //TODO:: Convert List<Cultivate_Entities.Ingredients> to List<Cultivate_Recipes.Ingredients>
        //    return Ingredients.ToList();
        //}

        //public override bool AttemptUpdateToIngredientList(List<Cultivate_Entities.Ingredient> proposedChangedIngredientList)
        //{
        //    //TODO: Compare differences between proposedChangedIngredientList and Ingredients
        //    //Remove, Add, or Update as necessary

        //    //If no changes, return true?
        //    //If a change could not be done - false
        //    //  But what change would fail?
        //    throw new NotImplementedException();
        //}
    }
}
