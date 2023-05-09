using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class Match
    {
        public int AcceptListID { get; set; }
        public bool AddedToAcceptList { get; set; }
        public bool AddressName { get; set; }
        public bool AutoFalsePositive { get; set; }
        public bool BestAddressIsPartial { get; set; }
        public string BestCountry { get; set; }
        public int BestCountryScore { get; set; }
        public string BestCountryType { get; set; }
        public bool BestDOBIsPartial { get; set; }
        public string BestName { get; set; }
        public int BestNameScore { get; set; }
        public int CheckSum { get; set; }
        public Conflicts Conflicts { get; set; }
        public IList<DOB> DOBs { get; set; }
        public EntityDetails EntityDetails { get; set; }
        public string EntityName { get; set; }
        public int EntityScore { get; set; }
        public string EntityUniqueID { get; set; }
        public bool FalsePositive { get; set; }
        public File File { get; set; }
        public bool GatewayOFACScreeningIndicatorMatch { get; set; }
        public object ID { get; set; }
        public bool MatchReAlert { get; set; }
        public MatchXML MatchXML { get; set; }
        public int PreviousResultID { get; set; }
        public string ReasonListed { get; set; }
        public DateTime ResultDate { get; set; }
        public bool SecondaryOFACScreeningIndicatorMatch { get; set; }
        public bool TrueMatch { get; set; }
        public IList<Relationship> Relationships { get; set; }
        public IList<PEP> PEPs { get; set; }
        public IList<Enforcement> Enforcements { get; set; }
        public IList<AdverseMedia> AdverseMedias { get; set; }
        public IList<SourceItem> SourceItems { get; set; }
        public DateTime DateModified { get; set; }
        public string Status { get; set; }
    }
}
