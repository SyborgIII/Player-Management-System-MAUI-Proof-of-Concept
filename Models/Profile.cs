using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaScoreApp.Maui.Models
{
    public class Profile

    {
        public int ProfileId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;   

        public List<int> MyPlayersIdList = new List<int>(); 

        public List<int> MySessionsIdList = new List<int>();

        public List<int> MyAppraisalsIdList = new List<int>();



    }
}
