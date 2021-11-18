using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI_SuperElf.Models
{
    public class LoginViewModel
    {
        [DisplayName("Email")]
        [Required]
        public string emailaddress { get; set; }
        [DisplayName("Password")]
        [Required]
        public string password { get; set; }
    }
}
