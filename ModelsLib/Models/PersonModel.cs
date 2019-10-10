using System;

namespace HelperLib.Models {
    public class PersonModel {
        public int Id { get; set; }
        public string FullName { get; set; }
        public double BaseRate { get; set; }
        public DateTime HireDate { get; set; }
        public int GroupId { get; set; }
    }
}
