﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;
using SharedFiles;

namespace UI_SuperElf.Models
{
    public class PlayerCreateViewModel
    {
        public int playerId { get; set; }
        [DisplayName("Player name")]
        [Required]
        public string playerName { get; set; }
        [DisplayName("Position")]
        [Required]
        public Position position { get; set; }
        [DisplayName("Club")]
        [Required]
        public int club { get; set; }
        public List<IClub> allClubs { get; set; }
    }
}
