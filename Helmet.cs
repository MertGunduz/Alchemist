using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    public class Helmet 
    {
        Helmet (string cHelmetName, int cHelmetArmor)
        {
            helmetName = cHelmetName;
            helmetArmor = cHelmetArmor;
        }   

        public string helmetName;
        public int helmetArmor;
    }
}
