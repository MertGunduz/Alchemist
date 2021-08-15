using System;
using System.Drawing;
using System.IO;
using Console = Colorful.Console;

namespace Alchemist
{
    class Program
    {
        // | Alchemist String & Int Data |
        static string mainAlchemistName;
        static int mainAlchemistAge;
        static int mainAlchemistWeight;
        static int mainAlchemistHeight;
        static int mainAlchemistAgility;
        static int mainAlchemistStrength;
        static int mainAlchemistDexterity;
        static int mainAlchemistIntelligence;
        static int mainAlchemistWisdom;
        static int mainAlchemistCharisma;
        static int mainAlchemistHealth;
        static int mainAlchemistMana;
        static int mainAlchemistAttackDamage;
        static int mainStandardAlchemistHealth = 150;
        static int mainStandardAlchemistMana = 100;

        // | Alchemist Enum Data |
        static string mainAlchemistRace;
        static Alchemist.AlchemistRace alchemistRace;

        // |\/| Alchemist Armors |\/|
        // Helmet
        static Helmet hoodHelmet = new Helmet("Hood", 1);
        static Helmet chainHelmet = new Helmet("Chain Helmet", 5);

        // Chestplace
        static Chestplate shirtChestplate = new Chestplate("Shirt", 2);
        static Chestplate chainmailChestplate = new Chestplate("Chainmail", 9);

        // Leggings
        static Leggings trousersLeggings = new Leggings("Trousers", 1);
        static Leggings chainLeggings = new Leggings("Chain Leggings", 7);

        // Boots
        static Boots leatherBoots = new Boots("Leather Boots", 2);
        static Boots chainBoots = new Boots("Chain Boots", 6);

        // Gloves
        static Gloves leatherGloves = new Gloves("Leather Gloves", 2);
        static Gloves chainGloves = new Gloves("Chain Gloves", 5);

        // Necklace
        static Necklace noneNecklace = new Necklace("None", 0);
        static Necklace goldNecklace = new Necklace("Golden Necklace", 1);

        // Ring
        static Ring noneRing = new Ring("None", 0);
        static Ring goldRing = new Ring("Golden Ring", 1);

        // |\/| Alchemist Weapons |\/|
        // Melee Weapon
        static MeleeWeapon ironDaggerMeleeWeapon = new MeleeWeapon("Iron Dagger", 6);
        static MeleeWeapon ironSwordMeleeWeapon = new MeleeWeapon("Iron Sword", 11);

        // Ranged Weapon
        static RangedWeapon throwingKnifesRangedWeapon = new RangedWeapon("Throwing Knifes", 5);
        static RangedWeapon javelinRangedWeapon = new RangedWeapon("Javelin", 9);

        // Book
        static Book noviceAlchemyBook = new Book("Novice Alchemy Book", 5);

        // |\/| Enemy |\/|
        // Skeletons
        Enemy skeletonWarriorEnemy = new Enemy(1, "Skeleton Warrior", 40, 20, 10, Enemy.Rarity.Common);
        Enemy skeletonWizardEnemy = new Enemy(2, "Skeleton Wizard", 30, 120, 20, Enemy.Rarity.Common);

        // Undeads
        Enemy undeadShieldmanEnemy = new Enemy(3, "Undead Shieldman", 120, 10, 10, Enemy.Rarity.Uncommon);
        Enemy undeadBerserkerEnemy = new Enemy(4, "Undead Berserker", 120, 20, 30, Enemy.Rarity.Uncommon);
        Enemy undeadNecromancerEnemy = new Enemy(5, "Undead Necromancer", 90, 200, 40, Enemy.Rarity.Rare);
  

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
            try
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

            // Gets Alchemist Race & Assigns It
            AlchemistRace:
                Console.WriteLine(@"  ░             ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\-----------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" |||   Human   |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" |||    Elf    |||", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@" |||   Demon   |||", Color.FromArgb(58, 175, 111));
                Console.WriteLine(@" |||    Orc    |||", Color.FromArgb(46, 150, 92));
                Console.WriteLine(@" ||| Lizardman |||", Color.FromArgb(34, 131, 77));
                Console.WriteLine(@" \|/-----------\|/", Color.FromArgb(24, 109, 62));
                Console.WriteLine(@"  ░             ░ ", Color.FromArgb(16, 88, 48));

