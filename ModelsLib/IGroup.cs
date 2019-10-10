using System;
using System.Collections.Generic;
using HelperLib.Models;

namespace HelperLib {
    public interface IGroup {
        int Id { get; set; }
        string Name { get; set; }

        double YearCoeff { get; set; }
        double YearCoeffLimit { get; set; }
        double BonusPercent { get; set; }

        double CalculateSalary(PersonModel PersonId, DateTime onDate);
    }
}
