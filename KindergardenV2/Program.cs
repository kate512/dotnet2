using System;
using System.Collections.Generic;
using KindergardenV2.Classes;

namespace KindergardenV2
{
    class Program
    {

        static int CountRewardsOnDiap(List<Person> basePersons, DateTime data1, DateTime data2)
        {
            int count = 0;
            long start = data1.ToBinary();
            long finish = data2.ToBinary();
            foreach (Person person in basePersons)
            {
                foreach (Reward rew in person.Rewards) {
                    long time = rew.Data.ToBinary();
                    if (start <= time && time <= finish)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            /*Reward rew1 = new Reward("За успехи в учебе", new DateTime(2010, 3, 17), who.Educator);
            List<Reward> rewA = new List<Reward>()
            {
                rew1
            };
            List<Reward> rewB = new List<Reward>();
            Educator per1 = new Educator("Николаева Е.А.", rewB);
            per1.Get_Info();

            Educator per2 = new Educator("Сергеева Е.А.", rewA);
            per2.Get_Info();

            Reward rew2 = new Reward("За доброту", new DateTime(2019, 9, 1), who.Educator);
            //Создание базы награждений
            List<Rewarding> baseRewarding = new List<Rewarding>()
            {
                new Rewarding(rew1, ref per1),
                new Rewarding(rew2, ref per2),
            };

            //вывод базы награждения
            Console.WriteLine("**********Награждение**********");
            foreach (Rewarding r in baseRewarding)
            {
                r.Get_Info();
            }
            Console.WriteLine("*******************************");

            //Создание базы людей
            List<Person> basePersons = new List<Person>() { 
                per1,
                per2
            };
            //вывод базы людей
            Console.WriteLine("**********База награждений**********");
            foreach (Person p in basePersons)
            {
                p.Get_Info();
            }
            Console.WriteLine("************************************");

            DateTime dat1 = new DateTime(2016, 2, 5);
            DateTime dat2 = new DateTime(2020, 2, 5);
           
            Console.WriteLine("В нужном диапазоне от " + dat1 + " до " + dat2);
            Console.WriteLine(" было награждений - " + CountRewardsOnDiap(basePersons, dat1, dat2));
            */

            //Рандомное заполнение
            Random rand = new Random();
            Child[] Children ={
                new Child("Летова П.А.", new List<Reward>()),
                new Child("Снежкова К.Я.", new List<Reward>()),
                new Child("Фирсова П.В.", new List<Reward>()),
                new Child("Леднова Т.У.", new List<Reward>()),
                new Child("Судакова У.С.", new List<Reward>()),
            };
            Educator[] Persons = {
                new Educator("Василькова Т.Г.", new List<Reward>()),
                new Educator("Боровикова В.С.", new List<Reward>()),
                new Educator("Василькова Д.Ф.", new List<Reward>()),
                new Educator("Василькова Е.А.", new List<Reward>())
            };
            Reward[] Rewards =
            {
                new Reward("Грамота по плаванию", new DateTime(2014,8,13), who.Child),
                new Reward("Благодарность", new DateTime(2020,8,20), who.Educator),
                new Reward("За успехи в учебе", new DateTime(2005,10,30), who.Child),
                new Reward("За организацию мероприятия", new DateTime(2007,1,9), who.Educator),
                new Reward("За 2 место по теннису", new DateTime(2018,12,13), who.Child)
            };
            int n = 5; // 5 награждений нарандомить
            List<Rewarding> randBase = new List<Rewarding>();
            for(int i = 0; i < n; i++)
            {
                randBase.Add(new Rewarding(Rewards[rand.Next(0,5)],ref Persons[rand.Next(0, 4)]));
                randBase.Add(new Rewarding(Rewards[rand.Next(0, 5)], ref Children[rand.Next(0, 5)]));

            }
            //вывод базы людей
            Console.WriteLine("**********База награждений**********");
            foreach (Rewarding r in randBase)
            {
                r.Get_Info();
            }
            Console.WriteLine("************************************");

            Console.ReadKey();
        }
    }
}
