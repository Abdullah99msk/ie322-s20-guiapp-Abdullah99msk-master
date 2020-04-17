namespace MyFirstApp
{
    partial class FrmMain
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LplUser = new System.Windows.Forms.Label();
            this.LplPw = new System.Windows.Forms.Label();
            this.TxtPw = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLogin.Location = new System.Drawing.Point(147, 139);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 32);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LplUser
            // 
            this.LplUser.AutoSize = true;
            this.LplUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LplUser.Location = new System.Drawing.Point(22, 39);
            this.LplUser.Name = "LplUser";
            this.LplUser.Size = new System.Drawing.Size(69, 17);
            this.LplUser.TabIndex = 3;
            this.LplUser.Text = "Username";
            this.LplUser.Click += new System.EventHandler(this.LplUser_Click);
            // 
            // LplPw
            // 
            this.LplPw.AutoSize = true;
            this.LplPw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LplPw.Location = new System.Drawing.Point(22, 93);
            this.LplPw.Name = "LplPw";
            this.LplPw.Size = new System.Drawing.Size(66, 17);
            this.LplPw.TabIndex = 4;
            this.LplPw.Text = "Password";
            this.LplPw.Click += new System.EventHandler(this.LplPw_Click);
            // 
            // TxtPw
            // 
            this.TxtPw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPw.Location = new System.Drawing.Point(104, 90);
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.Size = new System.Drawing.Size(118, 25);
            this.TxtPw.TabIndex = 5;
            this.TxtPw.TextChanged += new System.EventHandler(this.TxtPw_TextChanged);
            // 
            // TxtUser
            // 
            this.TxtUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtUser.Location = new System.Drawing.Point(104, 36);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(118, 25);
            this.TxtUser.TabIndex = 6;
            this.TxtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.TxtPw);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.LplUser);
            this.groupBox1.Controls.Add(this.LplPw);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 182);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(611, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 108);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Macro Controller";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(25, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(149, 66);
            this.button8.TabIndex = 0;
            this.button8.Text = "Arduin";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.button23);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button22);
            this.groupBox3.Controls.Add(this.button21);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(611, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 313);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Apps";
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button23.Location = new System.Drawing.Point(-261, 69);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(80, 30);
            this.button23.TabIndex = 2;
            this.button23.Text = "Combo";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button3_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Location = new System.Drawing.Point(21, 248);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(149, 39);
            this.button12.TabIndex = 3;
            this.button12.Text = "Johan";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button22.Location = new System.Drawing.Point(-320, 26);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(80, 30);
            this.button22.TabIndex = 1;
            this.button22.Text = "Radio";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button2_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button21.Location = new System.Drawing.Point(-192, 26);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(80, 30);
            this.button21.TabIndex = 0;
            this.button21.Text = "Check Box";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(21, 174);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(149, 41);
            this.button11.TabIndex = 2;
            this.button11.Text = "ABC Analysis";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(21, 100);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(149, 41);
            this.button10.TabIndex = 1;
            this.button10.Text = "Robotic Cell";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(21, 29);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(149, 39);
            this.button9.TabIndex = 0;
            this.button9.Text = "Manufacturing Cell";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(285, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Basic Controls";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(79, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Combo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(6, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Radio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(149, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Box";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox5.Controls.Add(this.button16);
            this.groupBox5.Controls.Add(this.button15);
            this.groupBox5.Controls.Add(this.button14);
            this.groupBox5.Controls.Add(this.button13);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(285, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 100);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "More Controls";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.Location = new System.Drawing.Point(162, 64);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(115, 30);
            this.button16.TabIndex = 3;
            this.button16.Text = "Random Com";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button15.Location = new System.Drawing.Point(6, 64);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(115, 30);
            this.button15.TabIndex = 2;
            this.button15.Text = "Random";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(6, 15);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(115, 30);
            this.button14.TabIndex = 1;
            this.button14.Text = "Progress";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(162, 15);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(115, 30);
            this.button13.TabIndex = 0;
            this.button13.Text = "Timer";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox6.Controls.Add(this.button18);
            this.groupBox6.Controls.Add(this.button17);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(284, 410);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(283, 76);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Draw and Talk";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.Location = new System.Drawing.Point(7, 21);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(114, 49);
            this.button18.TabIndex = 1;
            this.button18.Text = "Draw";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.Location = new System.Drawing.Point(163, 21);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(114, 49);
            this.button17.TabIndex = 0;
            this.button17.Text = "Talk";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox7.Location = new System.Drawing.Point(285, 151);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(283, 116);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Graphical";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(5, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 30);
            this.button7.TabIndex = 3;
            this.button7.Text = "Picture Box2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(147, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 30);
            this.button6.TabIndex = 2;
            this.button6.Text = "Groupie App";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(5, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 30);
            this.button5.TabIndex = 1;
            this.button5.Text = "Picture Box";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(149, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "Selfie App";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Yellow;
            this.button19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button19.Location = new System.Drawing.Point(889, 444);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(145, 52);
            this.button19.TabIndex = 14;
            this.button19.Text = "EXIT";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button20.Location = new System.Drawing.Point(889, 371);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(145, 52);
            this.button20.TabIndex = 15;
            this.button20.Text = "About";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1050, 509);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LplUser;
        private System.Windows.Forms.Label LplPw;
        private System.Windows.Forms.TextBox TxtPw;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
    }
}

