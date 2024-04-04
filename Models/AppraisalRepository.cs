using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaScoreApp.Maui.Models
{
    public static class AppraisalRepository
    {
        public static List<Appraisal> AllAppraisalsList = new List<Appraisal>()
        {
            new Appraisal {AppraisalId = 1, PlayerId = 1, Executed = true, PlayNumber = 1},
            new Appraisal {AppraisalId = 2, PlayerId = 3, Executed = true, PlayNumber = 2},
            new Appraisal {AppraisalId = 3, PlayerId = 2, Executed = true, PlayNumber = 3},
            new Appraisal {AppraisalId = 4, PlayerId =1, Executed = true, PlayNumber = 4},
            new Appraisal {AppraisalId = 5, PlayerId = 3, Executed = true, PlayNumber = 1},
            new Appraisal {AppraisalId = 6, PlayerId = 4, Executed = true, PlayNumber = 2},
            new Appraisal {AppraisalId = 7, PlayerId = 1, Executed = true, PlayNumber = 3},
        };

        public static List<Appraisal> GetAllAppraisalsList() { return AllAppraisalsList; }

        public static Appraisal GetAppraisalById(int playerId)
        {
            return AllAppraisalsList.FirstOrDefault(x => x.AppraisalId == playerId);
        }
    }
}
