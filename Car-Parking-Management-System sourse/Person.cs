using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking_Management_System_sourse
{
    class Person
    {
        private string first_name;
        private string last_name;
        private int phone_number;
        private int age;
        public string FirstName
        {
            get { return first_name; }
            set{ first_name = value; }
        }
        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public int PhoneNumber
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
