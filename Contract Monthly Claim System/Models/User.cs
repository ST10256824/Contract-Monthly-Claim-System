using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Monthly_Claim_System.Models
{
    internal class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }  // Programme Coordinator, Academic Manager, Viewer
        public string Email { get; set; }

        // Navigation properties
        public ICollection<Contract> Contracts { get; set; }
    }
}
