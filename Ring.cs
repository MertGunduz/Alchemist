﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemist
{
    public class Ring
    {
        public Ring (string cRingName, int cRingArmor)
        {
            ringName = cRingName;
            ringArmor = cRingArmor;
        }

        public string ringName;
        public int ringArmor;
    }
}
