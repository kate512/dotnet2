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
            List<Animal> an = new List<Animal> ();
            an.Add(new Horn("Blain"));
            an.Add(new Snake("Cassia"));
            an.Add(new Rodent("Jerry"));

            Console.WriteLine("Our animals:");
            foreach (Animal animal in an)
            {
                animal.PrintAll();
            }
            Console.ReadKey();

        } 
    }
}
