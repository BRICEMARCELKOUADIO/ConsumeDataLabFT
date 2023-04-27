using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class InputID
    {
        public DateExpires dateExpires { get; set; }
        public DateIssued dateIssued { get; set; }
        public string issuer { get; set; }
        public string label { get; set; }
        public string machineReadableLine1 { get; set; }
        public string machineReadableLine2 { get; set; }
        public string number { get; set; }
        public string placeOfBirth { get; set; }
        public string countryOfBirth { get; set; }
        public string familyNameAtBirth { get; set; }
        public string familyNameAtCitizenship { get; set; }
        public string cityOfIssue { get; set; }
        public string countyOfIssue { get; set; }
        public string districtOfIssue { get; set; }
        public string provinceOfIssue { get; set; }
        public string stateOfBirth { get; set; }
        public string driverLicenceVersionNumber { get; set; }
        public string type { get; set; }
        public string accountType { get; set; }
    }
}
