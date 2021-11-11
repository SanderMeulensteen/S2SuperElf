using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Logic_SuperElf;
using SharedFiles;

namespace UI_SuperElf.Models
{
    public class PlayerCreateViewModel
    {
        [DisplayName("Player")]
        public string playerName { get; set; }
        [DisplayName("Position")]
        public Position position { get; set; }
        [DisplayName("Club")]
        public int club { get; set; }
        public List<Club> allClubs { get; set; }
    }
}
