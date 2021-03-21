using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Customer
    {
        private int cur_max_ID = 0;
        private int ID;
        public string name;  
        public string last_name;
        

        public Customer(string _name, string _last_name)
        {
            name = _name;
            last_name = _last_name;
            ID = cur_max_ID;
            cur_max_ID++;
        }
        public void print()
        {
            Console.WriteLine("_______________");
            Console.WriteLine("Клиент № " + ID + ":");
            Console.WriteLine(name + " " + last_name);
            Console.WriteLine("_______________");
        }
}

    }
}
