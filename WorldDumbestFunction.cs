﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_Project_V1
{
    public class WorldDumbestFunction
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if(num == 0)
            {
                return "Pikachu";
            }
            else
            {
                return "Squirtle";
            }
        }
    }
}
