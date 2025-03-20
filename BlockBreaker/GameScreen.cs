using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker
{
    public partial class GameScreen : UserControl
    {
        List<Ball> balls = new List<Ball>();
        Ball chaseBall;


        //public static List<PictureBox> blocks = new List<PictureBox>();

        List<Brick> bricks = new List<Brick>();

        Player hero;

        public static int screenWidth;
        public static int screenHeight;
        bool leftArrowDown, rightArrowDown;

        Random randGen = new Random();
        SolidBrush goldRodBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush darkSalmonBrush = new SolidBrush (Color.DarkSalmon);
        SolidBrush salmonBrush = new SolidBrush (Color.Salmon);
        SolidBrush lightSalmonBrush = new SolidBrush(Color.LightSalmon);
        SolidBrush moccasinBrush = new SolidBrush(Color.Moccasin);
        SolidBrush cornsilkBrush = new SolidBrush (Color.Cornsilk);


        public static int points;

        public GameScreen()
        {
            InitializeComponent();

            screenWidth = this.Width;
            screenHeight = this.Height;

            InitializeGame();

            //foreach(Brick brick in bricks)
            //{
            //    bricks.Add(brick);
            //}
        }

        public void InitializeGame()
        {
            hero = new Player();

            //brick = new Brick();

            int x = randGen.Next(20, this.Width - 50);
            int y = randGen.Next(20, this.Height - 50);

            chaseBall = new Ball(x, y, 8, 8);

            //foreach (Control c in this.Controls)
            //{
            //    if (c is PictureBox)
            //    {
            //        blocks.Add(c as PictureBox);
            //    }
            //}

            int xValue = 51;
            int yValue = 60;

            #region generate blocks
            for (int i = 0; i < 5; i++)
            {
                Brick b = new Brick(xValue + (80 * i), yValue);
                bricks.Add(b);
            }

            for (int i = 0; i < 5; i++)
            {
                Brick b = new Brick(xValue + (80 * i), yValue + 25 + 4);
                bricks.Add(b);
            }

            for (int i = 0; i < 5; i++)
            {
                Brick b = new Brick(xValue + (80 * i), yValue + 50 + 8);
                bricks.Add(b);
            }

            for (int i = 0; i < 5; i++)
            {
                Brick b = new Brick(xValue + (80 * i), yValue + 75 + 12);
                bricks.Add(b);
            }

            for (int i = 0; i < 5; i++)
            {
                Brick b = new Brick(xValue + (80 * i), yValue + 100 + 16);
                bricks.Add(b);
            }

            for (int i = 0; i < 5; i++)
            {
                Brick b = new Brick(xValue + (80 * i), yValue + 125 + 20);
                bricks.Add(b);
            }

            #endregion

            for (int i = 0; i < 5; i++)
            {
                CreateBall();
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void CreateBall()
        {
            int x = this.Width;
            int y = randGen.Next(200, this.Height - 335);

            Ball b = new Ball(x, y, 8, 8);
            balls.Add(b);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region move code

            if (rightArrowDown == true)
            {
                hero.Move("right");
            }
            if (leftArrowDown == true)
            {
                hero.Move("left");
            }

            //moving chaseball
            chaseBall.Move();

            foreach (Ball b in balls)
            {
                b.Move();
            }

            #endregion

            if (hero.Collision(chaseBall))
            {
                //points++;
            }

            foreach (Brick b in bricks)
            {
                if (b.Break(chaseBall))
                {
                    bricks.Remove(b);
                    chaseBall.ySpeed = - chaseBall.ySpeed;
                    break;
                }
            }
            //if (brick.Break(chaseBall))
            //{
            //    points++;
            //}


            Refresh();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;

                case Keys.Right:
                    rightArrowDown = true;
                    break;

            }

        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;

                case Keys.Right:
                    rightArrowDown = false;
                    break;

            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach(Brick b in bricks)
            {
                e.Graphics.FillRectangle(salmonBrush, b.x, b.y, b.width, b.height);
            }

            //update labels
            pointsLabel.Text = $"points: {points}";

            //hero
            e.Graphics.FillRectangle(goldRodBrush, hero.x, hero.y, hero.width, hero.height);

            //score ball
            e.Graphics.FillEllipse(goldRodBrush, chaseBall.x, chaseBall.y, chaseBall.size, chaseBall.size);
        }
    }
}
