using System;
using System.Drawing;
using System.IO;
using Console = Colorful.Console;

namespace Alchemist
{
    enum Menu
    {
        CreateCharacter,
        PlayGame,
        Settings
    }
    class Program
    {
        static void Main(string[] args)
        {
            // | Console Options |
            Console.Title = "Alchemist";

            // | Alchemist |

            // Menu Variables
            string menuChoice;

            // | Console UI |
            Console.WriteLine(" ");
            Console.WriteLine("  ▄▄▄       ██▓     ▄████▄   ██░ ██ ▓█████  ███▄ ▄███▓ ██▓  ██████ ▄▄▄█████▓", Color.FromArgb(143, 255, 194));
            Console.WriteLine(" ▒████▄    ▓██▒    ▒██▀ ▀█  ▓██░ ██▒▓█   ▀ ▓██▒▀█▀ ██▒▓██▒▒██    ▒ ▓  ██▒ ▓▒", Color.FromArgb(113, 228, 165));
            Console.WriteLine(" ▒██  ▀█▄  ▒██░    ▒▓█    ▄ ▒██▀▀██░▒███   ▓██    ▓██░▒██▒░ ▓██▄   ▒ ▓██░ ▒░", Color.FromArgb(88, 211, 143));
            Console.WriteLine(" ░██▄▄▄▄██ ▒██░    ▒▓▓▄ ▄██▒░▓█ ░██ ▒▓█  ▄ ▒██    ▒██ ░██░  ▒   ██▒░ ▓██▓ ░ ", Color.FromArgb(72, 194, 127));
            Console.WriteLine("  ▓█   ▓██▒░██████▒▒ ▓███▀ ░░▓█▒░██▓░▒████▒▒██▒   ░██▒░██░▒██████▒▒  ▒██▒ ░ ", Color.FromArgb(58, 175, 111));
            Console.WriteLine("  ▒▒   ▓▒█░░ ▒░▓  ░░ ░▒ ▒  ░ ▒ ░░▒░▒░░ ▒░ ░░ ▒░   ░  ░░▓  ▒ ▒▓▒ ▒ ░  ▒ ░░   ", Color.FromArgb(46, 150, 92));
            Console.WriteLine("   ▒   ▒▒ ░░ ░ ▒  ░  ░  ▒    ▒ ░▒░ ░ ░ ░  ░░  ░      ░ ▒ ░░ ░▒  ░ ░    ░    ", Color.FromArgb(34, 131, 77));
            Console.WriteLine("   ░   ▒     ░ ░   ░         ░  ░░ ░   ░   ░      ░    ▒ ░░  ░  ░    ░      ", Color.FromArgb(24, 109, 62));
            Console.WriteLine("       ░  ░    ░  ░░ ░       ░  ░  ░   ░  ░       ░    ░        ░           ", Color.FromArgb(16, 88, 48));
            Console.WriteLine("                   ░                                                        ", Color.FromArgb(11, 61, 33));

            Console.WriteLine(" "); // |-| Line Break |-|

            Console.WriteLine(@"  ░                    ░ ", Color.FromArgb(88, 211, 143));
            Console.WriteLine(@" /|\------------------/|\", Color.FromArgb(72, 194, 127));
            Console.WriteLine(@" |||    Start Game    |||", Color.FromArgb(58, 175, 111));
            Console.WriteLine(@" ||| Create Character |||", Color.FromArgb(46, 150, 92));
            Console.WriteLine(@" |||     Settings     |||", Color.FromArgb(34, 131, 77));
            Console.WriteLine(@" \|/------------------\|/", Color.FromArgb(24, 109, 62));
            Console.WriteLine(@"  ░                    ░ ", Color.FromArgb(16, 88, 48));

            Console.WriteLine(" "); // |-| Line Break |-|

            Console.Write("Answer -> ");
            menuChoice = Console.ReadLine();

            // Sets The "menuChoice" To Lower.
            menuChoice = menuChoice.ToLower();

            // Menu Choice
            if (menuChoice == "start game" || menuChoice == "startgame" || menuChoice == "start")
            {
                // Clears Console & Makes The Game Menu
                Console.Clear();

                Console.WriteLine("");
            }
            else if (menuChoice == "create character" || menuChoice == "createcharacter" || menuChoice == "create")
            {
                // Character Creation Txt StreamWriting
            }
            else if (menuChoice == "settings" || menuChoice == "sett" || menuChoice == "set")
            {
                // Settings Menu
            }

            Console.ReadLine();
        }
    }
}