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
            Console.WriteLine("ID клиента " + ID + ":");
            Console.WriteLine(name + " " + last_name);
            Console.WriteLine("_______________");
        }

       public bool is_compare(Customer other)
    {
        if ((ID == other.ID) && (name == other.name) && (last_name == other.last_name))
            {
                return true;
            }
            return false;
    }


    }
}
