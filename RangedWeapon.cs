using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    public class RangedWeapon
    {
        public RangedWeapon(string cRangedWeaponName, int cRangedWeaponAttackDamage)
        {
            rangedWeaponName = cRangedWeaponName;
            rangedWeaponAttackDamage = cRangedWeaponAttackDamage;
        }

        public string rangedWeaponName;
        public int rangedWeaponAttackDamage;
    }
}
