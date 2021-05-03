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
            renderer.render(panel1);
        }



        private void panel1_Click(object sender, EventArgs e)
        {

            

            var relativePoint = this.PointToClient(Cursor.Position);

            int selX =  (relativePoint.X-panel1.Location.X) / 64 + 1;
            int selY = 0 - (relativePoint.Y - panel1.Location.Y) / 64 + 8;
           
            Interface.setSelection(selX, selY);

            renderer.render(panel1);
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
        }

        private void radioComputer_CheckedChanged(object sender, EventArgs e)
        {
            Interface.againstBot = true;
            Interface.againstLocal = false;
            Interface.againstOnline = false;
            timer1.Enabled = false;
        }

        private void radioOnline_CheckedChanged(object sender, EventArgs e)
        {
            Interface.againstBot = false;
            Interface.againstLocal = false;
            Interface.againstOnline = true;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = beanchat.createBoardString(board.boardSquare,Interface.whitesMove);
            beanchat.send(beanchat.createBoardString(board.boardSquare, Interface.whitesMove), 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //board.boardSquare = beanchat.createBoardFromString(textBox1.Text);
            string recieved = beanchat.recieve(1);
            board.boardSquare = beanchat.createBoardFromString(recieved);
            Interface.whitesMove = beanchat.whitesMoveRecieved;
            textBox1.Text = recieved;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            beanchat.pullBoard();
            renderer.render(panel1);
        }
    }
}
