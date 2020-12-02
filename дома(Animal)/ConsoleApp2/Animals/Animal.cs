using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Animals
{
     class Animal : IMove
    {
        public bool IsLive;

        public Animal(){
        }
        public Animal(bool isLive)
        {
            IsLive = isLive;
        }
        public virtual void Live()
        {
            if (IsLive)
                Console.WriteLine("I liv");
            else
                Console.WriteLine("I died");
        }

        public virtual void PrintAll()
        {
            Console.WriteLine("I am Animal");
        }
    }
}
