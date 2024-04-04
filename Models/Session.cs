using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SiaScoreApp.Maui.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string Name { get; set; } = string.Empty;


        public string Type { get; set; } =  string.Empty; 
        public DateTime Date { get; set; }
    }
}
