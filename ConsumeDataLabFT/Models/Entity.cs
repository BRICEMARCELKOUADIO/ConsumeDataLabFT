using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Entity
    {
        public AdditionalInfo additionalInfo { get; set; }
        public Addresses addresses { get; set; }
        public string entityType { get; set; }
        public string gender { get; set; }
        public Name name { get; set; }
        public Phones phones { get; set; }
        public Ids ids { get; set; }
    }
}
