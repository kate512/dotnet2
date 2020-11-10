using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Animal;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var horn = new Horn("Рон");
            //horn.Name = "Элиот";
            horn.NumHorn = 1;
            horn.Years = 10;
            horn.Gender = "Мальчик";
            horn.RedBook = true;
            horn.IsLive = true;
            Console.WriteLine(horn.Name);

            horn.Live();
            Console.ReadKey();
            
        }
    }
}
