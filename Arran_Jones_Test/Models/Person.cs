using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arran_Jones_Test.Models
{
    public class Person
    {
        [Display(Name = "Surname")]
        [RegularExpression(@"^[a-zA-Z'-\s]{1,40}$", ErrorMessage = "The field {0} is not a valid Surname")]
        public string Surname { get; set; }

        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z'-\s]{1,40}$", ErrorMessage = "The field {0} is not a valid Forename")]
        public string Forename { get; set; }

        [Display(Name = "Title")]
        [RegularExpression("Mr|Mrs|Miss", ErrorMessage = "Invalid Status")]
        public string Title { get; set; }
    }
}
