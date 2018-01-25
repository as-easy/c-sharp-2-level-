using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1_lesson
{
    class Asteroid : BaseObject
    {
        //public int Power { get; set; }
        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
           // Power = 1;
        }
        public override void Draw()
        {           
            Game.Buffer.Graphics.DrawImage(Image.FromFile("meteorGrey_med1.png"), Pos.X, Pos.Y, Size.Width, Size.Height);
        }
    }
}
