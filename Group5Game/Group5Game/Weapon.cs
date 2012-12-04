﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group5.Game
{
    public class Weapon : Item
    {
        private int power = 0;

        public Weapon(int xIn, int yIn, int hIn, int wIn)
            : base(xIn, yIn, hIn, wIn)
        {
        }

        public int returnPower()
        {
            return this.power;
        }
    }
}
