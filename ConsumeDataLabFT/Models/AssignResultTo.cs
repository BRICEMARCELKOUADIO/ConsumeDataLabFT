using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class AssignResultTo
    {
        public string division { get; set; }
        public bool emailNotification { get; set; }
        public IList<string> rolesOrUsers { get; set; }
        public string Type { get; set; }
    }
}
