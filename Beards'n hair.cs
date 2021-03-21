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

        public static bool find_customer(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customer.is_compare(customers[i]))
                {
                    return true;
                }
            }
            return false;

        }
        public static bool find_service(Service service)
        {
            for (int i = 0; i < services.Count; i++)
            {
                if (service.is_compare(services[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
}

