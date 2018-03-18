using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_Entities
{
    public class InventoryItem
    {
        /* Structure:
         *      -Name
         *      -Amount
         *      -Measurement
         */

        /* Consideration:
         *      Should items stored in the pantry vs fridge vs freezer be separated by a property?
         *      Or should they be all be children of Inventory Item?
         *      
         *      Would there be any behavioural differences for these children? Or properties that
         *      apply to one category that are not relevant to the other(s)?
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

        protected double Amount;

        public virtual double GetAmount()
        {
            throw new NotImplementedException();
        }

        public virtual bool AttemptSetAmount(double proposedAmount)
        {
            throw new NotImplementedException();
        }
    }
}
