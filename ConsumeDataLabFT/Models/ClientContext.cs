using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class ClientContext
    {
        public string clientID { get; set; }
        public string clientReference { get; set; }
        public string dppa { get; set; }
        public string userID { get; set; }
        public int glb { get; set; }
    }
}
