using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker
{
    internal class Brick
    {
        public int x, y;
        public int width = 75;
        public int height = 25;

        public Brick(int _x, int _y)
        {
            x = _x; 
            y = _y; 
        }


        public bool Break(Ball b)
        {
            Rectangle brickRec = new Rectangle(x, y, width, height);
            Rectangle chaseRec = new Rectangle(b.x, b.y, b.size, b.size);

            if (brickRec.IntersectsWith(chaseRec))
            {
                return true;
            }

            return false;
        }

    }
}
