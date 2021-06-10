using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess2
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            board.resetBoard();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //     renderer.render(panel1);

            renderer.setTheme(chess2.Properties.Settings.Default.theme);

            switch (chess2.Properties.Settings.Default.theme)
            {
                case 0:
                    radioButton2.Checked = true;
                    break;
                case 1:
                    radioButton3.Checked = true;
                    break;

            }


                    renderer.copyBoard();
            gamePictureBox.Image = renderer.renderBitmap();
            capturedPiecesPictureBox.Image = renderer.piece[0];
        }



        private void panel1_Click(object sender, EventArgs e)
        {

            

            var relativePoint = this.PointToClient(Cursor.Position);

            int selX =  (relativePoint.X-panel1.Location.X) / 64 + 1;
            int selY = 0 - (relativePoint.Y - panel1.Location.Y) / 64 + 8;
           
            Interface.setSelection(selX, selY);

            //  renderer.render(panel1);
                 // pictureBox3.Image = renderer.renderBitmap();

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Interface.setSelection(0, 0);
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Interface.againstBot = false;
            Interface.againstLocal = true;
            Interface.againstOnline = false;
            timer1.Enabled = false;
            onlineSettingsGroup.Visible = false;
            board.resetBoard();
            //     renderer.render(panel1);
          //  pictureBox3.Image = renderer.renderBitmap();

        }

        private void radioComputer_CheckedChanged(object sender, EventArgs e)
        {
            Interface.againstBot = true;
            Interface.againstLocal = false;
            Interface.againstOnline = false;
            timer1.Enabled = false;
            onlineSettingsGroup.Visible = false;
            board.resetBoard();
            //   renderer.render(panel1);
         //   pictureBox3.Image = renderer.renderBitmap();

        }

        private void radioOnline_CheckedChanged(object sender, EventArgs e)
        {
            Interface.againstBot = false;
            Interface.againstLocal = false;
            Interface.againstOnline = true;
            timer1.Enabled = true;
            onlineSettingsGroup.Visible = true;
            beanchat.pullBoard();
            //  renderer.render(panel1);
  //          pictureBox3.Image = renderer.renderBitmap();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = beanchat.createBoardString(board.boardSquare, Interface.whitesMove);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            board.boardSquare=beanchat.createBoardFromString(textBox1.Text);
            Interface.whitesMove = beanchat.whitesMoveRecieved;
            //  renderer.render(panel1);
   //         pictureBox3.Image = renderer.renderBitmap();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            beanchat.pullBoard();
            
            animation = renderer.renderBitmapAnimation();
                animationTimer.Enabled = true;

            //  renderer.render(panel1);
            //        pictureBox3.Image = renderer.renderBitmap();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            beanchat.channelSet = (int)numericUpDown1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (Interface.againstOnline)
            {
                beanchat.send("w43256234111111110000000000000000000000000000000077777777a98bc89aSTOP", beanchat.channelSet);
            }
            else
            {
                board.resetBoard();
            }
            //     renderer.render(panel1);
 //           pictureBox3.Image = renderer.renderBitmap();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            renderer.setTheme(1);
            chess2.Properties.Settings.Default.theme = 1;
            Properties.Settings.Default.Save();
            gamePictureBox.Image = renderer.renderBitmap();

        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            renderer.setTheme(0);
            chess2.Properties.Settings.Default.theme = 0;
            Properties.Settings.Default.Save();
            gamePictureBox.Image = renderer.renderBitmap();
        }







        public static Bitmap[] animation = new Bitmap[11];
        public static int animationFrame = 1;

        private void button4_Click(object sender, EventArgs e)
        {
            animationTimer.Enabled = true;
            //    pictureBox2.Image = renderer.renderBitmap();
            //    Bitmap[] test = renderer.renderBitmapAnimation();
            //   animation = renderer.renderBitmapAnimation();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animationFrame >= 10) { 
                animationFrame = 0; 
                animationTimer.Enabled = false;
                
                gamePictureBox.Image = renderer.renderBitmap();
                return;
            }


            animationFrame+=1;
            gamePictureBox.Image = animation[animationFrame];
        }






        private void pictureBox3_Click(object sender, EventArgs e)
        {

            var relativePoint = this.PointToClient(Cursor.Position);

            int selX = (relativePoint.X - gamePictureBox.Location.X) / 64 + 1;
            int selY = 0 - (relativePoint.Y - gamePictureBox.Location.Y) / 64 + 8;

            Interface.setSelection(selX, selY);
            if (Interface.firstSel == true)
            {
                animation = renderer.renderBitmapAnimation();
                animationTimer.Enabled = true;
            }
            else
            {
                gamePictureBox.Image = renderer.renderBitmap();
            }
         //   gamePictureBox.Image =renderer.renderBitmap();

        }

        private void animTestCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
