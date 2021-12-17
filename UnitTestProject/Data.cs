using Arran_Jones_Test.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    class Data
    {
        public IList<Person> _People;
        public IList<Department> _Departments;
        public IList<Customer> _Customers;
        public Data()
        {
            _People = new List<Person>() 
            {
                new Person()
                {
                    Surname = "Smith",
                    Forename = "John",
                    Title = "Mr"
                },
                new Person()
                {
                    Surname = "Jones",
                    Forename = "Steve",
                    Title = "Mr"
                },
                new Person()
                {
                    Surname = "Bradshaw",
                    Forename = "Lisa",
                    Title = "Mrs"
                },
                new Person()
                {
                    Surname = "Thompson",
                    Forename = "Joanne",
                    Title = "Miss"
                },
                new Person()
                {
                    Surname = "Johnson",
                    Forename = "David",
                    Title = "Mr"
                }
            };
            _Departments = new List<Department>()
            {
                new Department()
                {
                    Name = "Purchasing",
                    Location = "Top Floor",
                    Members = new List<Person>()
                    {
                        _People[0],
                        _People[1],
                        _People[2]
                    }
                },
                new Department()
                {
                    Name = "Sales",
                    Location = "Bottom Floor",
                    Members = new List<Person>()
                    {
                        _People[2],
                        _People[3],
                        _People[4]
                    }
                }
            };
            _Customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "Customer 1",
                    X = 10,
                    Y = 20
                },
                new Customer()
                {
                    Name = "Customer 2",
                    X = 90,
                    Y = 24
                },
                new Customer()
                {
                    Name = "Customer 3",
                    X = 34,
                    Y = 63
                },
                new Customer()
                {
                    Name = "Customer 4",
                    X = 67,
                    Y = 1
                },
                new Customer()
                {
                    Name = "Customer 5",
                    X = 24,
                    Y = 84
                },
                new Customer()
                {
                    Name = "Customer 6",
                    X = 51,
                    Y = 44
                },
                new Customer()
                {
                    Name = "Customer 7",
                    X = 97,
                    Y = 92
                },
                new Customer()
                {
                    Name = "Customer 8",
                    X = 77,
                    Y = 13
                },
                new Customer()
                {
                    Name = "Customer 9",
                    X = 35,
                    Y = 39
                },
                new Customer()
                {
                    Name = "Customer 10",
                    X = 85,
                    Y = 29
                },
            };
        }
    }
}
