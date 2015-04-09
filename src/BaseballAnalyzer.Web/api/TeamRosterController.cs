using BaseballAnalyzer.Web.Models;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace BaseballAnalyzer.Web.api
{
	[Route("api/[controller]")]
	public class TeamRosterController : Controller
    {
		List<Player> players = new List<Player>()
		{
			new Player { Id = "adama001", LastName = "Adams", FirstName = "Austin", Bats = "Right", Throws = "Right", Position = "P" },
			new Player { Id = "aguij001", LastName = "Aguilar", FirstName = "Jesus", Bats = "Right", Throws = "Right", Position = "1B" },
			new Player { Id = "allec002", LastName = "Allen", FirstName = "Cody", Bats = "Right", Throws = "Right", Position = "P" },
			new Player { Id = "atchs001", LastName = "Atchison", FirstName = "Scott", Bats = "Right", Throws = "Right", Position = "P" },
			new Player { Id = "avilm001", LastName = "Aviles", FirstName = "Mike", Bats = "Right", Throws = "Right", Position = "SS" }
		};
		
		[HttpGet]
		public IEnumerable<TeamRoster> Get()
        {
			var teamRoster = new TeamRoster();
			teamRoster.Players = players;

			yield return teamRoster;
		}
    }
}
