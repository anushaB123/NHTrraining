﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnushaLibrary
{
    public class Mathematics
    {
        int input;
        public void ReadData()
        {
            Console.WriteLine("Enter any number:");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public int GetFactorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
                fact = fact * i;
            return fact;
        }
    }
        

}

