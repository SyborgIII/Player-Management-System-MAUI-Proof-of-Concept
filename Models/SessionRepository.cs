using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaScoreApp.Maui.Models
{
    public static class SessionRepository
    {
        public static List<string> SessionTypeList { get; } = new List<string>
        {
            "Game","Practice","Training"
        };
        public static List<Session> AllSessionsList = new List<Session>()
        {
            new Session{SessionId = 1, Name = "Florida Vs Ohio State", Date = new DateTime(2006,1,6), Type = SessionTypeList[0] },
            new Session{SessionId = 2, Name = "Scrimmage #1", Date = new DateTime(2005,8,23), Type = SessionTypeList[1] },
            new Session{SessionId = 3, Name = "Summer Camp Drills #1", Date = new DateTime(2005,3,2), Type = SessionTypeList[2] },
            new Session{SessionId = 4, Name = "1v1 Pass Rush  #1", Date = new DateTime(2005,7,20), Type = SessionTypeList[2] },

        };

        public static void UpdateSession(int sessionId, Session session)
        {
            if (sessionId != session.SessionId) return;
            var SessionToUpdate = SessionRepository.GetSessionById(sessionId);
            if(SessionToUpdate != null)
            {
                SessionToUpdate.Name = session.Name;
                SessionToUpdate.Type = session.Type;
                SessionToUpdate.Date = session.Date;    
            }
        }

        public static List<Session> GetMySessionList() { return AllSessionsList; }

        public static Session GetSessionById(int sessionId)
        {
            return AllSessionsList.FirstOrDefault(x => x.SessionId == sessionId);
        }
    }
}
