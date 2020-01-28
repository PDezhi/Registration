using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_DezhiDing
{
    class Registration
    {
        // declare property 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        //constructor
        public Registration()
        {
        }

        // get the registration information
        public string GetRegString()
        {
            string msg = "First Name:" + FirstName + ", Last Name:" + LastName
                        + ", Email:" + Email + ", Address:" + Email + ", City:"
                        + City + ", Postal Code:" + PostCode + ", Country:"
                        + Country + ", Phone:" + Phone;
            return msg;

        }
    }
}
