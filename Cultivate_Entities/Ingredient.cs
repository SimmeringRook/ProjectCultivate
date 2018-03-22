namespace Cultivate_Entities
{
    public class Ingredient : InventoryItem
    {
        /* I should contain information about the Ingredient:
         *      -Name (? - see consideration below)
         *      -Amount
         *      -Measurement Unit
         */
        public virtual Recipe Recipe { get; set; }
        /*  Something to consider:
        *      Should "Ingredient" be a separate entity from what is tracked in the 
        *      inventory?
        *      
        *      If it is:
        *          Then the Ingredient object will need a reference to the item
        *      
        *      public virtual InventoryItem InventoryItem { get; set; }
        *      
        *      If it is not:
        *          Then the Recipe would need to contain the amounts and 
        *          corresponding measurements for the ingredient; as the Ingredient
        *          object itself would be responsible for tracking the current amount
        *          stored in the pantry/fridge.
        *          
        *          NOTE:
        *          This seems to be the messy approach, as it forces inventory management
        *          to be dependent on the Ingredient object; which (ingredients) do not 
        *          effect the quantities stored. Any planned meals should be doing a direct
        *          handshake with the inventory to update changes in the stored amount.
        *          
        *          Recipes and Ingredients should be a tool utilized by meal planning to
        *          calculate amounts and items needed to facilitate the planned meals.
        *          
        */
    }
}
