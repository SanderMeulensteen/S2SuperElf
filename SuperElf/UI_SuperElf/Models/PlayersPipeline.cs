﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interfaces_SuperElf;
using Logic_SuperElf;

namespace UI_SuperElf.Models
{
    public class PlayersPipeline
    {
        public List<PlayerViewModel> Players = new List<PlayerViewModel>();
        public List<IClub> Clubs = new List<IClub>();
    }
}
