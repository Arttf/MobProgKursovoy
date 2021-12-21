namespace КурсовойМобПрог
{
    partial class SelectSorevnovan
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(171, 21);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(100, 20);
            this.tbn.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbo
            // 
            this.tbo.Location = new System.Drawing.Point(171, 60);
            this.tbo.Name = "tbo";
            this.tbo.Size = new System.Drawing.Size(100, 20);
            this.tbo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Организатор";
            // 
            // tbm
            // 
            this.tbm.Location = new System.Drawing.Point(171, 100);
            this.tbm.Name = "tbm";
            this.tbm.Size = new System.Drawing.Size(100, 20);
            this.tbm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Призовой фонд (руб)";
            // 
            // SelectSorevnovan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 175);
            this.Controls.Add(this.tbm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.label1);
            this.Name = "SelectSorevnovan";
            this.Text = "Создание соревнования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbm;
        private System.Windows.Forms.Label label3;
    }
}