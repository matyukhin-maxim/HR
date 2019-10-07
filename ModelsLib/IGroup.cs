using System;
using System.Collections.Generic;
using HelperLib.Models;

namespace HelperLib {
    public interface IGroup {
        double YearRate { get; }
        double MaxRate { get; }
        double SalaryDependPercent { get; }

        List<PersonModel> Dependents { get; set; }
        bool AddDependent(PersonModel p);
    }
}
