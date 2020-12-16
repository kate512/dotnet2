using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergardenV2.Classes
{
    enum who
    {
        Educator,
        Child
    }
    class Reward
    {
        public string Name;// { get; }
        public DateTime Data { get; }
        public who Who;//{ get; }

        //вывод информации на экран
        public void Get_Info()
        {
            Console.WriteLine("     "+Name + ", выдана:" + Data + " (" + Who + ")");
        }
        //конструтор
        public Reward(string Name1, DateTime Data1, who Who1)
        {
            Name = Name1;
            Data = Data1;
            Who = Who1;
        }
    }
}
