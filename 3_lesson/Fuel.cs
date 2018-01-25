using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1_lesson 
{
    class Fuel : BaseObject
    {
        //public int Power { get; set; }
        public Fuel(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
          //  Power = 1;
        }
        public override void Draw()
        {            
            Game.Buffer.Graphics.DrawImage(Image.FromFile("pill_red.png"), Pos.X, Pos.Y, Size.Width, Size.Height);
        }        
        public override void Update()
        {
            Pos.Y += Dir.Y;
            PositionY = Pos.Y;
            if (Pos.Y > Game.Height + 50)
            {
                Random rnd = new Random();
                Pos.Y = 0 - Size.Height;
                Pos.X = rnd.Next(20, Game.Width - Size.Width);                
            }            
        }

        public int PositionY
        { get;
          protected set;
        }
    }
}
