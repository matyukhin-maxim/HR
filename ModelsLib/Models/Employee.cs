using System;

namespace HelperLib.Models {
    public class Employee : IGroup {
        public int Id { get; set; }
        public string Name { get; set; }
        public double YearCoeff { get; set; }
        public double YearCoeffLimit { get; set; }
        public double BonusPercent { get; set; }

        public double CalculateSalary(PersonModel Person, DateTime onDate) {

            // if person already calculated return exist value (optimization)
            if (Routine.SalaryCache.ContainsKey(Person)) {

                return Routine.SalaryCache[Person];
            }

            var years = Routine.DifferenceInYears(Person.HireDate, onDate);
            var result = 0.0;

            // if person hired later than calulate date - his salary is none
            if (onDate > Person.HireDate) {

                result = Person.BaseRate + (Person.BaseRate * Math.Min(years * YearCoeff, YearCoeffLimit));
            }

            //save to cache
            Routine.SalaryCache[Person] = result;

            return result;
        }
    }
}
