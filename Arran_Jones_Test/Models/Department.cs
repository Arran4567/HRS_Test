using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arran_Jones_Test.Models
{
    public class Department
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Members")]
        public virtual List<Person> Members { get; set; }
    }
}
