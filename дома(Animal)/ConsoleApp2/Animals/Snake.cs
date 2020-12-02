using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Animals
{
    class Snake : Animal
    {
        string _name;
        bool _toxic = false;
        string _color = "Grey";
        public string Name
        {
            set
            {
                _name = $"Mr snake {value}";
            }
            get
            {
                return _name;

            }
        }
        public bool Toxic
        {
            set
            {
                _toxic = value;
            }
            get
            {
                return _toxic;
            }
        }
        public string Color
        {
            set
            {
                _color = value;
            }
            get
            {
                return _color;
            }
        }

        public void IsToxic() {
            if (_toxic)
                Console.WriteLine("Toxic, it is better not to meet her in real life!");
            else
                Console.WriteLine("Calm down, she's harmless))");
        }

        //конструктор
        public Snake(string name) : base(true)
        {
            Name = name;
        }
        public override void PrintAll()
        {
            Console.WriteLine($"I am {_name}");
            Console.Write($"    My skin is {_color}. ");
            IsToxic();
        }
    }
}
