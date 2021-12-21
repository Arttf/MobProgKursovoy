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
    public class Сompetition
    {
        string name;
        static int moneyFund;
        string organization;
        public static string wins="";
        public static List<Sportsman> SpMansWins = new List<Sportsman>();
        public List<Sportsman> SpMans = new List<Sportsman>();
        public List<Doctor> Meds = new List<Doctor>();
        List<Trauma> traums = new List<Trauma>();
        public ListServMed Lsm = new ListServMed();

        public Сompetition(string n, int mf, string org)
        {
            name = n;
            moneyFund = mf;
            this.organization = org;
            traums.Add(new Trauma("Сломал ногу", 1.7, MedFactory.getInstance().doctors[2].GetType()));
            traums.Add(new Trauma("Сломал руку", 1.5, MedFactory.getInstance().doctors[2].GetType()));
            traums.Add(new Trauma("Стрес", 1.1, MedFactory.getInstance().doctors[1].GetType()));
            traums.Add(new Trauma("Страх", 1.1, MedFactory.getInstance().doctors[1].GetType()));
            traums.Add(new Trauma("Головные боли", 1.2, MedFactory.getInstance().doctors[0].GetType()));
            traums.Add(new Trauma("Тошнота", 1.3, MedFactory.getInstance().doctors[0].GetType()));
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
        public int MoneyFund
        {
            get
            {
                return moneyFund;
            }
            set
            {
                moneyFund = value;
            }
        }
        public string Organization
        {
            get
            {
                return organization;
            }
            set
            {
                organization = value;
            }
        }
        public string Wins
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
            }
        }

        public void Start(Panel panel1)
        {
            wins = "";
            SpMansWins.Clear();
            if (SpMans.Count == 0)
            {
                MessageBox.Show(
              "Список участников пуст",
              "Сообщение",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;
            }            
            int i = 0;
            foreach (Sportsman item in SpMans)//v Sportsmen perenesti
            {
                item.image.Size = new Size(80 / SpMans.Count, 200 / SpMans.Count);
                item.image.Dock = DockStyle.None;
                item.image.Location = new Point(0, i * item.image.Size.Height);
                item.image.Tag = 1;
                item.image.SizeMode = PictureBoxSizeMode.StretchImage;
                panel1.Controls.Add(item.image);
                (List<Trauma>, Sportsman) Date = (traums, item);
                item.ThreadStart();
                item.myThread.Start(Date);
                var g = item.myThread.ThreadState;
                //item.image.Margin = new Padding(45, i * item.image.Height, 0, 0);
                i++;
            }
            foreach (Doctor item in Meds)//v Doc perenesti
            {
                (List<Sportsman>, Doctor, ListServMed) Date = (SpMans, item,Lsm);
                item.ThreadStart();
                item.myThread.Start(Date);
            }
        }
        public static void End(Sportsman s)
        {            
            wins += SpMansWins.Count + "е место " + s.Name + " " + s.Suname;
            if (SpMansWins.Count == 1) { wins += " выигрыш:" + (moneyFund / 2); }
            else if (SpMansWins.Count == 2) { wins += " выигрыш:" + (moneyFund / 3); }
            else if (SpMansWins.Count == 3) { wins += " выигрыш:" + (moneyFund / 6); }
            wins += Environment.NewLine;            
        }
    }
}
