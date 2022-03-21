using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220321
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Toyota_Altis_2022 = new Car("Toyota", "Corolla Altis", "4門5人座房車", 2022, "白色", 180);
            Toyota_Altis_2022.Print_Car();
            Toyota_Altis_2022.Change_Color("黑色");
            Toyota_Altis_2022.Print_Car();
        }
    }
    class Car
    {
        private string brand; //品牌
        private string name; //車名
        private string type; //車型  
        private int year; //出產年份
        private string color; //車色
        private int max_speed; //最高車速

        //Car 建構式
        public Car(string brand, string name, string type, int year, string color, int max_speed)
        {
            this.brand = brand;
            this.name = name;
            this.type = type;
            this.year = year;
            this.color = color;
            this.max_speed = max_speed;
        }

        //印出車子資料
        public void Print_Car()
        {
            Console.WriteLine("品牌：" + brand + "，" + "車名：" + name);
            Console.WriteLine("車型：" + type + "，" + "出產年份：" + year + "，" + "車色：" + color + "，" + "最高車速：" + max_speed);
            Console.WriteLine();
        }

        //改車色
        public void Change_Color(string color)
        {
            this.color = color;
            Console.WriteLine("車色改變，已改成" + color );
        }
    }
}
