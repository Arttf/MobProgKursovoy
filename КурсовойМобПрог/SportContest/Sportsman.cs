using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportContest
{
    public class Sportsman : Man
    {
        string name = "Default";
        string suname = "Default";
        byte age = 0;
        public Trauma trauma = null;        
        public double force = 1;
        int prizovihAll = 0;
        bool inGame = false;

        public PictureBox image = new PictureBox();        
        public Thread myThread;
        static object locker = new object();
        public void ThreadStart() { myThread = new Thread(new ParameterizedThreadStart(Run)); }
        public Sportsman(string n, string sn, byte a)
        {
            name = n;
            suname = sn;
            age = a;                 
        }
        public Sportsman(string n, string sn, byte a,bool b)
        {
            name = n;
            suname = sn;
            age = a;
            inGame = b;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Suname
        {
            get
            {
                return suname;
            }
            set
            {
                suname = value;
            }
        }
        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public bool InGame
        {
            get
            {
                return inGame;
            }
            set
            {
                inGame = value;
            }
        }
        public static void Run(object obj) {
            (List<Trauma> traums, Sportsman sportsman) DTr = (((List<Trauma>, Sportsman))obj);
            PictureBox img = DTr.sportsman.image;
            int num = Convert.ToInt32(img.Tag);
            img.Image = Image.FromFile("Img//" + num + ".jpg");     //img.Margin = new Padding(img.Margin.Left+5, 0, 0,0);none       
            DTr.sportsman.image.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                DTr.sportsman.image.Location = new Point(img.Location.X + 5, img.Location.Y);
            });
            Random r = new Random();
            int kof = Convert.ToInt32(100 * (1 + r.NextDouble())*DTr.sportsman.force);
            Thread.Sleep(kof);
            if(r.Next(40)==1)getTrauma(DTr);
            if (num < 6) img.Tag = ++num; else { img.Tag = 1; }
            if (img.Location.X>=429- img.Size.Width) {
                lock (locker)
                {
                    Сompetition.SpMansWins.Add(DTr.sportsman);
                    Сompetition.End(DTr.sportsman);
                    img.Image = null;
                    return;
                }
            }
            Run(DTr);
        }
        public static void getTrauma(object obj) {
            (List<Trauma> traums, Sportsman sportsman) DTr = (((List<Trauma>, Sportsman))obj);           
            Random r = new Random();            
            DTr.sportsman.trauma = (Trauma)DTr.traums[r.Next(DTr.traums.Count) ].Clone();
            DTr.sportsman.force = 1 / DTr.sportsman.trauma.Condition;
        }
    }
}
