using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MURDoX.Core.Commands.Bot
{
    public class BotStatusCommand : BaseCommandModule
    {
        [Command("botstatus")]
        [Description("get the bot status")]
        public async Task BotStatus(CommandContext ctx)
        {
            //this is async test command
        }
    }
}
