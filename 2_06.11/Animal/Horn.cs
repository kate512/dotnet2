using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Animal
{
    class Horn : Animal
    {
        string _name;
        int _numHorn;
        int _years;
        string _gender;
        bool _redBook;

        public string Name
        {
            set
            {
                _name = $"Mr {value}";
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
        public bool RedBook
        {
            set
            {
                _redBook = value;
            }
            get
            {
                return _redBook;
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
    }
}
