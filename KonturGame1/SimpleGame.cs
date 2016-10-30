using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonturGame1
{
    class SimpleGame : IGame
    {
        private int[,] field;
        private Location[] values;
        public SimpleGame(params int[] chips)
        {
            if (chips == null)
                throw new ArgumentNullException("null chips list!");
            if (chips.Length == 0)
                throw new ArgumentException("chips cannot be empty!");
            if (!chips.Contains(0))
                throw new ArgumentException("chips must contain 0!");

            HashSet<int> Set_chips = new HashSet<int>(chips);
            if (Set_chips.Count != chips.Length)
                throw new ArgumentException("chips cannot contains duplicates!");

            var size = (int)Math.Round(Math.Sqrt(chips.Length));
            if (Math.Sqrt(chips.Length) != size)
                throw new ArgumentException("chips must determine square field!");

            values = new Location[size * size];
            field = new int[size, size];
            int count = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    field[i, j] = chips[count];
                    values[chips[count++]]=new Location(i, j);
                }
        }
        public int this[Location location]
        {
            get
            {
                return this[location.x, location.y];
            }
        }

        public int this[int x, int y]
        {
            get
            {
                return field[x, y];
            }
        }

        public Location GetLocation(int value)
        {
            return this.values[value];
        }

        public void Shift(int value)
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

        }
    }
}
