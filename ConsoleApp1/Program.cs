using System;
using System.Globalization;

namespace ConsoleApp1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string str = "5,33";
            try
            {
                double a = double.Parse(str);
                Console.WriteLine(a + "\nУспешная конвертация!");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конвертации!");
            }

         }
    }

}
