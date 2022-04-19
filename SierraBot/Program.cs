using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace SierraBot
{
	public class Program
	{
		private DiscordSocketClient _client;

		public static void Main(string[] args)
			=> new Program().MainAsync().GetAwaiter().GetResult();

		public async Task MainAsync()
		{
			_client = new DiscordSocketClient();
		}
	}
}
