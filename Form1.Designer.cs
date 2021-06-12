
namespace chess2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gamePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOnline = new System.Windows.Forms.RadioButton();
            this.radioComputer = new System.Windows.Forms.RadioButton();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.onlineSettingsGroup = new System.Windows.Forms.GroupBox();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.capturedPiecesPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.themeDefaultRadioBtn = new System.Windows.Forms.RadioButton();
            this.themeIcySeaRadioBtn = new System.Windows.Forms.RadioButton();
            this.themeGreenRadioBtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.trollfacelolhaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.onlineSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedPiecesPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePictureBox
            // 
            this.gamePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamePictureBox.Location = new System.Drawing.Point(12, 26);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(512, 512);
            this.gamePictureBox.TabIndex = 0;
            this.gamePictureBox.TabStop = false;
            this.gamePictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOnline);
            this.groupBox1.Controls.Add(this.radioComputer);
            this.groupBox1.Controls.Add(this.radioLocal);
            this.groupBox1.Location = new System.Drawing.Point(606, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Mode";
            // 
            // radioOnline
            // 
            this.radioOnline.AutoSize = true;
            this.radioOnline.Location = new System.Drawing.Point(7, 73);
            this.radioOnline.Name = "radioOnline";
            this.radioOnline.Size = new System.Drawing.Size(83, 19);
            this.radioOnline.TabIndex = 2;
            this.radioOnline.TabStop = true;
            this.radioOnline.Text = "Play online";
            this.radioOnline.UseVisualStyleBackColor = true;
            this.radioOnline.CheckedChanged += new System.EventHandler(this.radioOnline_CheckedChanged);
            // 
            // radioComputer
            // 
            this.radioComputer.AutoSize = true;
            this.radioComputer.Location = new System.Drawing.Point(7, 48);
            this.radioComputer.Name = "radioComputer";
            this.radioComputer.Size = new System.Drawing.Size(188, 19);
            this.radioComputer.TabIndex = 1;
            this.radioComputer.TabStop = true;
            this.radioComputer.Text = "Against computer (still a mess)";
            this.radioComputer.UseVisualStyleBackColor = true;
            this.radioComputer.CheckedChanged += new System.EventHandler(this.radioComputer_CheckedChanged);
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Location = new System.Drawing.Point(7, 23);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(53, 19);
            this.radioLocal.TabIndex = 0;
            this.radioLocal.TabStop = true;
            this.radioLocal.Text = "Local";
            this.radioLocal.UseVisualStyleBackColor = true;
            this.radioLocal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(606, 513);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // onlineSettingsGroup
            // 
            this.onlineSettingsGroup.Controls.Add(this.userIDLabel);
            this.onlineSettingsGroup.Controls.Add(this.label1);
            this.onlineSettingsGroup.Controls.Add(this.numericUpDown1);
            this.onlineSettingsGroup.Location = new System.Drawing.Point(606, 294);
            this.onlineSettingsGroup.Name = "onlineSettingsGroup";
            this.onlineSettingsGroup.Size = new System.Drawing.Size(397, 155);
            this.onlineSettingsGroup.TabIndex = 6;
            this.onlineSettingsGroup.TabStop = false;
            this.onlineSettingsGroup.Text = "Online Settings";
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(7, 72);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(75, 15);
            this.userIDLabel.TabIndex = 2;
            this.userIDLabel.Text = "Your ID: 0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 35);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(606, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // capturedPiecesPictureBox
            // 
            this.capturedPiecesPictureBox.Image = global::chess2.Properties.Resources.troll;
            this.capturedPiecesPictureBox.Location = new System.Drawing.Point(531, 26);
            this.capturedPiecesPictureBox.Name = "capturedPiecesPictureBox";
            this.capturedPiecesPictureBox.Size = new System.Drawing.Size(64, 512);
            this.capturedPiecesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capturedPiecesPictureBox.TabIndex = 7;
            this.capturedPiecesPictureBox.TabStop = false;
            this.capturedPiecesPictureBox.Click += new System.EventHandler(this.capturedPiecesPictureBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(606, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.themeDefaultRadioBtn);
            this.groupBox3.Controls.Add(this.themeIcySeaRadioBtn);
            this.groupBox3.Controls.Add(this.themeGreenRadioBtn);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(7, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 130);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Theme";
            // 
            // themeDefaultRadioBtn
            // 
            this.themeDefaultRadioBtn.AutoSize = true;
            this.themeDefaultRadioBtn.Location = new System.Drawing.Point(6, 22);
            this.themeDefaultRadioBtn.Name = "themeDefaultRadioBtn";
            this.themeDefaultRadioBtn.Size = new System.Drawing.Size(63, 19);
            this.themeDefaultRadioBtn.TabIndex = 4;
            this.themeDefaultRadioBtn.Text = "Default";
            this.themeDefaultRadioBtn.UseVisualStyleBackColor = true;
            this.themeDefaultRadioBtn.CheckedChanged += new System.EventHandler(this.themeDefaultRadioBtn_CheckedChanged);
            // 
            // themeIcySeaRadioBtn
            // 
            this.themeIcySeaRadioBtn.AutoSize = true;
            this.themeIcySeaRadioBtn.Checked = true;
            this.themeIcySeaRadioBtn.Location = new System.Drawing.Point(6, 72);
            this.themeIcySeaRadioBtn.Name = "themeIcySeaRadioBtn";
            this.themeIcySeaRadioBtn.Size = new System.Drawing.Size(61, 19);
            this.themeIcySeaRadioBtn.TabIndex = 3;
            this.themeIcySeaRadioBtn.TabStop = true;
            this.themeIcySeaRadioBtn.Text = "Icy Sea";
            this.themeIcySeaRadioBtn.UseVisualStyleBackColor = true;
            this.themeIcySeaRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // themeGreenRadioBtn
            // 
            this.themeGreenRadioBtn.AutoSize = true;
            this.themeGreenRadioBtn.Location = new System.Drawing.Point(6, 47);
            this.themeGreenRadioBtn.Name = "themeGreenRadioBtn";
            this.themeGreenRadioBtn.Size = new System.Drawing.Size(56, 19);
            this.themeGreenRadioBtn.TabIndex = 2;
            this.themeGreenRadioBtn.Text = "Green";
            this.themeGreenRadioBtn.UseVisualStyleBackColor = true;
            this.themeGreenRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-100, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(687, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "makeAnim";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // trollfacelolhaBtn
            // 
            this.trollfacelolhaBtn.Location = new System.Drawing.Point(768, 455);
            this.trollfacelolhaBtn.Name = "trollfacelolhaBtn";
            this.trollfacelolhaBtn.Size = new System.Drawing.Size(75, 23);
            this.trollfacelolhaBtn.TabIndex = 9;
            this.trollfacelolhaBtn.Text = "a funny joke";
            this.trollfacelolhaBtn.UseVisualStyleBackColor = true;
            this.trollfacelolhaBtn.Click += new System.EventHandler(this.trollfacelolhaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.trollfacelolhaBtn);
            this.Controls.Add(this.gamePictureBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.capturedPiecesPictureBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.onlineSettingsGroup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.onlineSettingsGroup.ResumeLayout(false);
            this.onlineSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedPiecesPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOnline;
        private System.Windows.Forms.RadioButton radioComputer;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox onlineSettingsGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox capturedPiecesPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton themeIcySeaRadioBtn;
        private System.Windows.Forms.RadioButton themeGreenRadioBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox gamePictureBox;
        public System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.RadioButton themeDefaultRadioBtn;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Button trollfacelolhaBtn;
    }
}

