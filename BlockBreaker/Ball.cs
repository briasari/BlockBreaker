﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker
{
    internal class Ball
    {
        public int x, y;
        public int size = 8;
        public int xSpeed, ySpeed;

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void Move()
        {
            x += xSpeed;
            y += ySpeed;

            if (x < 0 || x > GameScreen.screenWidth - size)
            {
                xSpeed = -xSpeed;
            }

            if (y < 0)
            {
                ySpeed = -ySpeed;
            }
    }
    }
}
