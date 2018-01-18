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
        public static BaseObject[] _obBaseO;
        public static BaseObject[] _obStar;
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
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));


            // Связываем буфер в памяти с графическим объектом.
            // для того, чтобы рисовать в буфере

            Button button1 = new Button();
            button1.Location = new Point(100, 125);
            button1.Text = "Старт";
            form.Controls.Add(button1);

            //по клику очищается форма от кнопки и Label
            button1.Click += new EventHandler(GreetingBtn_Click);

            Label label1 = new Label();
            label1.Location = new Point(83, 58);
            
            label1.Text = "Автор: Варанкин Владимир";
            form.Controls.Add(label1);

        }

        static void GreetingBtn_Click(Object sender,
                           EventArgs e)
        {
            Button button1 = (Button) sender;
            // button1.Visible = false;
            Form form = button1.FindForm();
            form.Controls.Clear();
            // form["button1"].Visible = false;
            //Label label1 =  form.Controls.Find("label1", true).FirstOrDefault() as Label;
            //if(label1 != null)
            //                     label1.Visible = false;
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
            //Метеориты. Описаны в классе BaseObject
            _obBaseO = new BaseObject[10];
            Random rnd1 = new Random();
            byte[] bytes1 = new byte[_obBaseO.Length];
            rnd1.NextBytes(bytes1);

            for (int i = 0; i < _obBaseO.Length; i++)
            {
                int baseObSize = 17;
                int baseObSpeed = 7;
                _obBaseO[i] = new BaseObject(new Point(i * (Width-40) / (_obBaseO.Length), bytes1[i]), 
                                             new Point(baseObSpeed, baseObSpeed), 
                                             new Size(baseObSize, baseObSize));
            }

            //Звезды падают. Падение описано в классе Star
            _obStar = new BaseObject[20];
            Random rnd2 = new Random();
            byte[] bytes2 = new byte[_obStar.Length];
            rnd2.NextBytes(bytes2);

            for (int i = 0; i < _obStar.Length; i++)
            {  
                int starSize = 12;
                int starSpeed = 4;
                _obStar[i] = new Star(new Point(i * (Width-40)/(_obStar.Length), bytes2[i]), 
                                      new Point(starSpeed, starSpeed), 
                                      new Size(starSize, starSize), Width);

            }
        }

        public static void Draw()
        {
            Buffer.Render();
            Buffer.Graphics.Clear(Color.Black);
           
            foreach (BaseObject obj in _obBaseO)
                obj.Draw();

            foreach (BaseObject obj in _obStar)
                obj.Draw();       
        }

        public static void Update()
        {
            foreach (BaseObject obj in _obBaseO)
                obj.Update();

            foreach (BaseObject obj in _obStar)
                obj.Update();
        }
    }
}
