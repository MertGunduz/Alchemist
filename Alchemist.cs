namespace Alchemist
{
    public class Alchemist
    {
        public Alchemist(string cAlchemistName, int cAlchemistAge, int cAlchemistHealth, int cAlchemistMana, int cAlchemistAttackDamage, int cAlchemistHeight, int cAlchemistWeight, int cAlchemistAgility, int cAlchemistStrength, int cAlchemistDexterity, int cAlchemistIntelligence, int cAlchemistWisdom, int cAlchemistCharisma, Helmet cAlchemistHelmet, Chestplate cAlchemistChestplate, Leggings cAlchemistLeggings, Boots cAlchemistBoots, Gloves cAlchemistGloves, Necklace cAlchemistNecklace, Ring cAlchemistRing, MeleeWeapon cAlchemistMeleeWeapon, RangedWeapon cAlchemistRangedWeapon, Book cAlchemistBook, AlchemistRace cAlchemistRace)
        {
            alchemistName = cAlchemistName;
            alchemistAge = cAlchemistAge;
            alchemistHealth = cAlchemistHealth;
            alchemistMana = cAlchemistMana;
            alchemistAttackDamage = cAlchemistAttackDamage;
            alchemistWeight = cAlchemistWeight;
            alchemistHeight = cAlchemistHeight;
            alchemistAgility = cAlchemistAgility;
            alchemistStrength = cAlchemistStrength;
            alchemistDexterity = cAlchemistDexterity;
            alchemistIntelligence = cAlchemistIntelligence;
            alchemistWisdom = cAlchemistWisdom;
            alchemistCharisma = cAlchemistCharisma;
            alchemistHelmet = cAlchemistHelmet;
            alchemistChestplate = cAlchemistChestplate;
            alchemistLeggings = cAlchemistLeggings;
            alchemistBoots = cAlchemistBoots;
            alchemistGloves = cAlchemistGloves;
            alchemistNecklace = cAlchemistNecklace;
            alchemistRing = cAlchemistRing;
            alchemistMeleeWeapon = cAlchemistMeleeWeapon;
            alchemistRangedWeapon = cAlchemistRangedWeapon;
            alchemistBook = cAlchemistBook;
            alchemistRace = cAlchemistRace;
        }

        public enum AlchemistRace
        {
            Human,
            Elf,
            Demon,
            Orc,
            Lizardman
        }

        // Alchemist Personality Data
        public string alchemistName;
        public int alchemistAge;
        public int alchemistHeight;
        public int alchemistWeight;

        // Alchemist Combat Data
        public int alchemistHealth;
        public int alchemistMana;
        public int alchemistAttackDamage;

        // Alchemist Attribute Data
        public int alchemistAgility;
        public int alchemistStrength;
        public int alchemistDexterity;
        public int alchemistIntelligence;
        public int alchemistWisdom;
        public int alchemistCharisma;

        // Alchemist Armor Data
        public Helmet alchemistHelmet;
        public Chestplate alchemistChestplate;
        public Leggings alchemistLeggings;
        public Boots alchemistBoots;
        public Gloves alchemistGloves;
        public Necklace alchemistNecklace;
        public Ring alchemistRing;

        // Alchemist Weapon Data
        public MeleeWeapon alchemistMeleeWeapon;
        public RangedWeapon alchemistRangedWeapon;
        public Book alchemistBook;

        // Alchemist Race Data
        public AlchemistRace alchemistRace;
    }
}