using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Monthly_Claim_System.Models
{
    internal class Contract
    {
        public int ContractID { get; set; }
        public string ContractNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserID { get; set; }  // Foreign Key

        // Navigation properties
        public User User { get; set; }
        public ICollection<Claim> Claims { get; set; }
    }
}
