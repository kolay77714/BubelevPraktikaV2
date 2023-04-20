using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp1 {
    class Student
    {
        public string familia, dr;
        public int nomer;
        public int[] yspevaimost;

        public void writeInConsoleInfo(string familia, string dr, int nomer, int[] yspevaimost)
        {
            Console.WriteLine("Фамилия: {0}\nДень рождение: {1}\nГруппа: {2}\n", familia, dr, nomer);
            Console.WriteLine("Успеваемость:");
            foreach (int i in yspevaimost) {
                Console.Write(i + " ");
            }
        }

        
    }
    public class Program {
       
        public static void Main(string[] args)
        {
            Student Denis = new Student();
            Denis.familia = "Izupov";
            Denis.dr = "07.10.2004";
            Denis.nomer = 623;
            Denis.yspevaimost = new [] {5,5,5,5,5};
            
          Console.WriteLine("Введите 1 для вывода, 2 для изменения данных");
          string a = Console.ReadLine();
          bool rabota = true; 
          while (rabota)
          { 
               switch (a)
              {
                  case "1":
                      Denis.writeInConsoleInfo(Denis.familia, Denis.dr, Denis.nomer,
                          Denis.yspevaimost);
                      rabota = false;
                      break;
                  case "2":
                      Console.WriteLine("Введите 1 для изменения фамилии, 2 дня рождения, 3 группы, 0 для вывода");
                      string b = Console.ReadLine();
                  {
                          switch (b)
                          {
                              case "1":
                                  Console.WriteLine("Введите новую фамилию");
                                  string newfamilia = Console.ReadLine();
                                  Denis.familia = newfamilia;
                                  break;
                              case "2":
                                  Console.WriteLine("Введите новую дату др");
                                  string newdr = Console.ReadLine();
                                  Denis.dr = newdr;
                                  break;
                              case "3":
                                  Console.WriteLine("Введите новую группу");
                                  int newnomer = Convert.ToInt32(Console.ReadLine());
                                  Denis.nomer = newnomer;
                                  break;
                              case "0":
                                  Denis.writeInConsoleInfo(Denis.familia, Denis.dr, Denis.nomer,
                                      Denis.yspevaimost);
                                  rabota = false;
                                  break;
                          }
                      }
                      break;
              }
          }

        }
    }
}