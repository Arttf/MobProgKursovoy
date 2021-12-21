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
    
    public partial class Sorevnovan : Form
    {
        Сompetition competition;
        public Sorevnovan(Сompetition c)
        {
            InitializeComponent();
            lbNSor.Text = c.Name;
            LbOrgSor.Text = "Организатор: " + c.Organization;
            lbPrizSor.Text = "Призовой фонд:" + c.MoneyFund;
            competition = c;
        }

        private void AddYchast_Click(object sender, EventArgs e)
        {
            Participants participants = new Participants(competition);
            participants.Show();
        }

        private void AddDoct_Click(object sender, EventArgs e)
        {
            Mediki mediki = new Mediki(competition);
            mediki.Show();
        }

        private void Sorevnovan_Activated(object sender, EventArgs e)
        {
            dgvSp.DataSource = null;
            dgvSp.DataSource = competition.SpMans;
            dgvDoc.DataSource = null;
            dgvDoc.DataSource = competition.Meds;
        }

        private void Sorevnovan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();           
            //Application.ExitThread();
        }

        private void Sorevnovan_Load(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //competition.Name = "2";
            //bs.DataSource = competition;
            //textBox1.DataBindings.Add(new Binding("Text", bs, "name", false, DataSourceUpdateMode.OnPropertyChanged));
            //textBox1.DataBindings.Add("Text", bs, "Wins");
            //competition.Name = "1";
            //странно
            dgvSp.AutoGenerateColumns = false;
            //dgvSp.DataSource = competition.SpMans;
            //dgvDoc.DataSource = competition.Meds;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Имя";
            dgvSp.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Suname";
            column.Name = "Фамилия";
            dgvSp.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Возрост";
            dgvSp.Columns.Add(column);
            dgvServ.DataSource = competition.Lsm.ServiceMeds;            
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            competition.Start(panel1);                       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = competition.Wins;
            dgvServ.DataSource = null;
            dgvServ.DataSource = competition.Lsm.ServiceMeds;
        }

        private void NewCompetition_Click(object sender, EventArgs e)
        {
            SelectSorevnovan selectSorevnovan = new SelectSorevnovan();
            selectSorevnovan.Show();
            this.Hide();
        }
    }
}
