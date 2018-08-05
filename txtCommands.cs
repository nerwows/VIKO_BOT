using System.Threading.Tasks;
using Discord.Commands;
using System;
using Discord.WebSocket;

namespace VIKO_BOT
{
    public class txtCommands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong.");
        }

        [Command("amigay")]
        public async Task IsGay()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 2);
            string answer = "";

            if (value == 0)
                answer = "no";
            else
                answer = "yes";

            await ReplyAsync(answer);
        }

        [Command("help")]
        public async Task Help()
        {
            await ReplyAsync("Current commands: \n/viko amigay - Your gay status.");
        }

        [Command("test")]
        public async Task Test()
        {
            Console.WriteLine(Context.Message.Author);
            await ReplyAsync(Context.Message.Author.Mention);
        }
    }
}
