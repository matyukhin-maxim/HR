using System.Collections.Generic;

namespace HelperLib.Models {
    public class Manager : IGroup {
        public double YearRate => 0.05;
        public double MaxRate => 0.40;

        public List<PersonModel> Dependents { get; set; } = new List<PersonModel>();

        public bool AddDependent(PersonModel p) {

            Dependents.Add(p);
            return Dependents.Count > 0;
        }
    }
}
