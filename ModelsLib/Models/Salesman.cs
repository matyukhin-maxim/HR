using System.Collections.Generic;
namespace HelperLib.Models {
    public class Salesman : IGroup {
        public double YearRate => 0.01;
        public double MaxRate => 0.35;

        public List<PersonModel> Dependents { get; set; } = new List<PersonModel>();

        public bool AddDependent(PersonModel p) {
            
            Dependents.Add(p);
            return Dependents.Count > 0;
        }
    }
}
