using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Configuration
    {
        public AssignResultTo assignResultTo { get; set; }
        public bool duplicateMatchSuppression { get; set; }
        public bool duplicateMatchSuppressionSameDivisionOnly { get; set; }
        public string excludeScreeningListMatches { get; set; }
        public string predefinedSearchName { get; set; }
        public bool writeResultsToDatabase { get; set; }
    }
}
