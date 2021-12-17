using Arran_Jones_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arran_Jones_Test.Services
{
    public class CustomerService : ICustomerService
    {
        IList<Customer> _customers;

        public CustomerService(IList<Customer> customers)
        {
            _customers = customers;
        }
        public (int, IList<string>) GetMinDistanceBetweenCustomers(int startX, int startY)
        {
            int distance = 0;
            IList<string> orderedCustomerNames = new List<string>();
            IList<Customer> customersRemaining = _customers.ToList();
            do
            {
                int counter = 0;
                Customer customer = new Customer();
                int minDistance = 25565;
                int nextStartX = 0;
                int nextStartY = 0;
                foreach (Customer c in customersRemaining)
                {
                    int distanceBetweenPoints = ((int)Math.Sqrt(Math.Pow((c.X - startX), 2) + Math.Pow((c.Y - startY), 2)));
                    if (distanceBetweenPoints < minDistance)
                    {
                        minDistance = distanceBetweenPoints;
                        customer = c;
                        nextStartX = c.X;
                        nextStartY = c.Y;
                    }
                    counter++;
                }
                orderedCustomerNames.Add(customer.Name);
                customersRemaining.Remove(customer);
                startX = nextStartX;
                startY = nextStartY;
                distance += minDistance;
            } while (customersRemaining.Count > 0);

            return (distance, orderedCustomerNames);
        }
    }
}
