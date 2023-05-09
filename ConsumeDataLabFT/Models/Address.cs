using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Address
    {
        //public string Country { get; set; }
        //public string Type { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public int ID { get; set; }
        public string PostalCode { get; set; }
        public string StateProvinceDistrict { get; set; }
        public string Street1 { get; set; }
        public string Type { get; set; }
        public string Street2 { get; set; }
    }
}
