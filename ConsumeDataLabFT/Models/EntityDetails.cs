using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class EntityDetails
    {
        public IList<AdditionalInfo> AdditionalInfo { get; set; }
        public IList<Address> Addresses { get; set; }
        public IList<AKA> AKAs { get; set; }
        public string Comments { get; set; }
        public string DateListed { get; set; }
        public string EntityType { get; set; }
        public string Gender { get; set; }
        public IList<ID> IDs { get; set; }
        public string ListReferenceNumber { get; set; }
        public Name Name { get; set; }
    }
}
