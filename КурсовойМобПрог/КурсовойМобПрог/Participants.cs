using SportContest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсовойМобПрог
{
    public partial class Participants : Form
    {
         List<Sportsman> sportsmens = new List<Sportsman>();
        Сompetition competition;
        public Participants(Сompetition c)
        {           
            InitializeComponent();
            competition=c;
            string sp = ReadWriteFile.getInstance().Read(@"Date\Sportsman.txt");
            string[] s = sp.Split(' ');
            for(int i = 0; i+3 < s.Length; i +=4) {
                sportsmens.Add(new Sportsman(s[i], s[i+1], Convert.ToByte(s[i+2]), Convert.ToBoolean(s[i + 3])));
            }
            dgw.DataSource = sportsmens;
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            sportsmens.Add(new Sportsman(tbn.Text, tbsn.Text, Convert.ToByte(tba.Text), chb.Checked));
            if (chb.Checked)
                competition.SpMans.Add(sportsmens[sportsmens.Count-1]);
            tbn.Clear();
            tbsn.Clear();
            tba.Clear();
            chb.Checked=false;
            MessageBox.Show(
           "Спортсмен зарегистрирован",
           "Сообщение",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information);
            dgw.DataSource=null;
            dgw.DataSource = sportsmens;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < sportsmens.Count; i ++)
            {
                s += sportsmens[i].Name + " " + sportsmens[i].Suname + " " + sportsmens[i].Age + " " + sportsmens[i].InGame + " ";
            }
            ReadWriteFile.getInstance().Write(s, @"Date\Sportsman.txt");
        }

        private void AddSp_Click(object sender, EventArgs e)
        {
            if (dgw.SelectedRows.Count == 0)
            {
                MessageBox.Show(
            "Выберите спортсмена",
            "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < dgw.SelectedRows.Count; i++)
            {
                sportsmens[dgw.SelectedRows[i].Index].InGame = true;
                competition.SpMans.Add(sportsmens[dgw.SelectedRows[i].Index]);
            }
            MessageBox.Show(
            "Спортсмен добавлен в список участников",
            "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            dgw.DataSource = null;
            dgw.DataSource = sportsmens;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgw.SelectedRows.Count == 0)
            {
                MessageBox.Show(
            "Выберите спортсмена",
            "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < dgw.SelectedRows.Count; i++)
            {
                sportsmens.Remove(sportsmens[dgw.SelectedRows[i].Index]);              
            }
            dgw.DataSource = null;
            dgw.DataSource = sportsmens;
        }
    }
}
