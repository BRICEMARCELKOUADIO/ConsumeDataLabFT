using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Watchlist
    {
        public IList<Match> Matches { get; set; }
        public string Status { get; set; }
    }
}
