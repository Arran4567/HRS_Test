using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arran_Jones_Test.Services
{
    public interface ICustomerService
    {
        public (int, IList<string>) GetMinDistanceBetweenCustomers(int startX, int startY);
    }
}
