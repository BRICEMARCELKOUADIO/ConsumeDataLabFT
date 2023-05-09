using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Record
    {
        public Entity Entity { get; set; }

        //public int Record { get; set; }
        public RecordDetails RecordDetails { get; set; }
        public long ResultID { get; set; }
        public int RunID { get; set; }
        public Watchlist Watchlist { get; set; }
    }
}
