using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Models
{
    public class RecordDetails
    {
        public int AcceptListID { get; set; }
        public string AccountAmount { get; set; }
        public string AccountGroupID { get; set; }
        public string AccountOtherData { get; set; }
        public string AccountProviderID { get; set; }
        public string AccountMemberID { get; set; }
        public string AccountType { get; set; }
        public bool AddedToAcceptList { get; set; }
        public IList<AdditionalInfo> AdditionalInfo { get; set; }
        public IList<Address> Addresses { get; set; }
        public string Division { get; set; }
        public string DPPA { get; set; }
        public string EFTType { get; set; }
        public string EntityType { get; set; }
        public string Gender { get; set; }
        public int GLB { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public Name Name { get; set; }
        public RecordState RecordState { get; set; }
        public DateTime SearchDate { get; set; }
    }
}
