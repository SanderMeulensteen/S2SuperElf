﻿using System;
using System.Collections.Generic;
using System.Text;
using SharedFiles;

namespace DAL_Interfaces_SuperElf
{
    public class PlayerDto
    {
        public int playerId { get; set; }
        public string playerName { get; set; }
        public int position { get; set; }
        public int club { get; set; }
        
    }
}
