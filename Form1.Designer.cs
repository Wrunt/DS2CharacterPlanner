namespace DS2_Character_Planner
{
    partial class Form1
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
            this.lblSoulLevel = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.comClass = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.sl1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sl3 = new System.Windows.Forms.TextBox();
            this.sl2 = new System.Windows.Forms.TextBox();
            this.fai3 = new System.Windows.Forms.TextBox();
            this.int3 = new System.Windows.Forms.TextBox();
            this.ada3 = new System.Windows.Forms.TextBox();
            this.dex3 = new System.Windows.Forms.TextBox();
            this.str3 = new System.Windows.Forms.TextBox();
            this.att3 = new System.Windows.Forms.TextBox();
            this.vit3 = new System.Windows.Forms.TextBox();
            this.vig3 = new System.Windows.Forms.TextBox();
            this.end3 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.vit1 = new System.Windows.Forms.TextBox();
            this.dex1 = new System.Windows.Forms.TextBox();
            this.str1 = new System.Windows.Forms.TextBox();
            this.att1 = new System.Windows.Forms.TextBox();
            this.att2 = new System.Windows.Forms.TextBox();
            this.int2 = new System.Windows.Forms.TextBox();
            this.vit2 = new System.Windows.Forms.TextBox();
            this.end2 = new System.Windows.Forms.TextBox();
            this.vig2 = new System.Windows.Forms.TextBox();
            this.fai2 = new System.Windows.Forms.TextBox();
            this.str2 = new System.Windows.Forms.TextBox();
            this.ada2 = new System.Windows.Forms.TextBox();
            this.dex2 = new System.Windows.Forms.TextBox();
            this.fai1 = new System.Windows.Forms.TextBox();
            this.int1 = new System.Windows.Forms.TextBox();
            this.ada1 = new System.Windows.Forms.TextBox();
            this.end1 = new System.Windows.Forms.TextBox();
            this.vig1 = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoulLevel
            // 
            this.lblSoulLevel.AutoSize = true;
            this.lblSoulLevel.Location = new System.Drawing.Point(15, 75);
            this.lblSoulLevel.Name = "lblSoulLevel";
            this.lblSoulLevel.Size = new System.Drawing.Size(60, 13);
            this.lblSoulLevel.TabIndex = 0;
            this.lblSoulLevel.Text = "Soul Level:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(15, 45);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Class:";
            // 
            // comClass
            // 
            this.comClass.FormattingEnabled = true;
            this.comClass.Items.AddRange(new object[] {
            "---Select Class---",
            "Warrior",
            "Knight",
            "Swordsman",
            "Bandit",
            "Cleric",
            "Sorcerer",
            "Explorer",
            "Deprived"});
            this.comClass.Location = new System.Drawing.Point(125, 41);
            this.comClass.Name = "comClass";
            this.comClass.Size = new System.Drawing.Size(150, 21);
            this.comClass.TabIndex = 2;
            this.comClass.Text = "---Select Class---";
            this.comClass.SelectedIndexChanged += new System.EventHandler(this.comClass_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Build Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 1;
            // 
            // sl1
            // 
            this.sl1.Enabled = false;
            this.sl1.Location = new System.Drawing.Point(125, 71);
            this.sl1.Name = "sl1";
            this.sl1.Size = new System.Drawing.Size(25, 20);
            this.sl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Endurance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vigor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attunement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vitality:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Faith:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Intelligence:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Strength:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Adaptability:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dexterity:";
            // 
            // sl3
            // 
            this.sl3.Enabled = false;
            this.sl3.Location = new System.Drawing.Point(250, 71);
            this.sl3.Name = "sl3";
            this.sl3.Size = new System.Drawing.Size(25, 20);
            this.sl3.TabIndex = 15;
            // 
            // sl2
            // 
            this.sl2.Enabled = false;
            this.sl2.Location = new System.Drawing.Point(187, 71);
            this.sl2.Name = "sl2";
            this.sl2.Size = new System.Drawing.Size(25, 20);
            this.sl2.TabIndex = 16;
            // 
            // fai3
            // 
            this.fai3.Location = new System.Drawing.Point(250, 269);
            this.fai3.Name = "fai3";
            this.fai3.Size = new System.Drawing.Size(25, 20);
            this.fai3.TabIndex = 11;
            // 
            // int3
            // 
            this.int3.Location = new System.Drawing.Point(250, 247);
            this.int3.Name = "int3";
            this.int3.Size = new System.Drawing.Size(25, 20);
            this.int3.TabIndex = 10;
            // 
            // ada3
            // 
            this.ada3.Location = new System.Drawing.Point(250, 225);
            this.ada3.Name = "ada3";
            this.ada3.Size = new System.Drawing.Size(25, 20);
            this.ada3.TabIndex = 9;
            // 
            // dex3
            // 
            this.dex3.Location = new System.Drawing.Point(250, 203);
            this.dex3.Name = "dex3";
            this.dex3.Size = new System.Drawing.Size(25, 20);
            this.dex3.TabIndex = 8;
            // 
            // str3
            // 
            this.str3.Location = new System.Drawing.Point(250, 181);
            this.str3.Name = "str3";
            this.str3.Size = new System.Drawing.Size(25, 20);
            this.str3.TabIndex = 7;
            // 
            // att3
            // 
            this.att3.Location = new System.Drawing.Point(250, 159);
            this.att3.Name = "att3";
            this.att3.Size = new System.Drawing.Size(25, 20);
            this.att3.TabIndex = 6;
            // 
            // vit3
            // 
            this.vit3.Location = new System.Drawing.Point(250, 137);
            this.vit3.Name = "vit3";
            this.vit3.Size = new System.Drawing.Size(25, 20);
            this.vit3.TabIndex = 5;
            // 
            // vig3
            // 
            this.vig3.Location = new System.Drawing.Point(250, 93);
            this.vig3.Name = "vig3";
            this.vig3.Size = new System.Drawing.Size(25, 20);
            this.vig3.TabIndex = 3;
            // 
            // end3
            // 
            this.end3.Location = new System.Drawing.Point(250, 115);
            this.end3.Name = "end3";
            this.end3.Size = new System.Drawing.Size(25, 20);
            this.end3.TabIndex = 4;
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(5, 310);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Save Build";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // check
            // 
            this.check.Enabled = false;
            this.check.Location = new System.Drawing.Point(205, 310);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 15;
            this.check.Text = "Check Class";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // vit1
            // 
            this.vit1.Enabled = false;
            this.vit1.Location = new System.Drawing.Point(125, 137);
            this.vit1.Name = "vit1";
            this.vit1.Size = new System.Drawing.Size(25, 20);
            this.vit1.TabIndex = 28;
            // 
            // dex1
            // 
            this.dex1.Enabled = false;
            this.dex1.Location = new System.Drawing.Point(125, 203);
            this.dex1.Name = "dex1";
            this.dex1.Size = new System.Drawing.Size(25, 20);
            this.dex1.TabIndex = 29;
            // 
            // str1
            // 
            this.str1.Enabled = false;
            this.str1.Location = new System.Drawing.Point(125, 181);
            this.str1.Name = "str1";
            this.str1.Size = new System.Drawing.Size(25, 20);
            this.str1.TabIndex = 30;
            // 
            // att1
            // 
            this.att1.Enabled = false;
            this.att1.Location = new System.Drawing.Point(125, 159);
            this.att1.Name = "att1";
            this.att1.Size = new System.Drawing.Size(25, 20);
            this.att1.TabIndex = 31;
            // 
            // att2
            // 
            this.att2.Enabled = false;
            this.att2.Location = new System.Drawing.Point(187, 159);
            this.att2.Name = "att2";
            this.att2.Size = new System.Drawing.Size(25, 20);
            this.att2.TabIndex = 32;
            // 
            // int2
            // 
            this.int2.Enabled = false;
            this.int2.Location = new System.Drawing.Point(187, 247);
            this.int2.Name = "int2";
            this.int2.Size = new System.Drawing.Size(25, 20);
            this.int2.TabIndex = 33;
            // 
            // vit2
            // 
            this.vit2.Enabled = false;
            this.vit2.Location = new System.Drawing.Point(187, 137);
            this.vit2.Name = "vit2";
            this.vit2.Size = new System.Drawing.Size(25, 20);
            this.vit2.TabIndex = 34;
            // 
            // end2
            // 
            this.end2.Enabled = false;
            this.end2.Location = new System.Drawing.Point(187, 115);
            this.end2.Name = "end2";
            this.end2.Size = new System.Drawing.Size(25, 20);
            this.end2.TabIndex = 35;
            // 
            // vig2
            // 
            this.vig2.Enabled = false;
            this.vig2.Location = new System.Drawing.Point(187, 93);
            this.vig2.Name = "vig2";
            this.vig2.Size = new System.Drawing.Size(25, 20);
            this.vig2.TabIndex = 36;
            // 
            // fai2
            // 
            this.fai2.Enabled = false;
            this.fai2.Location = new System.Drawing.Point(187, 269);
            this.fai2.Name = "fai2";
            this.fai2.Size = new System.Drawing.Size(25, 20);
            this.fai2.TabIndex = 37;
            // 
            // str2
            // 
            this.str2.Enabled = false;
            this.str2.Location = new System.Drawing.Point(187, 181);
            this.str2.Name = "str2";
            this.str2.Size = new System.Drawing.Size(25, 20);
            this.str2.TabIndex = 38;
            // 
            // ada2
            // 
            this.ada2.Enabled = false;
            this.ada2.Location = new System.Drawing.Point(187, 225);
            this.ada2.Name = "ada2";
            this.ada2.Size = new System.Drawing.Size(25, 20);
            this.ada2.TabIndex = 39;
            // 
            // dex2
            // 
            this.dex2.Enabled = false;
            this.dex2.Location = new System.Drawing.Point(187, 203);
            this.dex2.Name = "dex2";
            this.dex2.Size = new System.Drawing.Size(25, 20);
            this.dex2.TabIndex = 40;
            // 
            // fai1
            // 
            this.fai1.Enabled = false;
            this.fai1.Location = new System.Drawing.Point(125, 269);
            this.fai1.Name = "fai1";
            this.fai1.Size = new System.Drawing.Size(25, 20);
            this.fai1.TabIndex = 41;
            // 
            // int1
            // 
            this.int1.Enabled = false;
            this.int1.Location = new System.Drawing.Point(125, 247);
            this.int1.Name = "int1";
            this.int1.Size = new System.Drawing.Size(25, 20);
            this.int1.TabIndex = 42;
            // 
            // ada1
            // 
            this.ada1.Enabled = false;
            this.ada1.Location = new System.Drawing.Point(125, 225);
            this.ada1.Name = "ada1";
            this.ada1.Size = new System.Drawing.Size(25, 20);
            this.ada1.TabIndex = 43;
            // 
            // end1
            // 
            this.end1.Enabled = false;
            this.end1.Location = new System.Drawing.Point(125, 115);
            this.end1.Name = "end1";
            this.end1.Size = new System.Drawing.Size(25, 20);
            this.end1.TabIndex = 44;
            // 
            // vig1
            // 
            this.vig1.Enabled = false;
            this.vig1.Location = new System.Drawing.Point(125, 93);
            this.vig1.Name = "vig1";
            this.vig1.Size = new System.Drawing.Size(25, 20);
            this.vig1.TabIndex = 45;
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(86, 310);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(50, 23);
            this.reset.TabIndex = 13;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.Enabled = false;
            this.update.Location = new System.Drawing.Point(150, 310);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(50, 23);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 342);
            this.Controls.Add(this.update);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.vig1);
            this.Controls.Add(this.end1);
            this.Controls.Add(this.ada1);
            this.Controls.Add(this.int1);
            this.Controls.Add(this.fai1);
            this.Controls.Add(this.dex2);
            this.Controls.Add(this.ada2);
            this.Controls.Add(this.str2);
            this.Controls.Add(this.fai2);
            this.Controls.Add(this.vig2);
            this.Controls.Add(this.end2);
            this.Controls.Add(this.vit2);
            this.Controls.Add(this.int2);
            this.Controls.Add(this.att2);
            this.Controls.Add(this.att1);
            this.Controls.Add(this.str1);
            this.Controls.Add(this.dex1);
            this.Controls.Add(this.vit1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.save);
            this.Controls.Add(this.end3);
            this.Controls.Add(this.vig3);
            this.Controls.Add(this.vit3);
            this.Controls.Add(this.att3);
            this.Controls.Add(this.str3);
            this.Controls.Add(this.dex3);
            this.Controls.Add(this.ada3);
            this.Controls.Add(this.int3);
            this.Controls.Add(this.fai3);
            this.Controls.Add(this.sl2);
            this.Controls.Add(this.sl3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sl1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblSoulLevel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dark Souls 2 Stat Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoulLevel;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox comClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox sl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sl3;
        private System.Windows.Forms.TextBox sl2;
        private System.Windows.Forms.TextBox fai3;
        private System.Windows.Forms.TextBox int3;
        private System.Windows.Forms.TextBox ada3;
        private System.Windows.Forms.TextBox dex3;
        private System.Windows.Forms.TextBox str3;
        private System.Windows.Forms.TextBox att3;
        private System.Windows.Forms.TextBox vit3;
        private System.Windows.Forms.TextBox vig3;
        private System.Windows.Forms.TextBox end3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox vit1;
        private System.Windows.Forms.TextBox dex1;
        private System.Windows.Forms.TextBox str1;
        private System.Windows.Forms.TextBox att1;
        private System.Windows.Forms.TextBox att2;
        private System.Windows.Forms.TextBox int2;
        private System.Windows.Forms.TextBox vit2;
        private System.Windows.Forms.TextBox end2;
        private System.Windows.Forms.TextBox vig2;
        private System.Windows.Forms.TextBox fai2;
        private System.Windows.Forms.TextBox str2;
        private System.Windows.Forms.TextBox ada2;
        private System.Windows.Forms.TextBox dex2;
        private System.Windows.Forms.TextBox fai1;
        private System.Windows.Forms.TextBox int1;
        private System.Windows.Forms.TextBox ada1;
        private System.Windows.Forms.TextBox end1;
        private System.Windows.Forms.TextBox vig1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
    }
}