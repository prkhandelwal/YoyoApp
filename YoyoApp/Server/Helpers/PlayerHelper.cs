using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoyoApp.Shared;

namespace YoyoApp.Server.Helpers
{
    public static class PlayerHelper
    {
        private static List<Player> Players = new List<Player>()
        {
            new Player()
            {
                Name = "Marshal",
                Score = String.Empty
            },
            new Player()
            {
                Name = "Dre",
                Score = String.Empty
            },
            new Player()
            {
                Name = "Cent",
                Score = String.Empty
            },
        };

        public static List<Player> FetchPlayers()
        {
            return Players;
        }

        public static List<Player> UpdatePlayers(List<Player> updatedList)
        {
            Players = updatedList;
            return Players;
        }
    }
}
