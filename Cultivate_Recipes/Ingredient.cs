using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_Recipes
{
    public class Ingredient : Cultivate_Entities.Ingredient
    {
        /* Consideration:
         * 
         *  I don't think the AttemptSet methods returning just a bool is useful.
         * 
         *  Point:
         *      When calling AttemptUpdateAmountAndMeasurement, and the DB doesn't update
         *      properly, I would return false. But this is a complex method, checking multiple
         *      values and attempting to update them; how would I know what part failed?
         *          Improper Format?
         *          Invalid Data?
         *          DB connection?
         *          Update Query failed?
         * 
         *      At least a Tuple<bool, string> would allow me to send the relevant error message
         *      back to the UI.
         * 
         *  OR:
         *      Am I assuming I have already checked for formating and invalid input being assigned
         *      at the Client layer, and this bool is just informing of a failed Update on the DB side?
         *      Would I still want to pass out an error message?
         * 
         *      In the case of AttemptUpdateAmountAndMeasurement, it might be helpful to know which
         *      value failed to update or if there's a connection issue
         *      
         * I think checking for formatting and improper data at the Client layer sounds good; because
         * I know I'll want to be able to deal with easily informing the user of issues at that stage.
         * I can then assume that all information leaving the Client layer and reaching this point will
         * be clean.
         * 
         * This then means I can strictly deal with checking for issues related to Updating the data:
         *      Duplicate Name
         *      Connection Issue
         *      Query Failure
         */

        //public override string GetName()
        //{
        //    return this.Name;
        //}

        //public override bool AttemptSetName(string proposedName)
        //{
        //    //TODO: Validate proposedName
        //    //TODO: check if name is currently used

        //    //Does this matter as much for an Ingredient as it does a Recipe?
        //    //Or am I just checking to see if this "Ingredient" already exists, with
        //    //Respect to the current recipe?
        //    throw new NotImplementedException();
        //}

        //protected override double GetAmount()
        //{
        //    return this.Amount;
        //}

        //protected override bool AttemptSetAmount(double proposedAmount)
        //{
        //    //TODO: Validate proposedAmount
        //    throw new NotImplementedException();
        //}

        //public override string GetMeasurementUnit()
        //{
        //    return this.MeasurementUnit.Measurement;
        //}

        //public override string GetMeasurementSystem()
        //{
        //    return this.MeasurementUnit.System;
        //}

        //protected override bool AttemptSetMeasurement(Cultivate_Entities.MeasurementUnit proposedMeasurement)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool AttemptUpdateAmountAndMeasurment(double proposedAmount, Cultivate_Entities.MeasurementUnit proposedMeasurement)
        //{
        //    //Save a copy of current values, in the event validation fails
        //    double currentAmount = this.Amount;
        //    Cultivate_Entities.MeasurementUnit currentMeasurement = this.MeasurementUnit;

        //    /* REVISIT:
        //     *  This might cause an issue, if I have the AttemptSet methods call the repository to update
        //     *  the values, as I would have to call AttemptSet again to replace the new value with the old
        //     *  value. What if that second call fails? I now have incorrect data stored and the revert failed.
        //     */ 
        //    bool proposedAmountIsValid = AttemptSetAmount(proposedAmount);
        //    bool proposedMeasurementIsValid = AttemptSetMeasurement(proposedMeasurement);

        //    if (proposedAmountIsValid == false || proposedMeasurementIsValid == false)
        //    {
        //        //Reassign old values, new values failed to pass validation
        //        this.Amount = currentAmount;
        //        this.MeasurementUnit = currentMeasurement;
        //        return false;
        //    }

        //    //Otherwise, both new proposed values have passed validation
        //    //And have been assigned

        //    return true;
        //}
    }
}
