using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MURDoX.Services.Models
{
    public class EmbedColors
    {
        public static Dictionary<string, DiscordColor> Colors { get; set; } = new Dictionary<string, DiscordColor>()
        {
            {"blue", DiscordColor.Blue}, {"gold", DiscordColor.Gold}, {"green", DiscordColor.Green},
            {"magenta", DiscordColor.Magenta}, {"orange", DiscordColor.Orange}, {"purple", DiscordColor.Purple },
            {"red", DiscordColor.Red}, {"teal", DiscordColor.Teal}, {"darkblue", DiscordColor.DarkBlue},
            {"auquamarine", DiscordColor.Aquamarine}, {"azure", DiscordColor.Azure}, 
            {"darkgreen", DiscordColor.DarkGreen}, {"darkgray", DiscordColor.DarkGray},
            {"blurple", DiscordColor.Blurple }, {"brown", DiscordColor.Brown }, {"chartreuse", DiscordColor.Chartreuse },
            {"cornflowerblue", DiscordColor.CornflowerBlue }, {"cyan", DiscordColor.Cyan }, {"darkbutnotblack", DiscordColor.DarkButNotBlack },
            {"darkred", DiscordColor.DarkRed }, {"gray", DiscordColor.Gray }, {"grayple", DiscordColor.Grayple }, {"hotpink", DiscordColor.HotPink },
            {"indianred", DiscordColor.IndianRed }, {"lightgray", DiscordColor.LightGray }, {"lilac", DiscordColor.Lilac },
            {"midnightblue", DiscordColor.MidnightBlue }, {"default", DiscordColor.None }, {"notquiteblack", DiscordColor.NotQuiteBlack },
            {"phthaloblue", DiscordColor.PhthaloBlue }, {"phthalogreen", DiscordColor.PhthaloGreen },
            {"rose", DiscordColor.Rose }, {"sapgreen", DiscordColor.SapGreen }, {"springgreen", DiscordColor.SpringGreen },
            {"turquoise", DiscordColor.Turquoise }, {"verydarkgray", DiscordColor.VeryDarkGray }, {"violet", DiscordColor.Violet },
            {"white", DiscordColor.White }, {"yellow", DiscordColor.Yellow }
        };

        public static DiscordColor GetColor(string colorName, DiscordColor defaultColor)
        {
            if (EmbedColors.Colors.ContainsKey(colorName)) return Colors[colorName];
            else
                return defaultColor;
        }
    }
}
