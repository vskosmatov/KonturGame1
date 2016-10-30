using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonturGame1
{
    class ImmutableGame : AbstractGame,IGame
    {
        public ImmutableGame(params int[] chips) : base(chips) { }

        public override IGame Shift(int value)
        {
            if(value < 0 || value > values.Length)
                throw new ArgumentException("no chips with this number!");
            if (value == 0)
                throw new ArgumentException("I cannot empty place!");
            var ZeroLocation = values[0];
            var ValueLocation = values[value];
            if ((Math.Abs(ZeroLocation.x - ValueLocation.x) + Math.Abs(ZeroLocation.y - ValueLocation.y)) != 1)
                throw new ArgumentException($"There is no empty place near {value}!");

            this.field[ValueLocation.x, ValueLocation.y] = 0;
            this.field[ZeroLocation.x, ZeroLocation.y] = value;

            int[] newArray = new int[values.Length];
            var count = 0;
            for (int i = 0; i < Math.Sqrt(values.Length); i++)
                for (int j = 0; j < Math.Sqrt(values.Length); j++)
                    newArray[count++] = field[i,j];


            this.field[ValueLocation.x, ValueLocation.y] = value;
            this.field[ZeroLocation.x, ZeroLocation.y] = 0;


            return new ImmutableGame(newArray);
        }
    }
}
