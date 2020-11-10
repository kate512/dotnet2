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
                Console.WriteLine("Ядовита, лучше с ней не встречаться в реале!");
            else
                Console.WriteLine("Спокойно, она безобидна))");
        }

        //конструктор
        public Snake(string name) : base(true)
        {
            Name = name;
        }
        public new void PrintAll()
        {
            Console.WriteLine($"I am {_name}");
            Console.WriteLine($"    My skin is {_color}");
            Console.Write("    ");
            IsToxic();
        }
    }
}
