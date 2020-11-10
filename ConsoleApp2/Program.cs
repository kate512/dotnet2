using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Animals;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var animals = new Animal[3];
            animals[0] = new Horn("Грейв");
            animals[1] = new Snake("Цассия");
            animals[2] = new Horn("Дейк");
            for (int i = 0; i < 3; i++)
            {
                animals[i].PrintAll();
            }
            /*var horn = new Horn("Рон");
            //horn.Name = "Элиот";
            horn.NumHorn = 1;
            horn.Years = 10;
            horn.Gender = "Мальчик";

            horn.PrintAll();*/
            Console.ReadKey();

        } 
    }
}
