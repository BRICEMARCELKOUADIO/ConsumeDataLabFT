using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class SearchConfiguration
    {
        public AssignResultTo AssignResultTo { get; set; }
        public string PredefinedSearchName { get; set; }
        public string WriteResultsToDatabase { get; set; }
        public string ExcludeScreeningListMatches { get; set; }
        public string DuplicateMatchSuppression { get; set; }
        public string DuplicateMatchSuppressionSameDivisionOnly { get; set; }
    }
}
