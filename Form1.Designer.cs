
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOnline = new System.Windows.Forms.RadioButton();
            this.radioComputer = new System.Windows.Forms.RadioButton();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 512);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOnline);
            this.groupBox1.Controls.Add(this.radioComputer);
            this.groupBox1.Controls.Add(this.radioLocal);
            this.groupBox1.Location = new System.Drawing.Point(518, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 189);
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
            this.radioComputer.Size = new System.Drawing.Size(193, 19);
            this.radioComputer.TabIndex = 1;
            this.radioComputer.TabStop = true;
            this.radioComputer.Text = "Against computer (very broken)";
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
            this.button1.Location = new System.Drawing.Point(535, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "input";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 567);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOnline;
        private System.Windows.Forms.RadioButton radioComputer;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

