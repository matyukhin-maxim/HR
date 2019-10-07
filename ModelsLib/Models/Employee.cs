using System;
using System.Collections.Generic;

namespace HelperLib.Models {
    public class Employee : IGroup {
        public int YearRate => 3;
        public int MaxRate => 30;

        public List<PersonModel> Dependents { get; set; } = new List<PersonModel>(0);
        public bool AddDependent(PersonModel p) {

            throw new ArgumentException("Employee can't have any dependent");
        }
    }
}
