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
        // | Alchemist |
        static string mainAlchemistName;
        static int mainAlchemistAge;
        static int mainAlchemistWeight;
        static int mainAlchemistHeight;
        static int mainAlchemistAgility;
        static int mainAlchemistStrenght;
        static int mainAlchemistDexterity;
        static int mainAlchemistIntelligence;
        static int mainAlchemistWisdom;
        static int mainAlchemistCharisma;
        static Alchemist.AlchemistElement alchemistElement;
        static Alchemist.AlchemistRace alchemistRace;

        static void Main(string[] args)
        {
            // | Console Options |
            Console.Title = "Alchemist";

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

            Console.Write(" Answer -> ");
            menuChoice = Console.ReadLine();

            // Sets The "menuChoice" To Lower.
            menuChoice = menuChoice.ToLower();

            Console.WriteLine(" "); // |-| Line Break |-|

            // Menu Choice
            if (menuChoice == "start game" || menuChoice == "startgame" || menuChoice == "start")
            {
                // Clears Console & Makes The Game Menu
                Console.Clear();

                Console.WriteLine("");
            }
            else if (menuChoice == "create character" || menuChoice == "createcharacter" || menuChoice == "create")
            {
                CharacterCreation();
            }
            else if (menuChoice == "settings" || menuChoice == "sett" || menuChoice == "set")
            {
                // Settings Menu
            }

            Console.ReadLine();
        }
        private static void CharacterCreation()
        {
            // Character Creation Data
            int totalAttributePoints = 30;

            // Character Create UI
            Console.WriteLine(@"  ░                           ░ ", Color.FromArgb(88, 211, 143));
            Console.WriteLine(@" /|\-------------------------/|\", Color.FromArgb(72, 194, 127));
            Console.WriteLine(@" ||| Character Creation Menu |||", Color.FromArgb(58, 175, 111));
            Console.WriteLine(@" \|/-------------------------\|/", Color.FromArgb(46, 150, 92));
            Console.WriteLine(@"  ░                           ░ ", Color.FromArgb(34, 131, 77));

            Console.WriteLine(" "); // |-| Line Break |-|

            // Gets Alchemist Name  & Assigns It
            Console.Write(" Alchemist Name -> ", Color.FromArgb(64, 17, 231));
            mainAlchemistName = Console.ReadLine();

            Console.WriteLine(" "); // |-| Line Break |-|

            // Gets Alchemist Age & Assigns It
            Console.Write(" Alchemist Age -> ", Color.FromArgb(129, 149, 11));
            mainAlchemistAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            // Gets The Weight & Assigns It
            Console.Write(" Alchemist Weight -> ", Color.FromArgb(241, 186, 71));
            mainAlchemistWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            // Gets The Height & Assings It
            Console.Write(" Alchemist Height -> ", Color.FromArgb(92, 42, 62));
            mainAlchemistHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            // Shows Points
            Console.WriteLine(@"  ░                      ░  ", Color.FromArgb(143, 255, 194));
            Console.WriteLine(@" /|\--------------------/|\ ", Color.FromArgb(113, 228, 165));
            Console.WriteLine(@" ||| Total Points -> " + totalAttributePoints + " ||| ", Color.FromArgb(88, 211, 143));
            Console.WriteLine(@" \|/--------------------\|/ ", Color.FromArgb(72, 194, 127));
            Console.WriteLine(@"  ░                      ░  ", Color.FromArgb(58, 175, 111));

            Console.WriteLine(" "); // |-| Line Break |-|

            // Shows Attributes
            Console.WriteLine(@"  ░             ░ ", Color.FromArgb(143, 255, 194));
            Console.WriteLine(@" /|\-----------/|\", Color.FromArgb(113, 228, 165));
            Console.WriteLine(@" ||| Agi. -> " + mainAlchemistAgility + " |||", Color.FromArgb(88, 211, 143));
            Console.WriteLine(@" ||| Str. -> " + mainAlchemistStrenght + " |||", Color.FromArgb(72, 194, 127));
            Console.WriteLine(@" ||| Dex. -> " + mainAlchemistDexterity + " |||", Color.FromArgb(58, 175, 111));
            Console.WriteLine(@" ||| Int. -> " + mainAlchemistIntelligence + " |||", Color.FromArgb(46, 150, 92));
            Console.WriteLine(@" ||| Wis. -> " + mainAlchemistWisdom + " |||", Color.FromArgb(34, 131, 77));
            Console.WriteLine(@" ||| Chr. -> " + mainAlchemistCharisma + " |||", Color.FromArgb(24, 109, 62));
            Console.WriteLine(@" \|/-----------\|/", Color.FromArgb(16, 88, 48));
            Console.WriteLine(@"  ░             ░ ", Color.FromArgb(11, 61, 33));

            Console.WriteLine(" "); // |-| Line Break |-|

        // Gets The Agility Attribute & Assings It
        AlchemistAgilityAttribute:
            Console.Write(" Alchemist Agility -> ", Color.FromArgb(143, 255, 194));
            mainAlchemistAgility = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            if (mainAlchemistAgility <= 9)
            {
                totalAttributePoints = totalAttributePoints - mainAlchemistAgility;
            }
            else
            {
                Console.WriteLine(@"  ░                                                ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\----------------------------------------------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Agility Should Be Smaller Than Or Equal To 9 |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" \|/----------------------------------------------\|/", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@"  ░                                                ░ ", Color.FromArgb(58, 175, 111));

                Console.WriteLine(" "); // |-| Line Break |-|

                goto AlchemistAgilityAttribute;
            }

        // Gets The Strength Attribute & Assigns It
        AlchemistStrengthAttribute:
            Console.Write(" Alchemist Strength -> ", Color.FromArgb(113, 228, 165));
            mainAlchemistStrenght = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            if (mainAlchemistStrenght <= 9)
            {
                totalAttributePoints = totalAttributePoints - mainAlchemistStrenght;
            }
            else
            {
                Console.WriteLine(@"  ░                                                 ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\-----------------------------------------------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Strength Should Be Smaller Than Or Equal To 9 |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" \|/-----------------------------------------------\|/", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@"  ░                                                 ░ ", Color.FromArgb(58, 175, 111));

                Console.WriteLine(" "); // |-| Line Break |-|

                goto AlchemistStrengthAttribute;
            }

        // Gets The Dexterity Attribute & Assigns It
        AlchemistDexterityAttribute:
            Console.Write(" Alchemist Dexterity -> ", Color.FromArgb(88, 211, 143));
            mainAlchemistDexterity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            if (mainAlchemistDexterity <= 9)
            {
                totalAttributePoints = totalAttributePoints - mainAlchemistDexterity;
            }
            else
            {
                Console.WriteLine(@"  ░                                                  ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\------------------------------------------------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Dexterity Should Be Smaller Than Or Equal To 9 |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" \|/------------------------------------------------\|/", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@"  ░                                                  ░ ", Color.FromArgb(58, 175, 111));

                Console.WriteLine(" "); // |-| Line Break |-|

                goto AlchemistDexterityAttribute;
            }

        // Gets The Intelligence Attribute & Assigns It
        AlchemistIntelligenceAttribute:
            Console.Write(" Alchemist Intelligence -> ", Color.FromArgb(72, 194, 127));
            mainAlchemistIntelligence = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            if (mainAlchemistIntelligence <= 9)
            {
                totalAttributePoints = totalAttributePoints - mainAlchemistIntelligence;
            }
            else
            {
                Console.WriteLine(@"  ░                                                     ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\---------------------------------------------------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Intelligence Should Be Smaller Than Or Equal To 9 |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" \|/---------------------------------------------------\|/", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@"  ░                                                     ░ ", Color.FromArgb(58, 175, 111));

                Console.WriteLine(" "); // |-| Line Break |-|

                goto AlchemistIntelligenceAttribute;
            }

        // Gets The Wisdom Attribute & Assigns It
        AlchemistWisdomAttribute:
            Console.Write(" Alchemist Wisdom -> ", Color.FromArgb(58, 175, 111));
            mainAlchemistWisdom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            if (mainAlchemistWisdom <= 9)
            {
                totalAttributePoints = totalAttributePoints - mainAlchemistWisdom;
            }
            else
            {
                Console.WriteLine(@"  ░                                               ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\---------------------------------------------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Wisdom Should Be Smaller Than Or Equal To 9 |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" \|/---------------------------------------------\|/", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@"  ░                                               ░ ", Color.FromArgb(58, 175, 111));

                Console.WriteLine(" "); // |-| Line Break |-|

                goto AlchemistWisdomAttribute;
            }

        // Gets The Charisma Attribute & Assigns It
        AlchemistCharismaAttribute:
            Console.Write(" Alchemist Charisma -> ", Color.FromArgb(46, 150, 92));
            mainAlchemistCharisma = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "); // |-| Line Break |-|

            if (mainAlchemistCharisma <= 9)
            {
                totalAttributePoints = totalAttributePoints - mainAlchemistCharisma;
            }
            else
            {
                Console.WriteLine(@"  ░                                                 ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\-----------------------------------------------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Charisma Should Be Smaller Than Or Equal To 9 |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" \|/-----------------------------------------------\|/", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@"  ░                                                 ░ ", Color.FromArgb(58, 175, 111));

                Console.WriteLine(" "); // |-| Line Break |-|

                goto AlchemistCharismaAttribute;
            }

            // Shows Points
            Console.WriteLine(@"  ░                      ░  ", Color.FromArgb(143, 255, 194));
            Console.WriteLine(@" /|\--------------------/|\ ", Color.FromArgb(113, 228, 165));
            Console.WriteLine(@" ||| Total Points -> " + totalAttributePoints + " ||| ", Color.FromArgb(88, 211, 143));
            Console.WriteLine(@" \|/--------------------\|/ ", Color.FromArgb(72, 194, 127));
            Console.WriteLine(@"  ░                      ░  ", Color.FromArgb(58, 175, 111));

            Console.WriteLine(" "); // |-| Line Break |-|

            // Shows Attributes
            Console.WriteLine(@"  ░             ░ ", Color.FromArgb(143, 255, 194));
            Console.WriteLine(@" /|\-----------/|\", Color.FromArgb(113, 228, 165));
            Console.WriteLine(@" ||| Agi. -> " + mainAlchemistAgility + " |||", Color.FromArgb(88, 211, 143));
            Console.WriteLine(@" ||| Str. -> " + mainAlchemistStrenght + " |||", Color.FromArgb(72, 194, 127));
            Console.WriteLine(@" ||| Dex. -> " + mainAlchemistDexterity + " |||", Color.FromArgb(58, 175, 111));
            Console.WriteLine(@" ||| Int. -> " + mainAlchemistIntelligence + " |||", Color.FromArgb(46, 150, 92));
            Console.WriteLine(@" ||| Wis. -> " + mainAlchemistWisdom + " |||", Color.FromArgb(34, 131, 77));
            Console.WriteLine(@" ||| Chr. -> " + mainAlchemistCharisma + " |||", Color.FromArgb(24, 109, 62));
            Console.WriteLine(@" \|/-----------\|/", Color.FromArgb(16, 88, 48));
            Console.WriteLine(@"  ░             ░ ", Color.FromArgb(11, 61, 33));

            if (totalAttributePoints > 0)
            {
                // Show The Points That Didn't Spent
            }
        }
    }
}