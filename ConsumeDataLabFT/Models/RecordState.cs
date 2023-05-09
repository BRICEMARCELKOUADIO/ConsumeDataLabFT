using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class RecordState
    {
        public bool AddedToAcceptList { get; set; }
        public string AlertState { get; set; }
        public IList<string> AssignedTo { get; set; }
        public string AssignmentType { get; set; }
        public string Division { get; set; }
        public IList<History> History { get; set; }
        public IList<MatchState> MatchStates { get; set; }
        public string Status { get; set; }
    }
}
