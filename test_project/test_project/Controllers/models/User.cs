using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_project.Controllers.models
{
    public class User
    {
        public User(string name, DateTime dob, string phone, string email, int id)
        {
            Name = name;
            Dob = dob;
            Phone = phone;
            Email = email;
            this.id = id;
        }

        public User()
        {
           
        }

        public string Name { get; set; }
        public DateTime Dob { get; set; }

        public string Phone { get; set; }

        public string  Email { get; set; }

        public int id { get; set; }


    }
}
