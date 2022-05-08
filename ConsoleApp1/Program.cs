using System;
using System.Globalization;

namespace ConsoleApp1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            void sol3()
            {
                double usd_rub = 66.50;
                double euro_rub = 70.09;
                double euro_usd = 1.05;
                double usd_euro = 0.95;
                Console.Write("1)usd/rub\n2)euro/rub\n3)euro/usd\n4)usd/euro\nВыбор:");
                string input = Console.ReadLine();
                string valyuta_name = "";
                switch (input)
                {
                    case "1":
                    case "4":valyuta_name = "USD";break;
                    case "2":
                    case "3": valyuta_name = "EURO"; break;
                    default: Console.WriteLine("Несуществует такой опции"); Environment.Exit(0);break;
                }
                Console.Write("Введите количество "+valyuta_name +":");
                double result = Convert.ToDouble(Console.ReadLine());
                switch (input)
                {
                    case "1": Console.WriteLine(result* usd_rub);break;
                    case "2": Console.WriteLine(result * euro_rub); break;
                    case "3": Console.WriteLine(result * euro_usd); break;
                    case "4": Console.WriteLine(result * usd_euro); break;
                    default: Console.WriteLine("Неправильный формат данных");break;
                }
            }
            sol3();

        }
    }

}
