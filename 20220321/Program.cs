using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220321
{
    class Program
    {
        //猜數字，0~100取亂數

        static void Main(string[] args)
        {
            Console.WriteLine("猜數字遊戲，答案為0~100隨機產生1個整數");
            

            try
            {
                int min = 0, max = 100;

                var rand = new Random();
                int Anser = rand.Next(101); //0~100取亂數，型態為整數
                Console.WriteLine(Anser);

                Console.WriteLine("請輸入數字:");
                int Guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Guess);

                if (Guess != Anser)
                {
                    if (Guess > Anser) //50 45 0~49
                    {
                        max = Guess - 1;
                        Console.WriteLine("再低!" + min + "~" + max);
                    }
                    else if (Guess < Anser)
                    {
                        min = Guess + 1;
                        Console.WriteLine("再高!" + min + "~" + max);
                    }
                }
                else
                {
                    Console.WriteLine("答對了!");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("輸入錯誤!");
            }
        }
    }
}
