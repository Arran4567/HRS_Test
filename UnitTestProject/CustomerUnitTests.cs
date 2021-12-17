using System;
using Xunit;
using Arran_Jones_Test.Services;
using System.Collections.Generic;
using Arran_Jones_Test.Models;

namespace UnitTestProject
{
    public class CustomerUnitTests
    {
        private Data _data;
        private readonly CustomerService _customerService;

        public CustomerUnitTests()
        {
            _data = new Data();
            _customerService = new CustomerService(_data._Customers);
        }

        [Fact]
        public void Test1GetMinDistanceBetweenCustomers()
        {
            //Test from (0, 0)
            var Result = _customerService.GetMinDistanceBetweenCustomers(0, 0);
            var items = Assert.IsType<(int, IList<string>)>(Result);
            Assert.Equal(10, items.Item2.Count);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Test 1 Distance = " + items.Item1.ToString());
            System.Diagnostics.Debug.WriteLine("Customers in order of search:");
            foreach(string name in items.Item2)
            {
                System.Diagnostics.Debug.WriteLine(name);
            }
            System.Diagnostics.Debug.WriteLine("");
        }

        [Fact]
        public void Test2GetMinDistanceBetweenCustomers()
        {
            //Test from (0, 0)
            var Result = _customerService.GetMinDistanceBetweenCustomers(100, 100);
            var items = Assert.IsType<(int, IList<string>)>(Result);
            Assert.Equal(10, items.Item2.Count);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Test 2 Distance = " + items.Item1.ToString());
            System.Diagnostics.Debug.WriteLine("Customers in order of search:");
            foreach (string name in items.Item2)
            {
                System.Diagnostics.Debug.WriteLine(name);
            }
            System.Diagnostics.Debug.WriteLine("");
        }

        [Fact]
        public void Test3GetMinDistanceBetweenCustomers()
        {
            //Test from (0, 0)
            var Result = _customerService.GetMinDistanceBetweenCustomers(50, 50);
            var items = Assert.IsType<(int, IList<string>)>(Result);
            Assert.Equal(10, items.Item2.Count);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Test 3 Distance = " + items.Item1.ToString());
            System.Diagnostics.Debug.WriteLine("Customers in order of search:");
            foreach (string name in items.Item2)
            {
                System.Diagnostics.Debug.WriteLine(name);
            }
            System.Diagnostics.Debug.WriteLine("");
        }
    }
}
