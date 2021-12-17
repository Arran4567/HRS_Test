using System;
using Xunit;
using Arran_Jones_Test.Services;
using System.Collections.Generic;
using Arran_Jones_Test.Models;

namespace UnitTestProject
{
    public class DepartmentUnitTests
    {
        private Data _data;
        private readonly DepartmentService _departmentService;

        public DepartmentUnitTests()
        {
            _data = new Data();
            _departmentService = new DepartmentService(_data._Departments);
        }

        [Fact]
        public void TestGetAllMemberSurnames()
        {
            var Result = _departmentService.GetAllMemberSurnames("Sales");
            var items = Assert.IsType<List<string>>(Result);
            Assert.Equal(_data._Departments[1].Members[0].Surname, items[0]);
            Assert.Equal(_data._Departments[1].Members[1].Surname, items[1]);
            Assert.Equal(_data._Departments[1].Members[2].Surname, items[2]);
        }

        [Fact]
        public void TestGetAllDepartmentsOfMember()
        {
            //Test 1
            var Result = _departmentService.GetAllDepartmentsOfMember("Bradshaw", "Lisa");
            var items = Assert.IsType<List<Department>>(Result);
            Assert.Equal(_data._Departments, items);

            //Test 2
            Result = _departmentService.GetAllDepartmentsOfMember("Smith", "John");
            items = Assert.IsType<List<Department>>(Result);
            Assert.Equal(new List<Department> { _data._Departments[0] }, items);

            //Test 3
            Result = _departmentService.GetAllDepartmentsOfMember("Johnson", "David");
            items = Assert.IsType<List<Department>>(Result);
            Assert.Equal(new List<Department> { _data._Departments[1] }, items);
        }
    }
}
