using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class PEP
    {
        public IList<string> SubCategories { get; set; }
        public string AdminLevel { get; set; }
        public DateTime DateModified { get; set; }
        public string Status { get; set; }
        public bool IsPrimary { get; set; }
        public string CountryRole { get; set; }
        public string EffectiveDateType { get; set; }
        public string ExpirationDateType { get; set; }
        public string Country { get; set; }
        public string GoverningInstitution { get; set; }
        public string GoverningRole { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpirationDate { get; set; }
    }
}
