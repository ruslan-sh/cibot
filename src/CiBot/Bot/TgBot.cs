using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace RuslanSh.CiBot.Bot
{
	public class TgBot : IBot
	{
		private ITelegramBotClient _bot;
		
		public TgBot(string token)
		{
			_bot = new TelegramBotClient(token);
			var me = _bot.GetMeAsync().Result;
			_bot.OnMessage += BotOnMessageReceived;
			_bot.StartReceiving();
			Console.WriteLine($"Start listening for @{me.Username}");
		}

		private static void BotOnMessageReceived(object sender, MessageEventArgs e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
