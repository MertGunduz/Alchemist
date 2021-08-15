using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    public class Enemy
    {
        public Enemy(int cEnemyID, string cEnemyName, int cEnemyHealth, int cEnemyMana, int cEnemyAttackDamage, Rarity cEnemyRarity)
        {
            enemyID = cEnemyID;
            enemyName = cEnemyName;
            enemyHealth = cEnemyHealth;
            enemyMana = cEnemyMana;
            enemyAttackDamage = cEnemyAttackDamage;
            enemyRarity = cEnemyRarity;
        }

        // Enemy Identification
        public int enemyID;

        // Enemy Attributes
        public string enemyName;
        public int enemyHealth;
        public int enemyMana;
        public int enemyAttackDamage;

        // Enum Data
        public enum Rarity
        {
            Common,
            Uncommon,
            Rare,
            Epic,
            Legendary,
            Godly
        }

        public Rarity enemyRarity;
    }
}
