using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12.Hotel
{
    public class Staff : Person
    {
        string Position;
        int Experience;
        decimal Salary;
        public Staff(string FIO, Sex Sex, decimal Money, string position, int experience, decimal salary) : base(FIO, Sex, Money)
        {
            Position = position;
            Experience = experience;
            Salary = salary;
        }

        public void PaySalary()
        {
            Money += Salary;
        }

        public override void GetInfo()
        {
            Console.WriteLine("FIO: " + LastName + " " + Name + " " + Patronymic + ". Sex: " + Sex + ". Position: "+ Position + ". Experience"+Experience + ".Salary:"+ Salary);
        }
    }
}
