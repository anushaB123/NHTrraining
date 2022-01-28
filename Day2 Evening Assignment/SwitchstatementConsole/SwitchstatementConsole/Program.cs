using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchstatementConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your character");
            char vowel = char.Parse(Console.ReadLine());

            switch (vowel)
            {
                case ('a'):
                    Console.WriteLine("you entered a vowel");
                    break;
                case ('e'):
                    Console.WriteLine("you entered a vowel");
                    break;
                case ('i'):
                    Console.WriteLine("you entered a vowel");
                    break;
                case ('o'):
                    Console.WriteLine("you entered a vowel");
                    break;
                case ('u'):
                    Console.WriteLine("you entered a vowel");
                    break;
                default:
                    Console.WriteLine("you entered not a vowel");
                    break;

            }
            Console.ReadLine();
        }
    }
}
