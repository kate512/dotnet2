using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12.Hotel
{
    class Services
    {
        public string NameServices;
        public decimal PriceServices;

        public Services(string nameServices, decimal priceServices) {
            NameServices = nameServices;
            PriceServices = priceServices;
        }

        public void DoServices(Room room)
        {
            room.Resident.Money -= PriceServices;
            Console.WriteLine("В комнате произведена убока");
        }

    }
}
