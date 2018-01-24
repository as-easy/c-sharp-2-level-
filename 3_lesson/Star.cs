using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _1_lesson
{
    class Star : BaseObject
    {
        public static int Width { get; set; }
        public Star(Point pos, Point dir, Size size, int width) : base(pos, dir, size)
        {
            Width = width;
        }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(Image.FromFile("star2.png"), Pos.X, Pos.Y, Size.Width, Size.Height);
            //Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            //Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X, Pos.Y + Size.Height);
        }

        public override void Update()
        {
            if (Pos.Y > Game.Height - 40)
            {
                Random rnd = new Random();
                Pos.Y = 0;
                Pos.X = rnd.Next(20, Width - 20);
            }
            Pos.Y += Dir.Y;
        }

    }

}
