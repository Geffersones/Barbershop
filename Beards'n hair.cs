using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop
{
    class Beards_n_hair
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<Service> services = new List<Service>();

        public static int find_customer(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customer.is_compare(customers[i]))
                {
                    return i;
                }
            }
            return -1;

        }
        public static int find_service(Service service)
        {
            for (int i = 0; i < services.Count; i++)
            {
                if (service.is_compare(services[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public static bool add_customer(Customer customer)
        {
            int customer_index = find_customer(customer);
            if (customer_index != -1)
            {
                return false;
            }
            customers.Add(customer);
            return true;
        }
        public static bool add_customer(string name, string last_name)
        {
            return add_customer(new Customer(name, last_name));

        }
        public static bool add_sevice(Service service)
        {
            int service_index = find_service(service);
            if (service_index != -1)
            {
                return false;
            }
            services.Add(service);
            return true;
        }
        public static bool add_service(string name, int price)
        {
            return add_sevice(new Service(name, price));
        }
        public static void print()
        {
            if (services.Count == 0)
            {
                Console.WriteLine("__________________");
                Console.WriteLine("Услуг пока что нет");
                Console.WriteLine("__________________");
            }
            else
            {
                Console.WriteLine("Услуги");
                for (int i = 0; i < services.Count; i++)
                {
                    services[i].print();
                }
            }

            if (services.Count == 0)
            {
                Console.WriteLine("__________________");
                Console.WriteLine("xКлиентов пока что нет");
                Console.WriteLine("__________________");
            }
            else
            {
                Console.WriteLine("Клиенты:");
                for (int i = 0; i < services.Count; i++)
                {
                    services[i].print();
                }
            }
        }
    }
}


