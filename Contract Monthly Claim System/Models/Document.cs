using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Monthly_Claim_System.Models
{
    internal class Document
    {
        public int DocumentID { get; set; }
        public int ClaimID { get; set; }  // Foreign Key
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }

        // Navigation properties
        public Claim Claim { get; set; }

    }
}
