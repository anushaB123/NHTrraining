using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project4
{
    class Palindrome
    {
        int input;
       
        public int ReadInput()
        {
            Console.Write("\nEnter Any Number To Check, If Palindrome Or Not  :   ");
            input = int.Parse(Console.ReadLine());
            return input;
        }
       
        public bool IsPalindrome()
        {
            int rev = 0, rem, m;
            m = input;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (input == rev)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome palindrome = new Palindrome();
            int input = palindrome.ReadInput();    
            bool isPalindrome = palindrome.IsPalindrome(); 

            
            if (isPalindrome == true)
                Console.WriteLine("\nYes, {0} Is a Palindrome Number", input);
            else
                Console.WriteLine("\nNo, {0} is Not a Palindrome Number", input);

            Console.ReadLine();
        }
    }
}
