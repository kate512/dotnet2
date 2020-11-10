using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Animals
{
    class Rodent : Animal
    {
        string _name;
        int _years = 1;
        string _gender = "Boy";
        string _colwool = "Brown";
        public string Name
        {
            set
            {
                _name = $"Mr Rodent {value}";
            }
            get
            {
                return _name;
            }
        }
        public int Years
        {
            set
            {
                _years = value;
            }
            get
            {
                return _years;
            }
        }
        public string Gender
        {
            set
            {
                _gender = value;
            }
            get
            {
                return _gender;
            }
        }

        public string Colwool
        {
            set
            {
                _colwool = value;
            }
            get
            {
                return _colwool;
            }
        }
        //конструктор
        public Rodent(string name) : base(true)
        {
            Name = name;
        }

        public new void PrintAll()
        {
            Console.WriteLine($"I am {_name}");
            Console.WriteLine($"    I am {_years} years old and I am { _gender} and My wool is {_colwool}.");   
        }

    }
}
