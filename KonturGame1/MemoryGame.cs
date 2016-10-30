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

        public int this[Location location]
        {
            get
            {
                throw new NotImplementedException();
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
