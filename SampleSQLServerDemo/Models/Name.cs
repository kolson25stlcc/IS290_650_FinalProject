using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Namespace is used to add propery level attributes

namespace SampleDemo.Models
{
    public class Name
    {
        //For all required fields you have to make each property nullable which is
        //prefixing a ? mark before the property name. Otherwis an error will be thrown
        [Required(ErrorMessage ="ID is required")]
        public int ID { get; set; }

        [Required(ErrorMessage ="First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }
    }
}
