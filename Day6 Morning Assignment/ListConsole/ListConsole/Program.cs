﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();
            int sum = 0;
            data.Add(5);
            data.Add(10);
            data.Add(20);
            data.Add(50);
            data.Add(70);
            foreach(var d in data)
            {
                sum = sum + (int)d;
            }
            Console.WriteLine("sum="+sum);
            Console.ReadLine();
        }
    }
}
