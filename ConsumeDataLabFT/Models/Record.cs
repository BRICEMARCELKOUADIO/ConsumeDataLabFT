using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Record
    {
        public Eft eft { get; set; }
        public Entity entity { get; set; }
        public Id id { get; set; }
        public int recordID { get; set; }
        public Text text { get; set; }
    }
}
