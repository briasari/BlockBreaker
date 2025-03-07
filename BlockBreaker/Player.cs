using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBreaker
{
    internal class Player
    {
        public int x, y;
        public int width = 100;
        public int height = 10;
        public int speed = 8;

        public Player()
        {
            x = GameScreen.screenWidth / 2 - width / 2;
            y = GameScreen.screenHeight / 2 - height / 2 + 225;
        }

        public void Move(string direction)
        {
            if (direction == "right" && x < GameScreen.screenWidth - width)
            {
                x += speed;
            }
            if (direction == "left" && x > 0)
            {
                x -= speed;
            }
        }

        public bool Collision(Ball b)
        {
            Rectangle heroRec = new Rectangle(x, y, width, height);
            Rectangle chaseRec = new Rectangle(b.x, b.y, b.size, b.size);

            if (heroRec.IntersectsWith(chaseRec))
            {
                b.ySpeed = -b.ySpeed;
                return true;
            }

            return false;
        }
    }
}
