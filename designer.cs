using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess2
{
    public partial class designer : Form
    {
        public designer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            designPictureBox.Image = renderer.renderBitmap();
            pieceSel1.BackColor = renderer.themeColorDark;
            pieceSel2.BackColor = renderer.themeColorDark;
            pieceSel3.BackColor = renderer.themeColorDark;
            pieceSel4.BackColor = renderer.themeColorDark;
            pieceSel5.BackColor = renderer.themeColorDark;
            pieceSel6.BackColor = renderer.themeColorDark;
            pieceSel7.BackColor = renderer.themeColorDark;
            pieceSel8.BackColor = renderer.themeColorDark;
            pieceSel9.BackColor = renderer.themeColorDark;
            pieceSel10.BackColor = renderer.themeColorDark;
            pieceSel11.BackColor = renderer.themeColorDark;
            pieceSel12.BackColor = renderer.themeColorDark;

            pieceSel1.Image = renderer.piece[1];
            pieceSel2.Image = renderer.piece[2];
            pieceSel3.Image = renderer.piece[3];
            pieceSel4.Image = renderer.piece[4];
            pieceSel5.Image = renderer.piece[5];
            pieceSel6.Image = renderer.piece[6];

            pieceSel7.Image = renderer.piece[7];
            pieceSel8.Image = renderer.piece[8];
            pieceSel9.Image = renderer.piece[9];
            pieceSel10.Image = renderer.piece[10];
            pieceSel11.Image = renderer.piece[11];
            pieceSel12.Image = renderer.piece[12];

            darkThemePreview.BackColor = renderer.themeColorDark;
            lightThemePreview.BackColor = renderer.themeColorLight;
            selectionThemePreview.BackColor = renderer.themeColorSelection;


        }

        private void designer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.firstForm.Show();
        }

        private void designPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pieceSel1_Click(object sender, EventArgs e)
        {
            renderer.piece[1] = fileDialog();
        }



        public Bitmap fileDialog()
        {

            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.PNG;*.BMP;*.JPG)|*.PNG;*.BMP;*.JPG";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            Bitmap bitmap = renderer.piece[0];
            if (filePath.Length > 1)
            {
                bitmap = (Bitmap)System.Drawing.Image.FromFile(filePath);
            }
            
            return bitmap;
        }

        private void pieceSel2_Click(object sender, EventArgs e)
        {
            renderer.piece[2] = fileDialog();
        }

        private void pieceSel3_Click(object sender, EventArgs e)
        {
            renderer.piece[3] = fileDialog();
        }

        private void pieceSel4_Click(object sender, EventArgs e)
        {
            renderer.piece[4] = fileDialog();
        }

        private void pieceSel5_Click(object sender, EventArgs e)
        {
            renderer.piece[5] = fileDialog();
        }

        private void pieceSel6_Click(object sender, EventArgs e)
        {
            renderer.piece[6] = fileDialog();
        }

        private void pieceSel7_Click(object sender, EventArgs e)
        {
            renderer.piece[7] = fileDialog();
        }

        private void pieceSel8_Click(object sender, EventArgs e)
        {
            renderer.piece[8] = fileDialog();
        }

        private void pieceSel9_Click(object sender, EventArgs e)
        {
            renderer.piece[9] = fileDialog();
        }

        private void pieceSel10_Click(object sender, EventArgs e)
        {
            renderer.piece[10] = fileDialog();
        }

        private void pieceSel11_Click(object sender, EventArgs e)
        {
            renderer.piece[11] = fileDialog();
        }

        private void pieceSel12_Click(object sender, EventArgs e)
        {
            renderer.piece[12] = fileDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renderer.bitmapsLoaded = false;
        }

        private void designer_Load(object sender, EventArgs e)
        {
            switch (chess2.Properties.Settings.Default.theme)
            {
                case 0:
                    themeDefaultRadioBtn.Checked = true;
                    break;
                case 1:
                    themeGreenRadioBtn.Checked = true;
                    break;
                case 2:
                    themeIcySeaRadioBtn.Checked = true;
                    break;

            }
        }

        private void themeDefaultRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (themeDefaultRadioBtn.Checked)
            {
                renderer.setTheme(0);
            }
        }

        private void themeGreenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (themeGreenRadioBtn.Checked)
            {
                renderer.setTheme(1);
            }
        }

        private void themeIcySeaRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (themeIcySeaRadioBtn.Checked)
            {
                renderer.setTheme(2);
            }
        }

        private void darkThemePreview_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            // dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                renderer.themeColorDark = dlg.Color;
            }
        }

        private void lightThemePreview_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            // dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                renderer.themeColorLight = dlg.Color;
            }
        }

        private void selectionThemePreview_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            // dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                renderer.themeColorSelection = dlg.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renderer.piece[1] = renderer.piece[0];
            renderer.piece[2] = renderer.piece[0];
            renderer.piece[3] = renderer.piece[0];
            renderer.piece[4] = renderer.piece[0];
            renderer.piece[5] = renderer.piece[0];
            renderer.piece[6] = renderer.piece[0];
            renderer.piece[7] = renderer.piece[0];
            renderer.piece[8] = renderer.piece[0];
            renderer.piece[9] = renderer.piece[0];
            renderer.piece[10] = renderer.piece[0];
            renderer.piece[11] = renderer.piece[0];
            renderer.piece[12] = renderer.piece[0];
            rpc.setRPC("Playing TrollChess", "Doing a little trolling", "troll", ";chesstrollface");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap batchImg = fileDialog();
            renderer.piece[0] = batchImg;
            renderer.piece[1] = batchImg;
            renderer.piece[2] = batchImg;
            renderer.piece[3] = batchImg;
            renderer.piece[4] = batchImg;
            renderer.piece[5] = batchImg;
            renderer.piece[6] = batchImg;
            renderer.piece[7] = batchImg;
            renderer.piece[8] = batchImg;
            renderer.piece[9] = batchImg;
            renderer.piece[10] = batchImg;
            renderer.piece[11] = batchImg;
            renderer.piece[12] = batchImg;

        }
    }
}