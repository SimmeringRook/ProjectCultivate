using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_Entities
{
    public class MeasurementUnit
    {

        /* A class feels excessive for storing the type of unit of measurement; however:
         * 
         *      It does offer the ability to have behaviour added, and able to convert to other units
         *          Or do I want to keep that specifically in the Utilities dll?
         *      It allows a system of units to be plugged into the system (Unlike the ENUM approach)
         * 
         * OR
         * 
         * Do I just leave this as a string?
         */ 
    }
}
