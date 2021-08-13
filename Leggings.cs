using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    public class Leggings
    {
        public Leggings(string cLeggingsName, int cLeggingsArmor)
        {
            leggingsName = cLeggingsName;
            leggingsArmor = cLeggingsArmor;
        }

        public string leggingsName;
        public int leggingsArmor;
    }
}
