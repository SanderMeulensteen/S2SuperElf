using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using SharedFiles;
using Logic_SuperElf;


namespace UI_SuperElf.Models
{
    public class PlayerViewModel
    {
        public int playerId { get; set; }
        [DisplayName("Player")]
        public string playerName { get; set; }
        [DisplayName("Position")]
        public Position position { get; set; }
        [DisplayName("Club")]
        public int club { get; set; }
    }
}
