using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBreaker
{
    internal class Brick
    {
        public int x, y;
        public int width = 30;
        public int height = 20;

        public Brick()
        {

        }







        public bool Collision(Ball b)
        {
            Rectangle blockRec = new Rectangle(x, y, width, height);
            Rectangle chaseRec = new Rectangle(b.x, b.y, b.size, b.size);

            if (blockRec.IntersectsWith(chaseRec))
            {
                b.ySpeed = -b.ySpeed;
                return true;
            }

            return false;
        }
    }
}
