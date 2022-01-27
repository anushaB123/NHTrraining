using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("*************************************************");
            Console.WriteLine("Hi {0}, Welcome to quiz by Anusha",name);
            Console.WriteLine("**************************************************");


            Console.WriteLine("Q1: What's your favorite food for chinese?");
            Console.WriteLine("1.FriedRice 2.lemonRice 3.Biryani 4.PannerBiryani");
            Console.WriteLine("Enter u r choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;


            Console.WriteLine("Q2: What's your favorite fast food?");
            Console.WriteLine("1.FriedRice 2.lemonRice 3.Manchuria 4.PannerBiryani");
            Console.WriteLine("Enter u r choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            Console.WriteLine("Q3: What's your favorite Drink?");
            Console.WriteLine("1.FriedRice 2.ThumsUp 3.Biryani 4.Cocktail");
            Console.WriteLine("Enter u r choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;

            Console.WriteLine("Q4: What's your favorite snack?");
            Console.WriteLine("1.Cakes 2.lemonRice 3.Noodles 4.PannerBiryani");
            Console.WriteLine("Enter u r choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;


            Console.WriteLine("Q5: What's your favorite kind of ethnic food?");
            Console.WriteLine("1.Cakes 2.lemonRice 3.Noodles 4.PalakPaneer");
            Console.WriteLine("Enter u r choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            if(score>=60)
            {
                Console.WriteLine("Congratulations {0}, you got {1}% in this quiz",name,score);
            }
            Console.ReadLine();

                
        }
    }
}
