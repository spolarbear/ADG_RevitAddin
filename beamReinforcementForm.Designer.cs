namespace ADG.ADG_RevitAddin.CS
{
    partial class beamReinforcementForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.asu1 = new System.Windows.Forms.Label();
            this.asu2 = new System.Windows.Forms.Label();
            this.asu3 = new System.Windows.Forms.Label();
            this.asd1 = new System.Windows.Forms.Label();
            this.asd2 = new System.Windows.Forms.Label();
            this.asd3 = new System.Windows.Forms.Label();
            this.pj1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.asv = new System.Windows.Forms.Label();
            this.asv0 = new System.Windows.Forms.Label();
            this.pj2 = new System.Windows.Forms.TextBox();
            this.pj3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.bgtext = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(400, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Revit", 11F);
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "梁编号 类型名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Revit", 11F);
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "箍筋行";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Revit", 11F);
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "上部筋";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Revit", 11F);
            this.label4.Location = new System.Drawing.Point(8, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "腰筋";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(292, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "集中标注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Revit", 11F);
            this.label6.Location = new System.Drawing.Point(8, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "标高";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "25",
            "28",
            "32"});
            this.comboBox1.Location = new System.Drawing.Point(10, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "16";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "KL";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(22, 21);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "5";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "300 x 500"});
            this.comboBox2.Location = new System.Drawing.Point(109, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(77, 20);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "300 x 500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "计算配筋面积";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(115, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 20);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "@";
            // 
            // asu1
            // 
            this.asu1.AutoSize = true;
            this.asu1.Location = new System.Drawing.Point(113, 41);
            this.asu1.Name = "asu1";
            this.asu1.Size = new System.Drawing.Size(29, 12);
            this.asu1.TabIndex = 6;
            this.asu1.Text = "Asu1";
            // 
            // asu2
            // 
            this.asu2.AutoSize = true;
            this.asu2.Location = new System.Drawing.Point(208, 41);
            this.asu2.Name = "asu2";
            this.asu2.Size = new System.Drawing.Size(29, 12);
            this.asu2.TabIndex = 13;
            this.asu2.Text = "Asu2";
            // 
            // asu3
            // 
            this.asu3.AutoSize = true;
            this.asu3.Location = new System.Drawing.Point(306, 40);
            this.asu3.Name = "asu3";
            this.asu3.Size = new System.Drawing.Size(29, 12);
            this.asu3.TabIndex = 14;
            this.asu3.Text = "Asu3";
            // 
            // asd1
            // 
            this.asd1.AutoSize = true;
            this.asd1.Location = new System.Drawing.Point(113, 81);
            this.asd1.Name = "asd1";
            this.asd1.Size = new System.Drawing.Size(29, 12);
            this.asd1.TabIndex = 15;
            this.asd1.Text = "Asd1";
            // 
            // asd2
            // 
            this.asd2.AutoSize = true;
            this.asd2.Location = new System.Drawing.Point(208, 81);
            this.asd2.Name = "asd2";
            this.asd2.Size = new System.Drawing.Size(29, 12);
            this.asd2.TabIndex = 16;
            this.asd2.Text = "Asd2";
            // 
            // asd3
            // 
            this.asd3.AutoSize = true;
            this.asd3.Location = new System.Drawing.Point(306, 81);
            this.asd3.Name = "asd3";
            this.asd3.Size = new System.Drawing.Size(29, 12);
            this.asd3.TabIndex = 17;
            this.asd3.Text = "Asd3";
            // 
            // pj1
            // 
            this.pj1.BackColor = System.Drawing.SystemColors.Window;
            this.pj1.Location = new System.Drawing.Point(169, 96);
            this.pj1.Name = "pj1";
            this.pj1.Size = new System.Drawing.Size(108, 21);
            this.pj1.TabIndex = 18;
            this.pj1.Text = "跨中底";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "75",
            "100",
            "150",
            "200"});
            this.comboBox3.Location = new System.Drawing.Point(66, 42);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(41, 20);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.Text = "100";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "75",
            "100",
            "150",
            "200"});
            this.comboBox4.Location = new System.Drawing.Point(124, 42);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(41, 20);
            this.comboBox4.TabIndex = 20;
            this.comboBox4.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "/";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.comboBox5.Location = new System.Drawing.Point(175, 42);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(41, 20);
            this.comboBox5.TabIndex = 22;
            this.comboBox5.Text = "2";
            // 
            // asv
            // 
            this.asv.AutoSize = true;
            this.asv.Location = new System.Drawing.Point(178, 14);
            this.asv.Name = "asv";
            this.asv.Size = new System.Drawing.Size(23, 12);
            this.asv.TabIndex = 23;
            this.asv.Text = "Asv";
            // 
            // asv0
            // 
            this.asv0.AutoSize = true;
            this.asv0.Location = new System.Drawing.Point(248, 14);
            this.asv0.Name = "asv0";
            this.asv0.Size = new System.Drawing.Size(29, 12);
            this.asv0.TabIndex = 24;
            this.asv0.Text = "Asv0";
            // 
            // pj2
            // 
            this.pj2.BackColor = System.Drawing.SystemColors.Window;
            this.pj2.Location = new System.Drawing.Point(60, 17);
            this.pj2.Name = "pj2";
            this.pj2.Size = new System.Drawing.Size(82, 21);
            this.pj2.TabIndex = 25;
            this.pj2.Text = "起点面";
            // 
            // pj3
            // 
            this.pj3.BackColor = System.Drawing.SystemColors.Window;
            this.pj3.Location = new System.Drawing.Point(308, 17);
            this.pj3.Name = "pj3";
            this.pj3.Size = new System.Drawing.Size(82, 21);
            this.pj3.TabIndex = 26;
            this.pj3.Text = "终点面";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Revit", 10F);
            this.label9.Location = new System.Drawing.Point(48, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "$ % && #";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(6, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "ABCD =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(111, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 12);
            this.label11.TabIndex = 30;
            this.label11.Text = "空格将会根据模型设定";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 21);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "上部通长";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 21);
            this.textBox4.TabIndex = 32;
            this.textBox4.Text = "腰筋";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 21);
            this.textBox5.TabIndex = 33;
            this.textBox5.Text = "标高";
            // 
            // bgtext
            // 
            this.bgtext.AutoSize = true;
            this.bgtext.Font = new System.Drawing.Font("Revit", 9F);
            this.bgtext.Location = new System.Drawing.Point(242, 311);
            this.bgtext.Name = "bgtext";
            this.bgtext.Size = new System.Drawing.Size(117, 14);
            this.bgtext.TabIndex = 6;
            this.bgtext.Text = "纵筋等级3箍筋等级1";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(73, 18);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(22, 21);
            this.textBox6.TabIndex = 34;
            this.textBox6.Text = "(n)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 143);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "多跨参数将同时修改";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pj3);
            this.groupBox3.Controls.Add(this.pj2);
            this.groupBox3.Controls.Add(this.asv0);
            this.groupBox3.Controls.Add(this.asv);
            this.groupBox3.Controls.Add(this.pj1);
            this.groupBox3.Controls.Add(this.asd3);
            this.groupBox3.Controls.Add(this.asd2);
            this.groupBox3.Controls.Add(this.asd1);
            this.groupBox3.Controls.Add(this.asu3);
            this.groupBox3.Controls.Add(this.asu2);
            this.groupBox3.Controls.Add(this.asu1);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 128);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "本跨修改";
            // 
            // beamReinforcementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 339);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bgtext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "beamReinforcementForm";
            this.Text = "梁配筋";
            this.Load += new System.EventHandler(this.beamReinforcementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label asu1;
        private System.Windows.Forms.Label asu2;
        private System.Windows.Forms.Label asu3;
        private System.Windows.Forms.Label asd1;
        private System.Windows.Forms.Label asd2;
        private System.Windows.Forms.Label asd3;
        private System.Windows.Forms.TextBox pj1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label asv;
        private System.Windows.Forms.Label asv0;
        private System.Windows.Forms.TextBox pj2;
        private System.Windows.Forms.TextBox pj3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label bgtext;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}