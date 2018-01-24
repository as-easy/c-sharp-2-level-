using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _1_lesson
{
    class Ship : BaseObject
    {
        private int _energy = 100;
        public int Energy => _energy;
        public delegate void Message();
        public static event Message MessageDie;

        public Ship(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }

        public void EnergyLow(int n)
        {
            _energy -= n;
        }

        public void EnergyUp(int n)
        {
            if(_energy<=150)
                _energy += n;
        }

        public override void Draw()
        {
           // Game.Buffer.Graphics.FillEllipse(Brushes.Wheat, Pos.X, Pos.Y, Size.Width, Size.Height);
            Game.Buffer.Graphics.DrawImage(Image.FromFile("playerShip1_red.png"), Pos.X, Pos.Y, Size.Width, Size.Height);
            
        }

        public override void Update()
        {
        }

        public void Up()
        {
            if (Pos.Y > 0) Pos.Y = Pos.Y - Dir.Y;
        }

        public void Down()
        {
            if (Pos.Y < Game.Height-Size.Height - Dir.Y) Pos.Y = Pos.Y + Dir.Y;
        }

        public void Left()
        {
            if (Pos.X > 0) Pos.X = Pos.X - Dir.X;
        }

        public void Rigth()
        {
            if (Pos.X < Game.Width - Size.Width) Pos.X = Pos.X + Dir.X ;
        }

        public void Die()
        {
            MessageDie?.Invoke();
        }
    }
}
