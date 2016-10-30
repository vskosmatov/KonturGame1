using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonturGame1
{
    interface IGame
    {
        int this[int x, int y] { get; }
        int this[Location location] { get; }
        Location GetLocation(int value);
        IGame Shift(int value);
    }
}
