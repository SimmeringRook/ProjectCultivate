using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_Recipes
{
    public class Ingredient : Cultivate_Entities.Ingredient
    {
        public override string GetName()
        {
            return this.Name;
        }

        public override bool AttemptSetName(string proposedName)
        {
            //TODO: Validate proposedName
            //TODO: check if name is currently used

            //Does this matter as much for an Ingredient as it does a Recipe?
            //Or am I just checking to see if this "Ingredient" already exists, with
            //Respect to the current recipe?
            throw new NotImplementedException();
        }

        public override double GetAmount()
        {
            return this.Amount;
        }

        public override bool AttemptSetAmount(double proposedAmount)
        {
            //TODO: Validate proposedAmount
            throw new NotImplementedException();
        }

        
    }
}
