namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeroID = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.Button();
            this.txtSuperpower = new System.Windows.Forms.Button();
            this.txtRank = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnSaveHero = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtExamScore = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Superhero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHeroID
            // 
            this.txtHeroID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeroID.Location = new System.Drawing.Point(11, 63);
            this.txtHeroID.Name = "txtHeroID";
            this.txtHeroID.Size = new System.Drawing.Size(66, 24);
            this.txtHeroID.TabIndex = 1;
            this.txtHeroID.Text = "Hero ID:";
            this.txtHeroID.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(11, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(66, 24);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name:";
            this.txtName.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(11, 145);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(66, 24);
            this.txtAge.TabIndex = 3;
            this.txtAge.Text = "Age:";
            this.txtAge.UseVisualStyleBackColor = true;
            // 
            // txtSuperpower
            // 
            this.txtSuperpower.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuperpower.Location = new System.Drawing.Point(11, 184);
            this.txtSuperpower.Name = "txtSuperpower";
            this.txtSuperpower.Size = new System.Drawing.Size(112, 24);
            this.txtSuperpower.TabIndex = 4;
            this.txtSuperpower.Text = "Superpower:";
            this.txtSuperpower.UseVisualStyleBackColor = true;
            // 
            // txtRank
            // 
            this.txtRank.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRank.Location = new System.Drawing.Point(11, 279);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(66, 24);
            this.txtRank.TabIndex = 6;
            this.txtRank.Text = "Rank:";
            this.txtRank.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(11, 322);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 24);
            this.button7.TabIndex = 7;
            this.button7.Text = "Threat Level:";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnSaveHero
            // 
            this.btnSaveHero.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveHero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveHero.Location = new System.Drawing.Point(98, 372);
            this.btnSaveHero.Name = "btnSaveHero";
            this.btnSaveHero.Size = new System.Drawing.Size(213, 61);
            this.btnSaveHero.TabIndex = 8;
            this.btnSaveHero.Text = "Save Hero";
            this.btnSaveHero.UseVisualStyleBackColor = false;
            this.btnSaveHero.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(379, 372);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(213, 61);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(109, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 24);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(109, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 24);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(109, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(510, 24);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(159, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(460, 24);
            this.panel5.TabIndex = 13;
            // 
            // txtExamScore
            // 
            this.txtExamScore.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamScore.Location = new System.Drawing.Point(11, 234);
            this.txtExamScore.Name = "txtExamScore";
            this.txtExamScore.Size = new System.Drawing.Size(148, 24);
            this.txtExamScore.TabIndex = 5;
            this.txtExamScore.Text = "Exam Score (0-100):";
            this.txtExamScore.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(189, 234);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(430, 24);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(109, 279);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(510, 24);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(159, 322);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(460, 24);
            this.panel8.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveHero);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtExamScore);
            this.Controls.Add(this.txtSuperpower);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHeroID);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtHeroID;
        private System.Windows.Forms.Button txtName;
        private System.Windows.Forms.Button txtAge;
        private System.Windows.Forms.Button txtSuperpower;
        private System.Windows.Forms.Button txtRank;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSaveHero;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button txtExamScore;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}