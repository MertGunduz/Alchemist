using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    public class MeleeWeapon
    {
        public MeleeWeapon(string cMeleeWeaponName, int cMeleeWeaponAttackDamage)
        {
            meleeWeaponName = cMeleeWeaponName;
            meleeWeaponAttackDamage = cMeleeWeaponAttackDamage;
        }

        public string meleeWeaponName;
        public int meleeWeaponAttackDamage;
    }
}
