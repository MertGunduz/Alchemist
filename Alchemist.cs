using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    class Alchemist
    {
        public Alchemist(string cAlchemistName, int cAlchemistAge, int cAlchemistHealth, int cAlchemistMana, int cAlchemistHeight, int cAlchemistWeight, int cAlchemistAgility, int cAlchemistStrength, int cAlchemistDexterity, int cAlchemistIntelligence, int cAlchemistWisdom, int cAlchemistCharisma, string cAlchemistHelmet, string cAlchemistChestplate, string cAlchemistLeggings, string cAlchemistBoots, string cAlchemistGloves, string cAlchemistNecklace, string cAlchemistRing, string cAlchemistMeleeWeapon, string cAlchemistRangedWeapon, string cAlchemistBook, AlchemistElement alchemistElement, AlchemistRace alchemistRace)
        {

        }

        public enum AlchemistElement
        {
            Earth,
            Fire,
            Water,
            Air,
            Darkness,
            Light,
            Nature
        }

        public enum AlchemistRace
        {
            Human,
            Elf,
            Demon,
            Undead,
            Orc,
            Lizardman,
            Centaur,
            Elemental
        }

        // Alchemist Personality Data
        public string alchemistName;
        public int alchemistAge;
        public int alchemistHealth;
        public int alchemistMana;
        public int alchemistHeight;
        public int alchemistWeight;

        // Alchemist Attribute Data
        public int alchemistAgility;
        public int alchemistStrength;
        public int alchemistDexterity;
        public int alchemistIntelligence;
        public int alchemistWisdom;
        public int alchemistCharisma;

        // Alchemist Armor Data
        public string alchemistHelmet;
        public string alchemistChestplate;
        public string alchemistLeggings;
        public string alchemistBoots;
        public string alchemistGloves;
        public string alchemistNecklace;
        public string alchemistRing;

        // Alchemist Weapon Data
        public string alchemistMeleeWeapon;
        public string alchemistRangedWeapon;
        public string alchemistBook;
    }
}
