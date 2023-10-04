using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Введите смайлик");
            string str = Console.ReadLine();
            string value = @"^[;:]\S";
            string value2 = @"-*\S";
            string value3 = @"((\))|(\()|(\[)|(\]))\S";
            if (Regex.Match(str, value).Success ) 
            {
               if (Regex.Match(str, value2).Success)
                {
                    
                    if(Regex.Match(str, value3).Success)
                    {
                        Console.WriteLine("Это смайлик");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
