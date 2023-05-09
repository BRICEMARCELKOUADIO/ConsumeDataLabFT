using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Entity
    {
        public string EntityType { get; set; }
        public Name Name { get; set; }
        public IList<AdditionalInfo> AdditionalInfo { get; set; }
        public IList<Address> Addresses { get; set; }
    }
}
