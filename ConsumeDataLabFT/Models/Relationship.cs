using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Relationship
    {
        public string Group { get; set; }
        public string Type { get; set; }
        public int EntityId { get; set; }
        public DateTime DateModified { get; set; }
        public string EntityName { get; set; }
        public double OwnershipPercentage { get; set; }
        public string Segments { get; set; }
    }
}
