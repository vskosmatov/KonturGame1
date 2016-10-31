using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonturGame1
{
    class MemoryGame//:IGame
    {
        private ImmutableGame BaseGame;
        private Dictionary<int, int> Memory;


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
                throw new NotImplementedException();
            }
        }

        public Location GetLocation(int value)
        {
            throw new NotImplementedException();
        }

        public void Shift(int value)
        {
            throw new NotImplementedException();
        }
    }
}
