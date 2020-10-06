using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoyoApp.Server.Helpers;
using YoyoApp.Shared;

namespace YoyoApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        // Get All players
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            var players = PlayerHelper.FetchPlayers();
            return players.ToArray();
        }

        [HttpPost]
        public IActionResult Post(Player[] players)
        {
            try
            {
                var updatedPlayers = PlayerHelper.UpdatePlayers(players.ToList());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
            return new OkResult();
        }
    }
}
