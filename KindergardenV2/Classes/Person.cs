using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergardenV2.Classes
{
    class Person
    {
        //ФИО
        public string FIO;

        //Список наград 
        public List<Reward> Rewards;

        //Добавление в список с проверкой
        public void Add_Reward(Reward rew)
        {
            if(Get_Type() == rew.Who.ToString() && NoRepeat(rew))
            {
                Rewards.Add(rew);
                set_NumOfRew();
            }
        }
        private bool NoRepeat(Reward rew)
        {
            if (NumOfRew == 0)
            {
                return true;
            }
            else
            {
                foreach (Reward r in Rewards)
                {
                    if ((rew.Name == r.Name) && (rew.Data == r.Data) && (rew.Who == r.Who))
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }

        //количество наград
        public int NumOfRew;
        private void set_NumOfRew()
        {
            NumOfRew = Rewards.Count;
        }

        //вывод информации на экран
        public void Get_Info()
        {
            Console.WriteLine(FIO + "(" + Get_Type() +")" );
            if (NumOfRew == 0)
            {
                Console.WriteLine("     Наград пока нет");

            }
            else
            {
                Console.WriteLine("    Наград - " + NumOfRew + ":");
                foreach (Reward r in Rewards)
                {
                    r.Get_Info();
                }
            }
        }

        //конструктор
        public Person(string fio, List<Reward> rewards)
        {
            FIO = fio;
            Rewards = new List<Reward>();
            foreach (Reward r in rewards) {
                Add_Reward(r);
            };
            set_NumOfRew();
        }

        //виртуальный метод
        public virtual string Get_Type()
        {
            return "Person";
        }
    }
}
