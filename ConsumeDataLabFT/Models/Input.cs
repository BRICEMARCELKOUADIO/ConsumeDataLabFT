using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Input
    {
        public string blockID { get; set; }
        public IList<Record> records { get; set; }
    }
}
