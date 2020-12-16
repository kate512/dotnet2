using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergardenV2.Classes
{
    class Rewarding
    {
        public Reward NameRew;
        public Person ToWhom;

        //вывод на консоль
        public void Get_Info()
        {
            Console.WriteLine("---");
            Console.WriteLine("Награда :");
            NameRew.Get_Info();
            Console.WriteLine("Присуждается :");
            Console.WriteLine("     "+ToWhom.FIO +"(" +ToWhom.Get_Type()+")");
            if (ToWhom.Get_Type() != NameRew.Who.ToString())
            {
                Console.WriteLine("!!!! Отмена награждения. Причина - не соответсвие условию награды !!!!");
            }
            Console.WriteLine("---");

        }
        //конструктор
        public Rewarding(Reward nameRew,ref Child toWhom)
        {
            NameRew = nameRew;
            toWhom.Add_Reward(NameRew); //проверка на соответствие
            ToWhom = toWhom;
        }
        public Rewarding(Reward nameRew, ref Educator toWhom)
        {
            NameRew = nameRew;
            toWhom.Add_Reward(NameRew); //проверка на соответствие
            ToWhom = toWhom;
        }
    }
}
