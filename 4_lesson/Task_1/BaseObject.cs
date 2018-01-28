using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Windows;

namespace _1_lesson
{
    abstract class BaseObject: ICollision
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;

        protected BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        public abstract void Draw();
        public virtual void Update()
        {
            if (Pos.Y > Game.Height)
            {
                Random rnd = new Random();
                Pos.Y = 0 - Size.Height;
                Pos.X = rnd.Next(20, Game.Width - Size.Width);
            }
            Pos.Y += Dir.Y;
        }
            
        public bool Collision(ICollision o) => o.Rect.IntersectsWith(this.Rect);
        public Rectangle Rect => new Rectangle(Pos, Size);

    }
}
