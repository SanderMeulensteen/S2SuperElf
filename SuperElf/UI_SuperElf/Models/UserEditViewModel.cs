using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI_SuperElf.Models
{
    public class UserEditViewModel
    {
        public int userId { get; set; }
        [DisplayName("Email")]
        [Required]
        public string emailaddress { get; set; }
        [DisplayName("Username")]
        [Required]
        public string userName { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string firstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string lastName { get; set; }
        [DisplayName("Password")]
        [Required]
        public string password { get; set; }
        [DisplayName("Confirm password")]
        [Compare("password")]
        public string confirmPassword { get; set; }
        public bool isAdmin { get; set; }
        public bool isModerator { get; set; }
    }
}
