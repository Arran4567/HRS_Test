using Arran_Jones_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arran_Jones_Test.Services
{
    public interface IDepartmentService
    {
        public IList<string> GetAllMemberSurnames(string departmentName);
        public IList<Department> GetAllDepartmentsOfMember(string Forename, string Surname);
    }
}
