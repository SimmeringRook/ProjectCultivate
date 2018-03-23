using System;

namespace Cultivate_Entities
{
    public class InventoryItem : BaseEntity
    {
        /* Structure:
         *      -Name
         *      -Amount
         *      -Measurement
         */
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Measurement { get; set; }
        
        /* Consideration:
         *      Should items stored in the pantry vs fridge vs freezer be separated by a property?
         *      Or should they be all be children of Inventory Item?
         *      
         *      Would there be any behavioural differences for these children? Or properties that
         *      apply to one category that are not relevant to the other(s)?
         */

        
    }
}
