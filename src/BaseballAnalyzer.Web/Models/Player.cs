using System;

namespace BaseballAnalyzer.Web.Models
{
    public class Player
    {
		public string Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Bats { get; set; }
		public string Throws { get; set; }
		public string Position { get; set; }
    }
}