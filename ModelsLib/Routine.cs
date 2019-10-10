using System;
using System.Collections.Generic;
using HelperLib.Models;

namespace HelperLib {
    public class Routine {
        public static Dictionary<PersonModel, double> SalaryCache = new Dictionary<PersonModel, double>();

        public static int DifferenceInYears(DateTime start, DateTime end) {
            
            return (end.Year - start.Year - 1)  +
                   (((end.Month > start.Month) ||
                   ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }
    }
}
