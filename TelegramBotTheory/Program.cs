using System;
using System.Threading.Tasks;
using MihaZupan;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotTheory
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var proxy = new HttpToSocks5Proxy(
                "", 0, "", ""
            );
            proxy.ResolveHostnamesLocally = true;
            
            var botClient = new TelegramBotClient("", proxy);
            var s = await botClient.SendTextMessageAsync("@dot_net_ru_test_channel", "hey, this message from the bot");

            var chat = await botClient.GetChatAsync(new ChatId("@dot_net_ru_test_channel"));
        }
    }
}