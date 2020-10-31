using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Discord.Gateway;
using Discord;

namespace discord_massdm
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "Your token here";

            DiscordSocketClient client = new DiscordSocketClient();
            try
            {
                client.Login(token);
                client.OnLoggedIn += Client_OnLoggedIn;
            }
            catch { }
            Thread.Sleep(-1);
        }
        public static string message()
        {
            string message = "Ey yo dxmon just made this cool mass dm tool lol";

            return message;
        }
        private static void Client_OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
        {
            Thread.Sleep(69);
            foreach (var dm in client.GetPrivateChannels())
            {
                try
                {
                    dm.SendMessage(message());
                    Console.WriteLine("sent dm");
                    Thread.Sleep(420);
                }
                catch { }
            }
        }
    }
}
