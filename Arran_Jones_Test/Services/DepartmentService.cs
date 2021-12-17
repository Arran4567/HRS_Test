using Arran_Jones_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arran_Jones_Test.Services
{
    public class DepartmentService : IDepartmentService
    {
        IList<Department> _departments;

        public DepartmentService(IList<Department> departments)
        {
            _departments = departments;
        }

        public IList<string> GetAllMemberSurnames(string departmentName)
        {
            IList<string> surnames = new List<string>();
            foreach (Department d in _departments)
            {
                if (d.Name == departmentName)
                {
                    foreach (Person p in d.Members)
                    {
                        surnames.Add(p.Surname);
                    }
                }
            }
            return surnames;
        }

        public IList<Department> GetAllDepartmentsOfMember(string surname, string forename)
        {
            IList<Department> departments = new List<Department>();
            foreach (Department d in _departments)
            {
                foreach (Person p in d.Members)
                {
                    //Preferably a get by forename and surname would be in a PersonService rather than using this check.
                    if (p.Forename == forename && p.Surname == surname)
                    {
                        departments.Add(d);
                    }
                }
            }
            return departments;
        }

    }
}
