
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.showLegalMovesRadio = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.designBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.darkThemeRadio = new System.Windows.Forms.RadioButton();
            this.lightThemeRadio = new System.Windows.Forms.RadioButton();
            this.AACheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.themeDefaultRadioBtn = new System.Windows.Forms.RadioButton();
            this.themeIcySeaRadioBtn = new System.Windows.Forms.RadioButton();
            this.themeGreenRadioBtn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.debugGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.onlineSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedPiecesPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.debugGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePictureBox
            // 
            this.gamePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamePictureBox.Location = new System.Drawing.Point(12, 26);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(512, 512);
            this.gamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamePictureBox.TabIndex = 0;
            this.gamePictureBox.TabStop = false;
            this.gamePictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOnline);
            this.groupBox1.Controls.Add(this.radioComputer);
            this.groupBox1.Controls.Add(this.radioLocal);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(600, 26);
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
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(6, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(87, 51);
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
            this.onlineSettingsGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.onlineSettingsGroup.Location = new System.Drawing.Point(600, 372);
            this.onlineSettingsGroup.Name = "onlineSettingsGroup";
            this.onlineSettingsGroup.Size = new System.Drawing.Size(397, 106);
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
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
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
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(6, 22);
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
            this.capturedPiecesPictureBox.Location = new System.Drawing.Point(530, 26);
            this.capturedPiecesPictureBox.Name = "capturedPiecesPictureBox";
            this.capturedPiecesPictureBox.Size = new System.Drawing.Size(64, 512);
            this.capturedPiecesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capturedPiecesPictureBox.TabIndex = 7;
            this.capturedPiecesPictureBox.TabStop = false;
            this.capturedPiecesPictureBox.Click += new System.EventHandler(this.capturedPiecesPictureBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showLegalMovesRadio);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.designBtn);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.AACheckBox);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(600, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interface Settings";
            // 
            // showLegalMovesRadio
            // 
            this.showLegalMovesRadio.AutoSize = true;
            this.showLegalMovesRadio.Location = new System.Drawing.Point(7, 188);
            this.showLegalMovesRadio.Name = "showLegalMovesRadio";
            this.showLegalMovesRadio.Size = new System.Drawing.Size(121, 19);
            this.showLegalMovesRadio.TabIndex = 14;
            this.showLegalMovesRadio.Text = "Show legal moves";
            this.showLegalMovesRadio.UseVisualStyleBackColor = true;
            this.showLegalMovesRadio.CheckedChanged += new System.EventHandler(this.showLegalMovesRadio_CheckedChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(110, 162);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2096,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(61, 23);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // designBtn
            // 
            this.designBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.designBtn.Location = new System.Drawing.Point(316, 160);
            this.designBtn.Name = "designBtn";
            this.designBtn.Size = new System.Drawing.Size(75, 23);
            this.designBtn.TabIndex = 10;
            this.designBtn.Text = "Customize";
            this.designBtn.UseVisualStyleBackColor = true;
            this.designBtn.Click += new System.EventHandler(this.designBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.darkThemeRadio);
            this.groupBox6.Controls.Add(this.lightThemeRadio);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(112, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(108, 130);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Interface Colors";
            // 
            // darkThemeRadio
            // 
            this.darkThemeRadio.AutoSize = true;
            this.darkThemeRadio.Location = new System.Drawing.Point(6, 46);
            this.darkThemeRadio.Name = "darkThemeRadio";
            this.darkThemeRadio.Size = new System.Drawing.Size(49, 19);
            this.darkThemeRadio.TabIndex = 1;
            this.darkThemeRadio.Text = "Dark";
            this.darkThemeRadio.UseVisualStyleBackColor = true;
            this.darkThemeRadio.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // lightThemeRadio
            // 
            this.lightThemeRadio.AutoSize = true;
            this.lightThemeRadio.Checked = true;
            this.lightThemeRadio.Location = new System.Drawing.Point(7, 21);
            this.lightThemeRadio.Name = "lightThemeRadio";
            this.lightThemeRadio.Size = new System.Drawing.Size(52, 19);
            this.lightThemeRadio.TabIndex = 0;
            this.lightThemeRadio.TabStop = true;
            this.lightThemeRadio.Text = "Light";
            this.lightThemeRadio.UseVisualStyleBackColor = true;
            this.lightThemeRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // AACheckBox
            // 
            this.AACheckBox.AutoSize = true;
            this.AACheckBox.Checked = true;
            this.AACheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AACheckBox.Location = new System.Drawing.Point(7, 163);
            this.AACheckBox.Name = "AACheckBox";
            this.AACheckBox.Size = new System.Drawing.Size(103, 19);
            this.AACheckBox.TabIndex = 11;
            this.AACheckBox.Text = "NN Resolution";
            this.AACheckBox.UseVisualStyleBackColor = true;
            this.AACheckBox.CheckedChanged += new System.EventHandler(this.AACheckBox_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown2);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.radioButton6);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton5);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Location = new System.Drawing.Point(226, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 130);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Board Size";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(6, 98);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDown2.Visible = false;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(89, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Set";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 22);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(104, 19);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "512px (Default)";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 19);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Custom Size";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 47);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(99, 19);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "768px (Larger)";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(-100, 0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(94, 19);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.themeDefaultRadioBtn);
            this.groupBox3.Controls.Add(this.themeIcySeaRadioBtn);
            this.groupBox3.Controls.Add(this.themeGreenRadioBtn);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(7, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 130);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Board Colors";
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
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(87, 22);
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
            // debugGroupBox
            // 
            this.debugGroupBox.Controls.Add(this.checkBox1);
            this.debugGroupBox.Controls.Add(this.button3);
            this.debugGroupBox.Controls.Add(this.button4);
            this.debugGroupBox.Controls.Add(this.button1);
            this.debugGroupBox.Controls.Add(this.textBox1);
            this.debugGroupBox.Controls.Add(this.button2);
            this.debugGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.debugGroupBox.Location = new System.Drawing.Point(600, 484);
            this.debugGroupBox.Name = "debugGroupBox";
            this.debugGroupBox.Size = new System.Drawing.Size(397, 118);
            this.debugGroupBox.TabIndex = 7;
            this.debugGroupBox.TabStop = false;
            this.debugGroupBox.Text = "Debug Options";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(169, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Reverse, reverse!";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 614);
            this.Controls.Add(this.debugGroupBox);
            this.Controls.Add(this.gamePictureBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.capturedPiecesPictureBox);
            this.Controls.Add(this.onlineSettingsGroup);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
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
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.debugGroupBox.ResumeLayout(false);
            this.debugGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox debugGroupBox;
        private System.Windows.Forms.Button designBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox AACheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton lightThemeRadio;
        private System.Windows.Forms.RadioButton darkThemeRadio;
        private System.Windows.Forms.CheckBox showLegalMovesRadio;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

