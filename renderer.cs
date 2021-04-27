using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess2
{


    class renderer
    {


        public static void render(Panel panel)
        {

            Bitmap[] piece = new Bitmap[13];
            piece[0] = new Bitmap(chess2.Properties.Resources._12);//this *should* be useless

            piece[1] = new Bitmap(chess2.Properties.Resources._1);
            piece[2] = new Bitmap(chess2.Properties.Resources._2);
            piece[3] = new Bitmap(chess2.Properties.Resources._3);
            piece[4] = new Bitmap(chess2.Properties.Resources._4);
            piece[5] = new Bitmap(chess2.Properties.Resources._5);
            piece[6] = new Bitmap(chess2.Properties.Resources._6);
           piece[7] = new Bitmap(chess2.Properties.Resources._7);
            piece[8] = new Bitmap(chess2.Properties.Resources._8);
           piece[9] = new Bitmap(chess2.Properties.Resources._9);
            piece[10] = new Bitmap(chess2.Properties.Resources._10);
            piece[11] = new Bitmap(chess2.Properties.Resources._11);
           piece[12] = new Bitmap(chess2.Properties.Resources._12);



            Rectangle[,] boardRect = new Rectangle[9, 9];
            SolidBrush DBrush = new SolidBrush(Color.DarkGreen);
            SolidBrush LBrush = new SolidBrush(Color.LightGray);
            SolidBrush YBrush = new SolidBrush(Color.LightYellow);

            Graphics g = panel.CreateGraphics();
            
          //  g.FillRectangle(DGBrush, 0, 0, 64, 64);

            for (int fillerX = 1; fillerX < 9; fillerX++)
            {
                for (int fillerY = 1; fillerY < 9; fillerY++)
                {
                    int myPiece = board.boardSquare[fillerX, fillerY];
                    boardRect[fillerX, fillerY] = new Rectangle((fillerX * 64) - 64, (fillerY * -64) + 512, 64, 64);

                    if ((fillerX + fillerY) %2 == 0)
                    {
                        g.FillRectangle(LBrush, boardRect[fillerX, fillerY]);
                        
                    }
                    else
                    {
                        g.FillRectangle(DBrush, boardRect[fillerX, fillerY]);
                    }
                    
                    if(Interface.selX==fillerX && Interface.selY == fillerY)
                    {

                        g.FillRectangle(YBrush, boardRect[fillerX, fillerY]);
                    }


                    if (myPiece > 0 && myPiece < 13)
                    {
                        
                        g.DrawImage(piece[myPiece], boardRect[fillerX, fillerY]);

                    }
                    
                }
            }

        }

        public int test1()
        {

            return (1);

        }


    }
}
