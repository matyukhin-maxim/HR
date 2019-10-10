using System;
using System.Collections.Generic;
using System.Linq;

namespace HelperLib.Models {
    public class Salesman : IGroup {
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

            var result = 0.0;
            var years = Routine.DifferenceInYears(Person.HireDate, onDate);

            // if person hired later than calulate date - his salary is none
            if (onDate > Person.HireDate) {

                // need calc salary of dependent (only first level [which mean Employee, I guess])
                var slaves = SqliteDataAccess.GetDependentPersonal(Person.Id);
                var groups = SqliteDataAccess.GetAllGroups().ToDictionary(x => x.Id, x => x);

                double total = 0.0;
                foreach (PersonModel pers in slaves) {

                    var grp = groups[pers.GroupId]; // foreign key helps avoid exception
                    total += grp.CalculateSalary(pers, onDate);
                }

                result = Person.BaseRate +
                         (Person.BaseRate * Math.Min(years * YearCoeff, YearCoeffLimit)) +
                         total * BonusPercent;
            }

            // save in cache
            Routine.SalaryCache[Person] = result;

            return result;
        }
    }
}
