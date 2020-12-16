using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergardenV2.Classes
{
    class Educator : Person
    {
        //Статус воспитателя
        public string Status;
        //Назначение статуса воспитателю
        private void set_Status(int Rewars)
        {
            if (Rewars >= 0 && Rewars < 3)
            {
                Status = "bronze";
            }
            else if (Rewars >= 3 && Rewars < 7)
            {
                Status = "golden";
            }
            else if (Rewars >= 7)
            {
                Status = "platinum";
            }
        }
        public new void Get_Info()
        {
            base.Get_Info();
            Console.WriteLine("Cтатус : " + Status);
            Console.WriteLine("----------------------------------------");
        }
        //конструктор
        public Educator(string fio, List<Reward> rewards) : base(fio, rewards)
        {
            set_Status(NumOfRew);
        }

        //переопределение вирт. метода
        public override string Get_Type()
        {
            return "Educator";
        }
    }
}
