using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class SearchResponse
    {
        public string ClientReference { get; set; }
        public IList<Record> Records { get; set; }
        public string SearchEngineVersion { get; set; }
    }
}