                Console.WriteLine(" "); // |-| Line Break |-|

                // Gets Alchemist Race & Assigns It
                Console.Write(" Alchemist Race -> ", Color.FromArgb(113, 228, 165));
                mainAlchemistRace = Console.ReadLine();

                // Sets The MainAlchemistRace To Lower
                mainAlchemistRace = mainAlchemistRace.ToLower();

                Console.WriteLine(" "); // |-| Line Break |-|

                if (mainAlchemistRace == "human")
                {
                    alchemistRace = Alchemist.AlchemistRace.Human;
                }
                else if (mainAlchemistRace == "elf")
                {
                    alchemistRace = Alchemist.AlchemistRace.Elf;
                }
                else if (mainAlchemistRace == "demon")
                {
                    alchemistRace = Alchemist.AlchemistRace.Demon;
                }
                else if (mainAlchemistRace == "orc")
                {
                    alchemistRace = Alchemist.AlchemistRace.Orc;
                }
                else if (mainAlchemistRace == "lizardman")
                {
                    alchemistRace = Alchemist.AlchemistRace.Lizardman;
                }
                else
                {
                    Console.WriteLine(@"  ░                              ░ ", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" /|\----------------------------/|\", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Please Select A Valid Race |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/----------------------------\|/", Color.FromArgb(72, 194, 127));
                    Console.WriteLine(@"  ░                              ░ ", Color.FromArgb(58, 175, 111));

                    Console.WriteLine(" "); // |-| Line Break |-|
                    goto AlchemistRace;
                }

                // Gets Alchemist Name & Assigns It
                Console.Write(" Alchemist Name -> ", Color.FromArgb(88, 211, 143));
                mainAlchemistName = Console.ReadLine();

                Console.WriteLine(" "); // |-| Line Break |-|

                // Gets Alchemist Age & Assigns It
                Console.Write(" Alchemist Age -> ", Color.FromArgb(72, 194, 127));
                mainAlchemistAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" "); // |-| Line Break |-|

