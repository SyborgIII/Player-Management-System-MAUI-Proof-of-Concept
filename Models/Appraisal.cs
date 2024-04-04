using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaScoreApp.Maui.Models
{
    public class Appraisal
    {
        public int AppraisalId {  get; set; }    
        public bool Executed { get; set; }  
        public int PlayerId { get; set; }
        public int SessionId {  get; set; }
        public int PlayNumber { get; set; } 

        public string AppraisalText => $"Play Number: {PlayNumber} | Player #: {PlayerId} Executed";
    }
}
