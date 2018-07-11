using Microsoft.Extensions.Configuration;

namespace RuslanSh.CiBot.Bot
{
	class Program
	{
		static void Main(string[] args)
		{
			var config = getConfig();
			var tgToken = config["telegram-token"];
			var bot = new TgBot(tgToken);
		}

		private static IConfiguration getConfig()
		{
			var builder = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.AddJsonFile("appsettings.local.json", /*optional:*/ true);
			return builder.Build();
		}
	}
}
