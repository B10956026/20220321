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
            Console.WriteLine("猜數字遊戲，答案為 0~100 隨機產生1個整數");
            print_equal();

            int count = 0; //猜的次數
            int min = 0, max = 100; //範圍

            var rand = new Random();
            int Anser = rand.Next(101); //0~100取亂數，型態為整數
            //Console.WriteLine(Anser);

            do
            {
                try
                {   
                    Console.Write("\n請猜 {0} ~ {1} 的值：", min, max);
                    int Guess = Convert.ToInt32(Console.ReadLine());

                    if (Guess >= min && Guess <= max)
                    {
                        count += 1;
                        if (Guess == Anser)
                        {
                            Console.WriteLine("\n恭喜您，答對了! 答案是{0}，您一共猜了{1}次", Anser, count);
                            Console.Write("\n是否繼續?（Y：是 / N：否）");
                            string symbol;
                            bool flag = false;
                            symbol = Convert.ToString(Console.ReadLine());
                            while (flag == false)
                            {
                                Anser = rand.Next(101);
                            
                                switch (symbol)
                                {
                                    case "Y":
                                        Console.Clear();

                                        count = 0;
                                        min = 0; max = 100;

                                        Console.WriteLine("猜數字遊戲，答案為 0~100 隨機產生1個整數");
                                        print_equal();
                                        //Console.WriteLine(Anser);

                                        flag = true;                            
                                        break;
                                    case "N":
                                        Console.WriteLine("\n退出游戲！");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                        break;
                                    default:
                                        Console.WriteLine("\n輸入錯誤!");
                                        Console.Write("\n是否繼續?（Y：是 / N：否）");
                                        symbol = Convert.ToString(Console.ReadLine());
                                        break;
                                }
                            }
                        }
                        else if (Guess > Anser)
                        {
                            max = Guess - 1;
                            Console.Write("\n太大了，再小一點!");
                        }
                        else if (Guess < Anser)
                        {
                            min = Guess + 1;
                            Console.Write("\n太小了，再大一點!");
                        }
                        if(count > 0)
                        {
                            Console.WriteLine("\n你猜了{0}次!", count);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n超過範圍，請輸入提示範圍內的數字!");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\n輸入錯誤!");
                }
            } while (true);
        }

        //印出40個等號
        static void print_equal()
        {
            for (int i = 0 ; i < 40 ; i++)
            {
                Console.Write("=");
            }
        }
    }
}
