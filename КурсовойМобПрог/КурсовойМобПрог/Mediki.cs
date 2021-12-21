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
    public partial class Mediki : Form
    {     
        List<Doctor> doctors = new List<Doctor>();
        MedFactory mf = new MedFactory();
        Сompetition competition;
            public Mediki(Сompetition c)
            {
                InitializeComponent();
                competition=c;
                string sp = ReadWriteFile.getInstance().Read(@"Date\Doc.txt");
                string[] s = sp.Split(' ');
                for (int i = 0; i + 4 < s.Length; i += 5)
                {            
                    doctors.Add(mf.GetDoctor(s[i], s[i + 1], Convert.ToByte(s[i + 2]), Convert.ToByte(s[i + 3]),Convert.ToInt32(s[i+4])));
                }
                cbD.DataSource=mf.doctors;
                dgw.DataSource = doctors;
            }

            private void Reg_Click(object sender, EventArgs e)
            {        
            doctors.Add(mf.GetDoctor(tbn.Text, tbsn.Text, Convert.ToByte(tba.Text), Convert.ToByte(tbexp.Text),cbD.SelectedIndex));           
            tbn.Clear();
                tbsn.Clear();
                tba.Clear();               
                MessageBox.Show(
               "Врач добавлен",
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                dgw.DataSource = null;
                dgw.DataSource = doctors;
            }

            private void Save_Click(object sender, EventArgs e)
            {
                string s = "";
                for (int i = 0; i < doctors.Count; i ++)
                {
                    s += doctors[i].Name + " " + doctors[i].Suname + " " + doctors[i].Age + " " + doctors[i].ExpWork + " " + mf.GetIndex(doctors[i].GetType()) + " ";
                }
                ReadWriteFile.getInstance().Write(s, @"Date\Doc.txt");
            }

            private void AddSp_Click(object sender, EventArgs e)
            {
                if (dgw.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                "Выберите врача",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < dgw.SelectedRows.Count; i++)
                {                
                    competition.Meds.Add(doctors[dgw.SelectedRows[i].Index]);
                }
                MessageBox.Show(
                "Врач добавлен",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                dgw.DataSource = null;
                dgw.DataSource = doctors;
            }

            private void button2_Click(object sender, EventArgs e)
            {
                if (dgw.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                "Выберите врача",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < dgw.SelectedRows.Count; i++)
                {
                    doctors.Remove(doctors[dgw.SelectedRows[i].Index]);
                }
                dgw.DataSource = null;
                dgw.DataSource = doctors;
            }
        }
    }
