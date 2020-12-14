using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10._12.Hotel;


class Program
{
    static void Main(string[] args)
    {
        Person first = new Person("Сидоров Иван Игнатьевич", Sex.Male, 100000);
        Person second = new Person("Зайкина Паулина Андреевна", Sex.Female, 100500);
        Room number1 = new Room(1, 3, 80000);
        Staff administrator = new Staff("Дмитриев Федор Николаевич", Sex.Male, 10000000000000,"administrator", 10, 1000000 );
        Room number2 = new Room(2, 3, 100001);
        Services cleaning = new Services("Cleaning", 1000);
        number1.Settling(first);
        number1.GetResident();
        Console.WriteLine( first.GetMoney());
        cleaning.DoServices(number1);
        Console.WriteLine( first.GetMoney());

        administrator.GetInfo();
        Console.WriteLine( administrator.GetMoney());
        administrator.PaySalary();
        Console.WriteLine(administrator.GetMoney());
        Console.ReadLine();
    }

}

