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
        public int width = 30;
        public int height = 20;

        public Brick()
        {

        }


        public bool Break(Ball b)
        {
            Rectangle heroRec = new Rectangle(x, y, width, height);
            Rectangle chaseRec = new Rectangle(b.x, b.y, b.size, b.size);

            if (brick.IntersectsWith(chaseRec))
            {
                b.ySpeed = -b.ySpeed;
                return true;
            }

            foreach (Control x in GameScreen.Controls)
            {
                if ((string)x.Tag == "block")
                {
                    if (chaseRec.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        GameScreen.points++;
                        x.Visible = false;
                    }
                }
            }

            return false;
        }

    }
}
