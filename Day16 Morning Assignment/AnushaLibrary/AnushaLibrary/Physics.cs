﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnushaLibrary
{
    public class Physics
    {
        
        public static int FinalVelocity(int u, int a, int t)
        {
            int finalVelocity = u + a * t;
            Console.WriteLine(finalVelocity);
            return finalVelocity;
        }
    }

}
