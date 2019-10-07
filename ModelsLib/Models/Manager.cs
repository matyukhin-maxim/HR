using System.Collections.Generic;

namespace HelperLib.Models {
    public class Manager : IGroup {
        public int YearRate => throw new System.NotImplementedException();

        public int MaxRate => throw new System.NotImplementedException();

        public List<PersonModel> Dependents { get; set; } = new List<PersonModel>();

        public bool AddDependent(PersonModel p) {

            Dependents.Add(p);
            return Dependents.Count > 0;
        }
    }
}
