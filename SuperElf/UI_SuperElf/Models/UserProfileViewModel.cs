using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interfaces_SuperElf;

namespace UI_SuperElf.Models
{
    public class UserProfileViewModel
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
        [DisplayName("Email")]
        [Required]
        public string emailaddress { get; set; }
        public int userId { get; set; }
        public List<IPlayer> myTeam = new List<IPlayer>();
    }
}
