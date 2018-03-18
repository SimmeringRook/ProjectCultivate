using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_Inventory
{
    public class InventoryItem : Cultivate_Entities.InventoryItem
    {
        public override string GetName()
        {
            return this.Name;
        }

        public override bool AttemptSetName(string proposedName)
        {
            //TODO: Validate proposedName
            //TODO: check if name is currently used

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
