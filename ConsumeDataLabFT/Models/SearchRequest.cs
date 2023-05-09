using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class SearchRequest
    {
        public ClientContext ClientContext { get; set; }
        public SearchConfiguration SearchConfiguration { get; set; }
        public SearchInput SearchInput { get; set; }
    }
}
