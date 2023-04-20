using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Train
    {
        public string pynkt, vremia;
        public int nomer;

        public void writeInConsoleInfo(string pynkt, string vremia, int nomer)
        {
            Console.WriteLine("Номер поезда: {0}\nВремя: {1}\nПункт: {2}", nomer, vremia, pynkt);
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Train poezd1 = new Train();
            poezd1.pynkt = "Msk";
            poezd1.nomer = 1;
            poezd1.vremia = "22:00";

            Train poezd2 = new Train();
            poezd2.pynkt = "Msk";
            poezd2.nomer = 2;
            poezd2.vremia = "13:00";     
            
            Train poezd3 = new Train();
            poezd3.pynkt = "Spb";
            poezd3.nomer = 3;
            poezd3.vremia = "8:00";   
           
            Console.WriteLine("Введите номер поезда от 1 до 3");
            string chislo = Console.ReadLine();

            switch (chislo)
            {
                case "1": 
                    poezd1.writeInConsoleInfo(poezd1.pynkt, poezd1.vremia, poezd1.nomer);
                    break;
                case "2": 
                    poezd2.writeInConsoleInfo(poezd2.pynkt, poezd2.vremia, poezd2.nomer);
                    break;
                case "3":
                    poezd3.writeInConsoleInfo(poezd3.pynkt, poezd3.vremia, poezd3.nomer);
                    break;
            }
        }
    }
}