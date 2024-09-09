using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Monthly_Claim_System.Models
{
    internal class Claim
    {
        public int ClaimID { get; set; }
        public int ContractID { get; set; }  // Foreign Key
        public DateTime ClaimDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }  // Pending, Approved, Rejected
        public int SubmittedBy { get; set; }  // Foreign Key

        // Navigation properties
        public Contract Contract { get; set; }
        public User User { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<Approval> Approvals { get; set; }

    }
}
