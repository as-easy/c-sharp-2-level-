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
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        public static BaseObject[] _objs;

        // Свойства
        // Ширина и высота игрового поля
        public static int Width { get; set; }
        public static int Height { get; set; }
        //static Game()
        //{
        //}
        public static void Init(Form form)
        {
            // Графическое устройство для вывода графики
            Graphics g;

            // предоставляет доступ к главному буферу графического контекста для текущего приложения
            _context = BufferedGraphicsManager.Current;

            // Создаём объект - поверхность рисования и связываем его с формой
            g = form.CreateGraphics();
            
            // Запоминаем размеры формы
            Width = form.Width;
            Height = form.Height;
            // Связываем буфер в памяти с графическим объектом.
            // для того, чтобы рисовать в буфере
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Load();

            Timer timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_Tick;

        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }


        public static void Load()
        {
            _objs = new BaseObject[4];

            for (int i = 0; i < _objs.Length / 2; i++)
            {
                _objs[i] = new BaseObject(new Point(150 + i * 30, i * 20 ), new Point(7, 7), new Size(10, 10));
            }

            for (int i = _objs.Length / 2; i < _objs.Length; i++)
            {
                _objs[i] = new Star(new Point(200, i * 20 + 20), new Point(i+1, i+1), new Size(5, 5));
            }
        }

        public static void Draw()
        {
            Buffer.Render();
            Buffer.Graphics.Clear(Color.Black);

            foreach (BaseObject obj in _objs)
                obj.Draw();            
        }

        public static void Update()
        {
            foreach (BaseObject obj in _objs)
                obj.Update();
        }
    }
}
