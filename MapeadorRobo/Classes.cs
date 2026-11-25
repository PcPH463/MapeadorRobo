using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeadorRobo
{
    public class Tile
    {
        int X { get; set; }
        int Y { get; set; }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;   
        }
    }
}
