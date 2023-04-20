using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Storage
    {
        public int scetchik1, scetchik2;

        public void writeInConsoleInfo(int scetchik1,int scetchik2)
        {
            Console.WriteLine("Первое число {0}\nВторое число {1}", scetchik1,scetchik2);
        }


    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Storage Schetov = new Storage();
            Schetov.scetchik1 = 0;
            Schetov.scetchik2 = 0;
            bool b = true;
            do
            {
                Console.WriteLine("Введите 1 для изменения первого числа, 2 для изменения второго числа, 3 для вывода суммы этих чисел, 4 для нахождения наибольшего числа, 5 для вывода просто двух чисел");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                       Console.Write("Пиши какое целое число хочешь ");
                        //int newscetchik1 = Convert.ToInt32(Console.ReadLine());
                        Schetov.scetchik1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Пиши какое целое число хочешь ");
                        //int newscetchik2 = Convert.ToInt32(Console.ReadLine());
                        Schetov.scetchik2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "3":
                        Console.Write($"Cумма этих чисел = {Schetov.scetchik1 + Schetov.scetchik2}\n");
                        break;
                    case "4":
                        if (Schetov.scetchik1 > Schetov.scetchik2)
                        {
                            Console.Write("Первое число больше \n");
                        }
                        else Console.Write("Второе число больше \n");
                        break;
                    case "5":
                        Schetov.writeInConsoleInfo(Schetov.scetchik1, Schetov.scetchik2);
                        b = false;
                        break;
                }
            } while (b);
        }
    }
}