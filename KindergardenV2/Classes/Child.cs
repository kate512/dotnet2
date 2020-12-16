using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergardenV2.Classes
{
    class Child : Person
    {
        public new void Get_Info() 
        {
            base.Get_Info();
            Console.WriteLine("----------------------------------------");
        }
        //конструктор
        public Child(string fio, List<Reward> rewards) : base(fio, rewards)
        {
        }

        //переопределение вирт. метода
        public override string Get_Type()
        {
            return "Child";
        }
    }
}
