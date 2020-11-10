using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Animal
{
    abstract class Animal : IMove
    {
        public bool IsLive;

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
    }
}
