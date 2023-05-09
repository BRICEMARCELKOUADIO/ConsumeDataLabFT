using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class History
    {
        public DateTime Date { get; set; }
        public string Event { get; set; }
        public string Note { get; set; }
        public string User { get; set; }
    }
}
