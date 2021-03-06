﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonturGame1
{
    class SimpleGame : AbstractGame
    {
        public SimpleGame(params int[] chips) : base(chips) {}

        public override IGame Shift(int value)
        {
            if (value < 0 || value > values.Length)
                throw new ArgumentException("no chips with this number!");
            if (value == 0)
                throw new ArgumentException("I cannot empty place!");
            var ZeroLocation = values[0];
            var ValueLocation = values[value];
            if ((Math.Abs(ZeroLocation.x - ValueLocation.x) + Math.Abs(ZeroLocation.y - ValueLocation.y)) != 1)
                throw new ArgumentException($"There is no empty place near {value}!");

            this.values[0] = ValueLocation;
            this.values[value] = ZeroLocation;

            this.field[ValueLocation.x, ValueLocation.y] = 0;
            this.field[ZeroLocation.x, ZeroLocation.y] = value;

            return this;
        }
    }
}
