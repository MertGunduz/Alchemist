using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    public class Chestplate
    {
        public Chestplate(string cChestplateName, int cChestplateArmor)
        {
            chestplateName = cChestplateName;
            chestplateArmor = cChestplateArmor;
        }

        public string chestplateName;
        public int chestplateArmor;
    }
}
