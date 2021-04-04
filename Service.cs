using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Service
    {
        private static int cur_max_ID = 0;

        public string name;
        public int price;
        private int ID;

        public Service(string _name, int _price)
        {
            name = _name;
            price = _price;
            ID = cur_max_ID;
            cur_max_ID++;
        }
        public void print()
        {
            Console.WriteLine("_______________");
            Console.WriteLine("ID услуги " + ID + ":");
            Console.WriteLine("Название услуги: " + name);
            Console.WriteLine("Цена услуги: " + price);
            Console.WriteLine("_______________");

        }
        public bool is_compare(Service other)
        {
            if ((ID == other.ID) && (name == other.name) && (price == other.price))
            {
                return true;
            }
            return false;
        }

    }
}
