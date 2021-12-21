namespace КурсовойМобПрог
{
    partial class Mediki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbD = new System.Windows.Forms.ComboBox();
            this.tbexp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tba = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(830, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddSp_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbD);
            this.groupBox1.Controls.Add(this.tbexp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbdir);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tba);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbsn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 328);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // cbD
            // 
            this.cbD.FormattingEnabled = true;
            this.cbD.Location = new System.Drawing.Point(132, 181);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(100, 21);
            this.cbD.TabIndex = 13;
            // 
            // tbexp
            // 
            this.tbexp.Location = new System.Drawing.Point(132, 225);
            this.tbexp.Name = "tbexp";
            this.tbexp.Size = new System.Drawing.Size(100, 20);
            this.tbexp.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Опыт работы (лет)";
            // 
            // tbdir
            // 
            this.tbdir.AutoSize = true;
            this.tbdir.Location = new System.Drawing.Point(23, 189);
            this.tbdir.Name = "tbdir";
            this.tbdir.Size = new System.Drawing.Size(65, 13);
            this.tbdir.TabIndex = 9;
            this.tbdir.Text = "Должность";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зарегистрировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Reg_Click);
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(132, 127);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(100, 20);
            this.tba.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Возрост";
            // 
            // tbsn
            // 
            this.tbsn.Location = new System.Drawing.Point(132, 79);
            this.tbsn.Name = "tbsn";
            this.tbsn.Size = new System.Drawing.Size(100, 20);
            this.tbsn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(132, 30);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(100, 20);
            this.tbn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(324, 12);
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.Size = new System.Drawing.Size(581, 202);
            this.dgw.TabIndex = 5;
            // 
            // Mediki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 379);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgw);
            this.Name = "Mediki";
            this.Text = "Медицинский персонал";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbsn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.TextBox tbexp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbdir;
        private System.Windows.Forms.ComboBox cbD;
    }
}