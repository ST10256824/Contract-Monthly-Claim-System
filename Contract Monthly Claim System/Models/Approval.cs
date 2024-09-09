using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Monthly_Claim_System.Models
{
    internal class Approval
    {
        public int ApprovalID { get; set; }
        public int ClaimID { get; set; }  // Foreign Key
        public int ApprovedBy { get; set; }  // Foreign Key
        public DateTime ApprovalDate { get; set; }
        public string Comments { get; set; }

        // Navigation properties
        public Claim Claim { get; set; }
        public User User { get; set; }
    }
}