                // Gets The Height & Assings It
                Console.Write(" Alchemist Height -> ", Color.FromArgb(46, 150, 92));
                mainAlchemistHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" "); // |-| Line Break |-|

                // Gets The Weight & Assigns It
                Console.Write(" Alchemist Weight -> ", Color.FromArgb(58, 175, 111));
                mainAlchemistWeight = Convert.ToInt32(Console.ReadLine());

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
                Console.WriteLine(@" ||| Str. -> " + mainAlchemistStrength + " |||", Color.FromArgb(72, 194, 127));
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

                if (mainAlchemistAgility > totalAttributePoints)
                {
                    Console.WriteLine(" "); // |-| Line Break |-|

                    Console.WriteLine(@" /|\------------------------------/|\", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" ||| You Don't Have Enough Points |||", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Remained Attribute Points: " + totalAttributePoints + " |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/------------------------------\|/", Color.FromArgb(72, 194, 127));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    goto AlchemistAgilityAttribute;
                }

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
                mainAlchemistStrength = Convert.ToInt32(Console.ReadLine());

                if (mainAlchemistStrength > totalAttributePoints)
                {
                    Console.WriteLine(" "); // |-| Line Break |-|

                    Console.WriteLine(@" /|\------------------------------/|\", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" ||| You Don't Have Enough Points |||", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Remained Attribute Points: " + totalAttributePoints + " |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/------------------------------\|/", Color.FromArgb(72, 194, 127));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    goto AlchemistStrengthAttribute;
                }

                Console.WriteLine(" "); // |-| Line Break |-|

                if (mainAlchemistStrength <= 9)
                {
                    totalAttributePoints = totalAttributePoints - mainAlchemistStrength;
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

                if (mainAlchemistDexterity > totalAttributePoints)
                {
                    Console.WriteLine(" "); // |-| Line Break |-|

                    Console.WriteLine(@" /|\------------------------------/|\", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" ||| You Don't Have Enough Points |||", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Remained Attribute Points: " + totalAttributePoints + " |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/------------------------------\|/", Color.FromArgb(72, 194, 127));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    goto AlchemistDexterityAttribute;
                }

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

                if (mainAlchemistIntelligence > totalAttributePoints)
                {
                    Console.WriteLine(" "); // |-| Line Break |-|

                    Console.WriteLine(@" /|\------------------------------/|\", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" ||| You Don't Have Enough Points |||", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Remained Attribute Points: " + totalAttributePoints + " |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/------------------------------\|/", Color.FromArgb(72, 194, 127));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    goto AlchemistIntelligenceAttribute;
                }

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

                if (mainAlchemistWisdom > totalAttributePoints)
                {
                    Console.WriteLine(" "); // |-| Line Break |-|

                    Console.WriteLine(@" /|\------------------------------/|\", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" ||| You Don't Have Enough Points |||", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Remained Attribute Points: " + totalAttributePoints + " |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/------------------------------\|/", Color.FromArgb(72, 194, 127));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    goto AlchemistWisdomAttribute;
                }

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

                if (mainAlchemistCharisma > totalAttributePoints)
                {
                    Console.WriteLine(" "); // |-| Line Break |-|

                    Console.WriteLine(@" /|\------------------------------/|\", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" ||| You Don't Have Enough Points |||", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Remained Attribute Points: " + totalAttributePoints + " |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/------------------------------\|/", Color.FromArgb(72, 194, 127));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    goto AlchemistCharismaAttribute;
                }

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

                // Shows Attributes
                Console.WriteLine(@"  ░             ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\-----------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Agi. -> " + mainAlchemistAgility + " |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" ||| Str. -> " + mainAlchemistStrength + " |||", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@" ||| Dex. -> " + mainAlchemistDexterity + " |||", Color.FromArgb(58, 175, 111));
                Console.WriteLine(@" ||| Int. -> " + mainAlchemistIntelligence + " |||", Color.FromArgb(46, 150, 92));
                Console.WriteLine(@" ||| Wis. -> " + mainAlchemistWisdom + " |||", Color.FromArgb(34, 131, 77));
                Console.WriteLine(@" ||| Chr. -> " + mainAlchemistCharisma + " |||", Color.FromArgb(24, 109, 62));
                Console.WriteLine(@" \|/-----------\|/", Color.FromArgb(16, 88, 48));
                Console.WriteLine(@"  ░             ░ ", Color.FromArgb(11, 61, 33));

                Console.WriteLine(" "); // |-| Line Break |-|

                if (totalAttributePoints > 0)
                {
                    // Shows Points
                    Console.WriteLine(@"  ░                      ░  ", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" /|\--------------------/|\ ", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Total Points -> " + totalAttributePoints + " ||| ", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/--------------------\|/ ", Color.FromArgb(72, 194, 127));
                    Console.WriteLine(@"  ░                      ░  ", Color.FromArgb(58, 175, 111));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    Console.WriteLine(@"  ░                     ░ ", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" /|\-------------------/|\", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Spend Your Points |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/-------------------\|/", Color.FromArgb(72, 194, 127));
                    Console.WriteLine(@"  ░                     ░ ", Color.FromArgb(58, 175, 111));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    Console.WriteLine(@"  ░                                      ░ ", Color.FromArgb(143, 255, 194));
                    Console.WriteLine(@" /|\------------------------------------/|\", Color.FromArgb(113, 228, 165));
                    Console.WriteLine(@" ||| Remained Points Has Randomly Given |||", Color.FromArgb(88, 211, 143));
                    Console.WriteLine(@" \|/------------------------------------\|/", Color.FromArgb(72, 194, 127));
                    Console.WriteLine(@"  ░                                      ░ ", Color.FromArgb(58, 175, 111));

                    Console.WriteLine(" "); // |-| Line Break |-|

                    // Sorting & Giving Remained Points
                    while (totalAttributePoints != 0)
                    {
                        if (mainAlchemistAgility <= mainAlchemistStrength && mainAlchemistAgility <= mainAlchemistDexterity && mainAlchemistAgility <= mainAlchemistIntelligence && mainAlchemistAgility <= mainAlchemistWisdom && mainAlchemistAgility <= mainAlchemistCharisma)
                        {
                            mainAlchemistAgility++;
                            totalAttributePoints--;
                        }
                        else if (mainAlchemistStrength <= mainAlchemistAgility && mainAlchemistStrength <= mainAlchemistDexterity && mainAlchemistStrength <= mainAlchemistIntelligence && mainAlchemistStrength <= mainAlchemistWisdom && mainAlchemistStrength <= mainAlchemistCharisma)
                        {
                            mainAlchemistStrength++;
                            totalAttributePoints--;
                        }
                        else if (mainAlchemistDexterity <= mainAlchemistAgility && mainAlchemistDexterity <= mainAlchemistStrength && mainAlchemistDexterity <= mainAlchemistIntelligence && mainAlchemistDexterity <= mainAlchemistWisdom && mainAlchemistDexterity <= mainAlchemistCharisma)
                        {
                            mainAlchemistDexterity++;
                            totalAttributePoints--;
                        }
                        else if (mainAlchemistIntelligence <= mainAlchemistAgility && mainAlchemistIntelligence <= mainAlchemistStrength && mainAlchemistIntelligence <= mainAlchemistDexterity && mainAlchemistIntelligence <= mainAlchemistWisdom && mainAlchemistIntelligence <= mainAlchemistCharisma)
                        {
                            mainAlchemistIntelligence++;
                            totalAttributePoints--;
                        }
                        else if (mainAlchemistWisdom <= mainAlchemistAgility && mainAlchemistWisdom <= mainAlchemistStrength && mainAlchemistWisdom <= mainAlchemistDexterity && mainAlchemistWisdom <= mainAlchemistIntelligence && mainAlchemistWisdom <= mainAlchemistCharisma)
                        {
                            mainAlchemistWisdom++;
                            totalAttributePoints--;
                        }
                        else if (mainAlchemistCharisma <= mainAlchemistAgility && mainAlchemistCharisma <= mainAlchemistStrength && mainAlchemistCharisma <= mainAlchemistDexterity && mainAlchemistCharisma <= mainAlchemistIntelligence && mainAlchemistCharisma <= mainAlchemistWisdom)
                        {
                            mainAlchemistCharisma++;
                            totalAttributePoints--;
                        }
                    }
                }

                // Shows Attributes
                Console.WriteLine(@"  ░             ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\-----------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Agi. -> " + mainAlchemistAgility + " |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" ||| Str. -> " + mainAlchemistStrength + " |||", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@" ||| Dex. -> " + mainAlchemistDexterity + " |||", Color.FromArgb(58, 175, 111));
                Console.WriteLine(@" ||| Int. -> " + mainAlchemistIntelligence + " |||", Color.FromArgb(46, 150, 92));
                Console.WriteLine(@" ||| Wis. -> " + mainAlchemistWisdom + " |||", Color.FromArgb(34, 131, 77));
                Console.WriteLine(@" ||| Chr. -> " + mainAlchemistCharisma + " |||", Color.FromArgb(24, 109, 62));
                Console.WriteLine(@" \|/-----------\|/", Color.FromArgb(16, 88, 48));
                Console.WriteLine(@"  ░             ░ ", Color.FromArgb(11, 61, 33));

                Console.WriteLine(" "); // |-| Line Break |-|

                // Sets The Alchemist Health 
                mainAlchemistHealth = (mainAlchemistAgility * 3) + (mainAlchemistStrength * 6) + (mainAlchemistDexterity * 2) + mainStandardAlchemistHealth;
                mainAlchemistMana = (mainAlchemistIntelligence * 4) + (mainAlchemistWisdom * 7) + mainStandardAlchemistMana;
                mainAlchemistAttackDamage = (mainAlchemistAgility * 2) + (mainAlchemistStrength * 4) + (mainAlchemistDexterity * 3) + (mainAlchemistCharisma * 2);

                Console.WriteLine(@"  ░                     ░ ", Color.FromArgb(143, 255, 194));
                Console.WriteLine(@" /|\-------------------/|\", Color.FromArgb(113, 228, 165));
                Console.WriteLine(@" ||| Alchemist Created |||", Color.FromArgb(88, 211, 143));
                Console.WriteLine(@" \|/-------------------\|/", Color.FromArgb(72, 194, 127));
                Console.WriteLine(@"  ░                     ░ ", Color.FromArgb(58, 175, 111));

                Console.WriteLine(" "); // |-| Line Break |-|

                // Alchemist Constructor Creation
                Alchemist alchemist = new Alchemist(mainAlchemistName, mainAlchemistAge, mainAlchemistHealth, mainAlchemistMana, mainAlchemistAttackDamage, mainAlchemistHeight, mainAlchemistWeight, mainAlchemistAgility, mainAlchemistStrength, mainAlchemistDexterity, mainAlchemistIntelligence, mainAlchemistWisdom, mainAlchemistCharisma, hoodHelmet, shirtChestplate, trousersLeggings, leatherBoots, leatherGloves, noneNecklace, noneRing, ironDaggerMeleeWeapon, throwingKnifesRangedWeapon, noviceAlchemyBook, alchemistRace);

                // Alchemist Data String
                string alchemistData = $"Alchemist Name: {alchemist.alchemistName}\nAlchemist Age: {alchemist.alchemistAge}\nAlchemist Health: {alchemist.alchemistHealth}\nAlchemist Mana: {alchemist.alchemistMana}\nAlchemist Attack Damage: {alchemist.alchemistAttackDamage}\nAlchemist Height: {alchemist.alchemistHeight}\nAlchemist Weight: {alchemist.alchemistWeight}\nAlchemist Agility: {alchemist.alchemistAgility}\nAlchemist Strength: {alchemist.alchemistStrength}\nAlchemist Dexterity: {alchemist.alchemistDexterity}\nAlchemist Intelligence: {alchemist.alchemistIntelligence}\nAlchemist Wisdom: {alchemist.alchemistWisdom}\nAlchemist Charisma: {alchemist.alchemistCharisma}\nAlchemist Helmet: {alchemist.alchemistHelmet.helmetName}\nAlchemist Chestplate: {alchemist.alchemistChestplate.chestplateName}\nAlchemist Leggings: {alchemist.alchemistLeggings.leggingsName}\nAlchemist Boots: {alchemist.alchemistBoots.bootsName}\nAlchemist Gloves: {alchemist.alchemistGloves.glovesName}\nAlchemist Necklace: {alchemist.alchemistNecklace.necklaceName}\nAlchemist Ring: {alchemist.alchemistRing.ringName}\nAlchemist Melee Weapon: {alchemist.alchemistMeleeWeapon.meleeWeaponName}\nAlchemist Ranged Weapon: {alchemist.alchemistRangedWeapon.rangedWeaponName}\nAlchemist Book: {alchemist.alchemistBook.bookName}\nAlchemist Race: {alchemist.alchemistRace}";

                // Creates A Directory (Alchemist)
                string dirPath = @"C:\Alchemist";
                Directory.CreateDirectory(dirPath);

                // Defines The Text Path For Text File
                string textFilePath = @"C:\Alchemist\" + mainAlchemistName + "_Data.txt";

                // Writes Alchemist Data To Text File
                using (StreamWriter streamWriter = new StreamWriter(textFilePath))
                {
                    streamWriter.Write(alchemistData);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" "); // |-| Line Break |-|

                // Shows The Exception Message
                Console.WriteLine(exception.Message, Color.FromArgb(143, 255, 194));
            }
        }
    }
}