using System;

namespace HelperLib.Models {
    public class PersonModel {

        public int Id { get; set; }
        public PersonModel Boss { get; set; }


        public string FullName { get; set; }
        public double BaseRate { get; set; }
        public DateTime StartDate { get; set; }
        public int GroupId { get; set; }
        public IGroup Group { get; set; }

        public double CalculateSalary (DateTime onDate) {

            double result = 0.0;
            // Если расчет на дату меньше чем дата трудоустройства то и з/п нет
            if (onDate < StartDate || Group == null) return result;

            // Кличество полных отработанных лет для расчета з/п
            var years = Routine.DifferenceInYears(StartDate, onDate);
            

            return result;
        }
    }
}
