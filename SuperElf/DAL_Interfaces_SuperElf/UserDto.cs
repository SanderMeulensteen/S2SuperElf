using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Interfaces_SuperElf
{
    public class UserDto
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string emailaddress { get; set; }
        public bool isAdmin { get; set; }
        public bool isModerator { get; set; }
    }
}
