using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI_SuperElf.Models
{
    public class UserViewModel
    {
        [DisplayName("Username")]
        [Required]
        public string userName { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string firstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string lastName { get; set; }
        [DisplayName("Email address")]
        [Required]
        public string emailaddress { get; set; }
        public bool isAdmin { get; set; }
        public bool isModerator { get; set; }
        public int userId { get; set; }
    }
}
