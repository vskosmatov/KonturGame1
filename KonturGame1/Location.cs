using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonturGame1
{
    class Location
    {
        public int x { get; set; }
        public int y { get; set; }
        public Location()
        { }
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
