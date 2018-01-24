using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _1_lesson
{
    
    static class Game 
    {

        private static Bullet _bullet;
        private static Asteroid[] _asteroids;
        private static Fuel _fuel;
        private static Ship _ship = new Ship(new Point(0, 300), new Point(5, 5), new Size(40, 40));

        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        public static BaseObject[] _objs;

        private static Timer _timer = new Timer();
        public static Random Rnd = new Random();

        public static int Width { get; set; } // ширина и высота игрового поля
        public static int Height { get; set; }

        //public static BaseObject[] _obBaseO;
        // public static BaseObject[] _obStar;
        //static Game()
        //{
        //}



        public static void Init(Form form)
        {
            #region Соответствие размеров игрового буфера размерам form
                Graphics g; 
                _context = BufferedGraphicsManager.Current;  
                g = form.CreateGraphics(); 

                Width = form.ClientSize.Width;  
                Height = form.ClientSize.Height;
                Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            #endregion

            #region Создание кнопок                

            Label label1 = new Label();
            label1.Size = new Size(Width/4, Height/8);
            label1.Location = new Point((Width/2)-(Width / (4*2)), (Height/2 - Height /4));
            label1.AutoSize = false;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Автор: Варанкин Владимир";
            form.Controls.Add(label1);

            Button button1 = new Button();
            button1.Size = label1.Size;
            button1.Location = new Point(label1.Location.X, label1.Location.Y + Height / 8);            
            button1.Text = "Старт";
            form.Controls.Add(button1);
            label1.Text = "Автор: Варанкин Владимир";
                
            #endregion

            button1.Click += new EventHandler(GreetingBtn_Click);
            form.KeyDown += Form_KeyDown;
            Ship.MessageDie += Finish;
        }

        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) _bullet = new Bullet(new Point(_ship.Rect.X + 20, _ship.Rect.Y - 20),
            new Point(0, 0), new Size(1, 4));
            if (e.KeyCode == Keys.Up) _ship.Up();
            if (e.KeyCode == Keys.Down) _ship.Down();
            if (e.KeyCode == Keys.Left) _ship.Left();
            if (e.KeyCode == Keys.Right) _ship.Rigth();
        }

        static void GreetingBtn_Click(Object sender, EventArgs e)
        {
            Button button1 = (Button) sender; 
            Form form = button1.FindForm();
            form.Controls.Clear();            
            Load();

            Timer timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_Tick;
            Draw();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }


        public static void Load()
        {
            _objs = new BaseObject[30];
            _bullet = null;   
            _asteroids = new Asteroid[3];
            //_fuel = null;
            var rnd = new Random();

            for (var i = 0; i < _objs.Length; i++)
            {
                int r = rnd.Next(5, 15);
                _objs[i] = new Star(new Point(1000, rnd.Next(0, Game.Height)), 
                                    new Point(-r, r/5), 
                                    new Size(4, 4), 
                                    Width);
            }

            for (var i = 0; i < _asteroids.Length; i++)
            {
                int r = rnd.Next(25, 50);
                _asteroids[i] = new Asteroid(new Point(rnd.Next(0, Game.Width-50), 1000), 
                                             new Point(-r, r /3),
                                             new Size(r, r));
            }

            
        }

        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black);
            foreach (BaseObject obj in _objs)
                obj.Draw();
            foreach (Asteroid a in _asteroids)
            {
                a?.Draw();
            }
            _bullet?.Draw();
            _ship?.Draw();
            if (_ship != null)
                Buffer.Graphics.DrawString("Energy:" + _ship.Energy, SystemFonts.DefaultFont, Brushes.White, 0,
                0);
            Buffer.Render();  
        }

        public static void Update()
        {
            foreach (BaseObject obj in _objs) obj.Update();
            _bullet?.Update();
            for (var i = 0; i < _asteroids.Length; i++)
            {
                if (_asteroids[i] == null) continue;
                _asteroids[i].Update();

                if (_bullet != null && _bullet.Collision(_asteroids[i]))
                {
                    System.Media.SystemSounds.Hand.Play();
                    _asteroids[i] = null;
                    _bullet = null;
                    continue;
                }

                if (!_ship.Collision(_asteroids[i])) continue;
                var rnd = new Random();
                _ship?.EnergyLow(rnd.Next(1, 10));
                System.Media.SystemSounds.Asterisk.Play();
                if (_ship.Energy <= 0) _ship?.Die();

            }            
        }

        public static void Finish()
        {
            _timer.Stop();
            Buffer.Graphics.DrawString("The End", new Font(FontFamily.GenericSansSerif, 60,
            FontStyle.Underline), Brushes.White, 200, 100);
            Buffer.Render();
        }
    }
}
