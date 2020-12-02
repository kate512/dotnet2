using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Animals
{
    class Horn : Animal
    {
        string _name;
        int _numHorn = 2;
        int _years = 1;
        string _gender = "Boy";

        public string Name
        {
            set
            {
                _name = $"Mr horned {value}";
            }
            get
            {
                return _name;

            }
        }
        public int NumHorn
        {
            set
            {
                _numHorn = value;
            }
            get
            {
                return _numHorn;
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

        public void LiveYearYet()
        {
            Years++;
        }

        //конструктор
        public Horn(string name) : base(true)
        {
            Name = name;
        }
        public override void PrintAll()
        {
            Console.WriteLine($"I am {_name}");
            Console.WriteLine($"    I am {_gender} and I have {_numHorn} horns and I am {_years} years old.");
        }
    }
}
