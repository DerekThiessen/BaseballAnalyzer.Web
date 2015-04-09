using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.Framework.ConfigurationModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BaseballAnalyzer.Web.Models
{
    public class TeamRoster : TableEntity
    {
		public TeamRoster() {}

		public TeamRoster(string lastName, string firstName)
		{
			PartitionKey = lastName;
			RowKey = firstName;
		}

		public string Year { get; set; }
		public string Name { get; set; }
		
		public IEnumerable<Player> Players { get; set; }
    }
}