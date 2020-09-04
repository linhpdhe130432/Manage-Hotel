using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class UsersInformation : Users
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string IndentityCard { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public DateTime Dob { get; set; }
        public string Images { get; set; }
    }
}
