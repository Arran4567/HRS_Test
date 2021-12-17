using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arran_Jones_Test.Models
{
    public class Customer
    {
        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Display(Name = "X Coordiante")]
        public int X { get; set; }

        [Display(Name = "Y Coordiante")]
        public int Y { get; set; }
    }
}
