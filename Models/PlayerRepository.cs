using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiaScoreApp.Maui.Models
{
    public static class PlayerRepository
    {
        public static List<Player> AllPlayersList = new List<Player>()
        {
            new Player { PlayerId = 1, FirstName = "Simon", LastName = "Codrington Jr", TeamName = "Eastern Kentucky University"},
            new Player { PlayerId = 2, FirstName = "Simon", LastName = "Codrington III", TeamName = "University of Florida"},
            new Player { PlayerId = 3, FirstName = "Melanie", LastName = "Smith", TeamName = "University of St.Petersburg"},
            new Player { PlayerId = 4, FirstName = "Sia", LastName = "Codrington Walker" , TeamName = "Harvard University"},
            new Player { PlayerId = 5, FirstName = "Jarrett",LastName = "Morris", TeamName = "Florida State University"},
            new Player { PlayerId = 6, FirstName = "Brandon",LastName = "Davis", TeamName = "University of Northern Alabama"}
        };

        public static List<Player> GetMyPlayerList() { return AllPlayersList; }

        public static Player GetPlayerById(int playerId)
        {
            var Player = AllPlayersList.FirstOrDefault(x => x.PlayerId == playerId);
            if(Player != null)
            {
                return new Player
                {
                    PlayerId = playerId,
                    FirstName = Player.FirstName,
                    LastName = Player.LastName,
                    TeamName = Player.TeamName,

                };
            }
            return null;
        }

        public static void UpdatePlayer(int playerId, Player player)
        {
            if (playerId != player.PlayerId) return;

            var PlayerToUpdate = AllPlayersList.FirstOrDefault(x =>x.PlayerId == playerId);
            if(PlayerToUpdate != null )
            {
                PlayerToUpdate.FirstName = player.FirstName;
                PlayerToUpdate.LastName = player.LastName;
                PlayerToUpdate.TeamName = player.TeamName;

            }
        }




    }
}
