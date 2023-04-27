using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class OAuth2Token
    {
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public int expires_on { get; set; }
        public int not_before { get; set; }
        public string resource { get; set; }
        public string access_token { get; set; }
    }
}
