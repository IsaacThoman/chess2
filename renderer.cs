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

            Rectangle[,] boardRect = new Rectangle[8, 8];
            SolidBrush DBrush = new SolidBrush(Color.DarkGreen);
            SolidBrush LBrush = new SolidBrush(Color.LightGray);
            Bitmap piece1 = new Bitmap(chess2.Properties.Resources._1);

            Graphics g = panel.CreateGraphics();
            
          //  g.FillRectangle(DGBrush, 0, 0, 64, 64);

            for (int fillerX = 0; fillerX < 8; fillerX++)
            {
                for (int fillerY = 0; fillerY < 8; fillerY++)
                {
                    boardRect[fillerX, fillerY] = new Rectangle((fillerX * 64) - 0, (fillerY * -64) + 512-64, 64, 64);

                    if ((fillerX + fillerY) %2 == 0)
                    {
                        g.FillRectangle(LBrush, boardRect[fillerX, fillerY]);
                        g.DrawImage(image: piece1, boardRect[fillerX, fillerY]);
                    }
                    else
                    {
                        g.FillRectangle(DBrush, boardRect[fillerX, fillerY]);
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
