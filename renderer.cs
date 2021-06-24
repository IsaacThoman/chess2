using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace chess2
{


    class renderer
    {



        public static Color themeColorDark = System.Drawing.ColorTranslator.FromHtml("#779AAF");
        public static Color themeColorLight = System.Drawing.ColorTranslator.FromHtml("#d5E1E5");
        public static Color themeColorSelection = Color.LightYellow;
        public static bool showLegalMoves = true;
        public static int resolution = 768;



        public static Bitmap[] piece = new Bitmap[17];

        public static bool bitmapsLoaded = false;
        public static void setTheme(int theme)
        {

            switch (theme)
            {
                case 0:
                    renderer.themeColorDark = System.Drawing.ColorTranslator.FromHtml("#856730");
                    renderer.themeColorLight = System.Drawing.ColorTranslator.FromHtml("#e0d9cc");
                    themeColorSelection = Color.LightYellow;
                    break;
                case 1:
                    renderer.themeColorDark = System.Drawing.ColorTranslator.FromHtml("#6E9C41");
                    renderer.themeColorLight = System.Drawing.ColorTranslator.FromHtml("#dee8d5");
                    themeColorSelection = Color.LightYellow;
                    break;
                case 2:
                    renderer.themeColorDark = System.Drawing.ColorTranslator.FromHtml("#779AAF");
                    renderer.themeColorLight = System.Drawing.ColorTranslator.FromHtml("#d5E1E5");
                    renderer.themeColorSelection = Color.LightYellow;
                    break;
            }
        }
        public static void checkForBitmaps()

        {
            if (bitmapsLoaded == false)
            {
                piece[0] = new Bitmap(chess2.Properties.Resources.troll);//this *should* be useless
                
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

                piece[13] = new Bitmap(chess2.Properties.Resources.sword); //sword
                piece[16] = new Bitmap(chess2.Properties.Resources.sword_b); //sword_b

                piece[14] = new Bitmap(chess2.Properties.Resources.legalMoveDot); //legal move dot
                piece[15] = new Bitmap(chess2.Properties.Resources.redDot); //red attack dot

                bitmapsLoaded = true;
            }
        }
        public static void render(Panel panel)
        {

            



            checkForBitmaps();
            Rectangle[,] boardRect = new Rectangle[9, 9];
            SolidBrush DBrush = new SolidBrush(themeColorDark);
            SolidBrush LBrush = new SolidBrush(themeColorLight);
            SolidBrush YBrush = new SolidBrush(themeColorSelection);

            Graphics g = panel.CreateGraphics();

            //  g.FillRectangle(DGBrush, 0, 0, 64, 64);

            for (int fillerX = 1; fillerX < 9; fillerX++)
            {
                for (int fillerY = 1; fillerY < 9; fillerY++)
                {
                    int myPiece = board.boardSquare[fillerX, fillerY];
                    boardRect[fillerX, fillerY] = new Rectangle((fillerX * 64) - 64, (fillerY * -64) + 512, 64, 64);

                    if ((fillerX + fillerY) % 2 == 1)
                    {
                        g.FillRectangle(LBrush, boardRect[fillerX, fillerY]);

                    }
                    else
                    {
                        g.FillRectangle(DBrush, boardRect[fillerX, fillerY]);
                    }

                    if (Interface.selX == fillerX && Interface.selY == fillerY)
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
        //---------------------------------------------------------------------NEW STUFF


        public static Bitmap renderBitmap()
        {
            Bitmap Bmp = new Bitmap(resolution, resolution);
            using (Graphics gfx = Graphics.FromImage(Bmp))
            using (SolidBrush brush = new SolidBrush(Color.DarkGoldenrod))
            {
                gfx.FillRectangle(brush, 0, 0, resolution, resolution);
            }



            checkForBitmaps();
            Rectangle[,] boardRect = new Rectangle[9, 9];
            SolidBrush DBrush = new SolidBrush(themeColorDark);
            SolidBrush LBrush = new SolidBrush(themeColorLight);
            SolidBrush YBrush = new SolidBrush(themeColorSelection);


            Graphics g = Graphics.FromImage(Bmp);
           
            //  g.FillRectangle(DGBrush, 0, 0, 64, 64);

            for (int fillerX = 1; fillerX < 9; fillerX++)
            {
                for (int fillerY = 1; fillerY < 9; fillerY++)
                {
                    int myPiece = board.boardSquare[fillerX, fillerY];
                    boardRect[fillerX, fillerY] = new Rectangle((fillerX * (resolution/8)) - (resolution/8), (fillerY * -(resolution/8)) + resolution, (resolution/8), (resolution/8));

                    if ((fillerX + fillerY) % 2 == 1)
                    {
                        g.FillRectangle(LBrush, boardRect[fillerX, fillerY]);
                       
                    }
                    else
                    {
                        g.FillRectangle(DBrush, boardRect[fillerX, fillerY]);
                    }

                    if (Interface.selX == fillerX && Interface.selY == fillerY)
                    {

                        g.FillRectangle(YBrush, boardRect[fillerX, fillerY]);
                    }
                    bool legalSquare = false;
                    if (!Interface.firstSel)
                    {
                        if (Interface.whitesMove)
                        {
                            if (rulebook.checkLegality(Interface.selX, Interface.selY, fillerX, fillerY, board.boardSquare))
                            {
                                legalSquare = true; 
                            }

                        }
                        else
                        {
                            if (rulebook.checkLegality(9-Interface.selX, 9-Interface.selY, 9-fillerX, 9-fillerY, board.boardSquareReversed))
                            {
                                legalSquare = true;
                            }
                        }



                    }
                    if (legalSquare && showLegalMoves && myPiece == 0)
                    {
                        g.DrawImage(piece[14], boardRect[fillerX, fillerY]);
                    }

                    if (myPiece > 0 && myPiece < 13)
                    {

                        
                        if(legalSquare && showLegalMoves)
                        {
                            g.DrawImage(piece[15], boardRect[fillerX, fillerY]); //draw dot behind piece
                        }
                        g.DrawImage(piece[myPiece], boardRect[fillerX, fillerY]);//draw piece
                        if (legalSquare && showLegalMoves)
                        {
                            if (myPiece > 6)
                            {
                                g.DrawImage(piece[13], boardRect[fillerX, fillerY]);//draw sword
                            }
                            else
                            {
                                g.DrawImage(piece[16], boardRect[fillerX, fillerY]);//draw sword
                            }
                            
                        }
                    }



                }
            }

            return Bmp;
        }

        public static int[,] oldBoard = new int[9,9];
        public static void copyBoard()
        {
            for (int scanDifX = 0; scanDifX < 9; scanDifX++)
            {
                for (int scanDifY = 0; scanDifY < 9; scanDifY++)
                {
                    oldBoard[scanDifX, scanDifY] = board.boardSquare[scanDifX, scanDifY];
                }
            }



        }





        public static Bitmap animationOut = new Bitmap(512,512);

        public static bool doAnimation = false;



        public static Bitmap[] renderBitmapAnimation()
        {
            Bitmap[] animation = new Bitmap[11];


            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;


            for (int scanDifX = 0; scanDifX < 9; scanDifX++)
            {
                for (int scanDifY = 0; scanDifY < 9; scanDifY++)
                {
                    if(oldBoard[scanDifX,scanDifY] == board.boardSquare[scanDifX, scanDifY])
                    {
                     //   Debug.WriteLine("All is good at "+scanDifX+", "+scanDifY);
                    }
                    else
                    {
                     //   Debug.WriteLine("DiffX:" + scanDifX + " DiffY:" + scanDifY);
                        if(board.boardSquare[scanDifX,scanDifY] == 0)
                        {
                            sourceX = scanDifX;
                            sourceY = scanDifY;
                        }
                        else
                        {
                            destX = scanDifX;
                            destY = scanDifY;
                        }


                    }

                }
            }
            Debug.WriteLine(sourceX+", "+sourceY+" to "+destX+", "+destY);
            if(sourceX == 0)
            {
                doAnimation = false;
            }

            for (int frame = 0; frame <= 10; frame++)
            {

                Bitmap Bmp = renderFrame(destX,destY,sourceX,sourceY,frame);
                animation[frame] = Bmp;

            }


            copyBoard();
            return animation;
        }


        //-------------------------------------------------------------------------
        

        public static Bitmap renderFrame(int destX,int destY, int sourceX, int sourceY, int frame)
        {
            Bitmap Bmp = new Bitmap(resolution, resolution);
            using (Graphics gfx = Graphics.FromImage(Bmp))
            using (SolidBrush brush = new SolidBrush(Color.DarkGoldenrod))
            {
                gfx.FillRectangle(brush, 0, 0, resolution, resolution);
            }
            


            checkForBitmaps();
            Rectangle[,] boardRect = new Rectangle[9, 9];
            SolidBrush DBrush = new SolidBrush(themeColorDark);
            if (frame < 5)
            {
          //      DBrush = new SolidBrush(Color.DarkRed); //red flash to make sure it's playing
            }
            SolidBrush LBrush = new SolidBrush(themeColorLight);
            SolidBrush YBrush = new SolidBrush(themeColorSelection);


            Graphics g = Graphics.FromImage(Bmp);

            //  g.FillRectangle(DGBrush, 0, 0, 64, 64);

            for (int fillerX = 1; fillerX < 9; fillerX++)
            {
                for (int fillerY = 1; fillerY < 9; fillerY++)
                {
                    int myPiece = board.boardSquare[fillerX, fillerY];

                    if (destX == fillerX && destY == fillerY)
                    {
                     //   myPiece = 0; //hide moved piece from bottom layer, it's not needed
                        myPiece = oldBoard[destX,destY]; //render old piece underneath capturer instead


                    }



                    boardRect[fillerX, fillerY] = new Rectangle((fillerX * (resolution / 8)) - (resolution / 8), (fillerY * -(resolution / 8)) + resolution, (resolution / 8), (resolution / 8));

                    if ((fillerX + fillerY) % 2 == 1)
                    {
                        g.FillRectangle(LBrush, boardRect[fillerX, fillerY]);

                    }
                    else
                    {
                        g.FillRectangle(DBrush, boardRect[fillerX, fillerY]);
                    }

                    if (Interface.selX == fillerX && Interface.selY == fillerY)
                    {

                        g.FillRectangle(YBrush, boardRect[fillerX, fillerY]);
                    }


                    if (myPiece > 0 && myPiece < 13)
                    {

                        g.DrawImage(piece[myPiece], boardRect[fillerX, fillerY]);

                    }

                }
            }
            
            int animStartX = (destX * (resolution / 8)) - (resolution / 8);
            int animStartY = (destY * -(resolution / 8)) + resolution;
            int animEndX = (sourceX * (resolution / 8)) - (resolution / 8);
            int animEndY = (sourceY * -(resolution / 8)) + resolution;

          //  int animPieceX = (int)(animStartX + ((animEndX - animStartX) * 0.1 * frame));
          //  int animPieceY = (int)(animStartY + ((animEndY - animStartY) * 0.1 * frame));

            int animPieceX = (int)(animEndX + ((animStartX - animEndX) * 0.1 * frame));
            int animPieceY = (int)(animEndY + ((animStartY - animEndY) * 0.1 * frame));

            Rectangle animatedRect = new Rectangle(animPieceX, animPieceY, (resolution / 8), (resolution / 8));
            int animPieceID = board.boardSquare[destX, destY];
            g.DrawImage(piece[animPieceID], animatedRect); 

            return Bmp;
        }





        public static Bitmap renderCapturesBar()
        {
            Bitmap capturesBar = new Bitmap((resolution/8), resolution);
            using (Graphics gr = Graphics.FromImage(capturesBar))
            {
                Rectangle backRect = new Rectangle(0, 0, (resolution / 8), resolution);
                SolidBrush bg = new SolidBrush(renderer.themeColorLight);
                if (chess2.Properties.Settings.Default.darkMode)
                {
                    bg = new SolidBrush(renderer.themeColorDark);
                }
                SolidBrush darkBrush = new SolidBrush(renderer.themeColorDark);
                gr.FillRectangle(bg, backRect);

                int[] piecesCaptured = new int[13];
                int[] piecesSupposedToBeThere = new int[13];
                int totalPiecesCaptured = 32;
                piecesCaptured[1] = 0;
                piecesCaptured[2] = 0;
                piecesCaptured[3] = 0;
                piecesCaptured[4] = 0;
                piecesCaptured[5] = 0;
                piecesCaptured[6] = 0;
                piecesCaptured[7] = 0;
                piecesCaptured[8] = 0;
                piecesCaptured[9] = 0;
                piecesCaptured[10] = 0;
                piecesCaptured[11] = 0;
                piecesCaptured[12] = 0;


                piecesSupposedToBeThere[1] = 8;
                piecesSupposedToBeThere[2] = 2;
                piecesSupposedToBeThere[3] = 2;
                piecesSupposedToBeThere[4] = 2;
                piecesSupposedToBeThere[5] = 1;
                piecesSupposedToBeThere[6] = 1;
                piecesSupposedToBeThere[7] = 8;
                piecesSupposedToBeThere[8] = 2;
                piecesSupposedToBeThere[9] =2;
                piecesSupposedToBeThere[10] = 2;
                piecesSupposedToBeThere[11] = 1;
                piecesSupposedToBeThere[12] = 1;


                for (int fillerX = 1; fillerX < 9; fillerX++)
                {
                    for (int fillerY = 1; fillerY < 9; fillerY++)
                    {
                        if (board.boardSquare[fillerX, fillerY] > 0)
                        {

                            piecesCaptured[board.boardSquare[fillerX, fillerY]] += 1;
                            totalPiecesCaptured += 0-1;
                        }
                    }
                    
                }
                for (int scanLoop = 1; scanLoop < 13; scanLoop++)
                {
                    piecesCaptured[scanLoop] = piecesSupposedToBeThere[scanLoop] - piecesCaptured[scanLoop];
                    Debug.WriteLine("missing: " + piecesCaptured[scanLoop]);
                }

                for (int renderPiece = 1; renderPiece <= (totalPiecesCaptured); renderPiece++)
                {
                    int rectPosition = ((resolution / (totalPiecesCaptured+1))*renderPiece)-((resolution / 16));
                    Rectangle pieceRect = new Rectangle(0,rectPosition, (resolution / 8), (resolution / 8));
                   int pieceToRender = 0;
                    for (int scanLoop = 1; scanLoop < 13; scanLoop++)
                    {
                        if (piecesCaptured[scanLoop]>0)
                        {
                            pieceToRender = scanLoop;
                        }
                    }
                    piecesCaptured[pieceToRender] += 0 - 1;

                    //    gr.FillRectangle(darkBrush, pieceRect);
                    gr.DrawImage(piece[pieceToRender], pieceRect);
                }


                }

            return capturesBar;

        }

       


        public int test1()
        {

            return (1);

        }


    }
}
