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
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {           
        }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(Image.FromFile("star2.png"), Pos.X, Pos.Y, Size.Width, Size.Height);           
        }
    }
}
