namespace КурсовойМобПрог
{
    partial class Sorevnovan
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorevnovan));
            this.dgvSp = new System.Windows.Forms.DataGridView();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvServ = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNSor = new System.Windows.Forms.Label();
            this.LbOrgSor = new System.Windows.Forms.Label();
            this.lbRezSor = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.NewCompetition = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbPrizSor = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.serviceMedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сompetitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listServMedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServ)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сompetitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listServMedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSp
            // 
            this.dgvSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSp.Enabled = false;
            this.dgvSp.Location = new System.Drawing.Point(40, 50);
            this.dgvSp.Name = "dgvSp";
            this.dgvSp.Size = new System.Drawing.Size(379, 150);
            this.dgvSp.TabIndex = 0;
            // 
            // dgvDoc
            // 
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Enabled = false;
            this.dgvDoc.Location = new System.Drawing.Point(686, 50);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.ReadOnly = true;
            this.dgvDoc.Size = new System.Drawing.Size(548, 150);
            this.dgvDoc.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить участника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddYchast_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1128, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить врача";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddDoct_Click);
            // 
            // dgvServ
            // 
            this.dgvServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServ.Enabled = false;
            this.dgvServ.Location = new System.Drawing.Point(656, 260);
            this.dgvServ.Name = "dgvServ";
            this.dgvServ.Size = new System.Drawing.Size(578, 196);
            this.dgvServ.TabIndex = 4;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(179, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(61, 13);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Участники";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(891, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Доктора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Оказание медицинских услуг";
            // 
            // lbNSor
            // 
            this.lbNSor.AutoSize = true;
            this.lbNSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNSor.Location = new System.Drawing.Point(420, 3);
            this.lbNSor.Name = "lbNSor";
            this.lbNSor.Size = new System.Drawing.Size(260, 26);
            this.lbNSor.TabIndex = 8;
            this.lbNSor.Text = "Название соревнования";
            // 
            // LbOrgSor
            // 
            this.LbOrgSor.AutoSize = true;
            this.LbOrgSor.Location = new System.Drawing.Point(425, 44);
            this.LbOrgSor.Name = "LbOrgSor";
            this.LbOrgSor.Size = new System.Drawing.Size(73, 13);
            this.LbOrgSor.TabIndex = 9;
            this.LbOrgSor.Text = "Организатор";
            // 
            // lbRezSor
            // 
            this.lbRezSor.AutoSize = true;
            this.lbRezSor.Location = new System.Drawing.Point(430, 88);
            this.lbRezSor.Name = "lbRezSor";
            this.lbRezSor.Size = new System.Drawing.Size(67, 13);
            this.lbRezSor.TabIndex = 10;
            this.lbRezSor.Text = "Результаты";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Начать/повторить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // NewCompetition
            // 
            this.NewCompetition.Location = new System.Drawing.Point(469, 212);
            this.NewCompetition.Name = "NewCompetition";
            this.NewCompetition.Size = new System.Drawing.Size(165, 23);
            this.NewCompetition.TabIndex = 12;
            this.NewCompetition.Text = "Начать новое соревнование";
            this.NewCompetition.UseVisualStyleBackColor = true;
            this.NewCompetition.Click += new System.EventHandler(this.NewCompetition_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(40, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 200);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(429, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 200);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(251, 67);
            this.textBox1.TabIndex = 14;
            // 
            // lbPrizSor
            // 
            this.lbPrizSor.AutoSize = true;
            this.lbPrizSor.Location = new System.Drawing.Point(426, 64);
            this.lbPrizSor.Name = "lbPrizSor";
            this.lbPrizSor.Size = new System.Drawing.Size(86, 13);
            this.lbPrizSor.TabIndex = 15;
            this.lbPrizSor.Text = "Призовой фонд";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 24);
            this.button4.TabIndex = 16;
            this.button4.Text = "Просмотреть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // serviceMedBindingSource
            // 
            this.serviceMedBindingSource.DataSource = typeof(SportContest.ServiceMed);
            // 
            // сompetitionBindingSource
            // 
            this.сompetitionBindingSource.DataSource = typeof(SportContest.Сompetition);
            // 
            // listServMedBindingSource
            // 
            this.listServMedBindingSource.DataSource = typeof(SportContest.ListServMed);
            // 
            // Sorevnovan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 468);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbPrizSor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NewCompetition);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbRezSor);
            this.Controls.Add(this.LbOrgSor);
            this.Controls.Add(this.lbNSor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dgvServ);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDoc);
            this.Controls.Add(this.dgvSp);
            this.Name = "Sorevnovan";
            this.Text = "Спортивные соревнования";
            this.Activated += new System.EventHandler(this.Sorevnovan_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sorevnovan_FormClosed);
            this.Load += new System.EventHandler(this.Sorevnovan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServ)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сompetitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listServMedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSp;
        private System.Windows.Forms.DataGridView dgvDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNSor;
        private System.Windows.Forms.Label LbOrgSor;
        private System.Windows.Forms.Label lbRezSor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NewCompetition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbPrizSor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource сompetitionBindingSource;
        public System.Windows.Forms.DataGridView dgvServ;
        private System.Windows.Forms.BindingSource serviceMedBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lechenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listServMedBindingSource;
    }
}

