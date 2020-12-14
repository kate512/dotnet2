using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12.Hotel
{
    class Room
    {
        int Number;
        int Places;
        decimal Price;
        public Person Resident;
        public Room(int number, int places, decimal price ,Person resident = null)
        {
            Number = number;
            Places = places;
            Resident = resident;
            Price = price;
        }

        public void Settling(Person resident)
        {
            Resident = resident;
            if (Resident.Money >= Price)
            {
                Resident.Money -= Price;
            }
            else
            {
                Console.WriteLine("У пчела нет деняг!");
            }
        }
        
        public void GetResident()
        {
            Console.WriteLine(Resident.LastName);
        }


    }
}
