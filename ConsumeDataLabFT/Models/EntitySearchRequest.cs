using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class EntitySearchRequest
    {
        public ClientContext clientContext { get; set; }
        public Configuration configuration { get; set; }
        public Input input { get; set; }
    }
}
