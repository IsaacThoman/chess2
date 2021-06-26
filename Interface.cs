using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class Interface
    {
        private static int intselX = 0;
        private static int intselY = 0;
        public static bool firstSel = true;
        public static bool whitesMove = true;
        public static bool againstBot = false;
        public static bool againstLocal = false;
        public static bool againstOnline = false;

        public static bool newAnimation = false;


        public static void setSelection(int x, int y) //kill this.
        {
            if(x > 8 || y > 8|| x < 1 || y < 1) 
            {
                //can't click outside the board, buddy
                return;
            }

            if (firstSel)
            {
                intselX = x;
                intselY = y;
                firstSel = false;
            }
            else
            {
                int fromSquareValue = board.boardSquare[intselX, intselY];
                int toSquareValue = board.boardSquare[x, y];
                bool moveLegalityThing = false;

                if (whitesMove)
                {
                    moveLegalityThing = rulebook.checkLegality(intselX, intselY, x, y, board.boardSquare);
                }
                else
                {
                    moveLegalityThing = rulebook.checkLegality(9-intselX, 9-intselY, 9-x, 9-y, board.boardSquareReversed(board.boardSquare));
                }

                if (moveLegalityThing)
                {
                    if (toSquareValue != 0)
                    {
                        toSquareValue = 0; //I wasn't paying attention when writing this, it seems to work but it might be awful
                    }

                    //lazy promotion
                    if (y == 8 && fromSquareValue == 1)
                    {
                        fromSquareValue = 5;
                    }
                    if (y == 1 && fromSquareValue == 7)
                    {
                        fromSquareValue = 11;
                    }


                    board.boardSquare[intselX, intselY] = toSquareValue;
                    board.boardSquare[x, y] = fromSquareValue;




                    if (whitesMove)
                    {
                        whitesMove = false;

                if(againstBot){
                            Bitmap[] playerAnimation = renderer.renderBitmapAnimation();
                           engine.findLegalMove();
                            Bitmap[] botAnimation = renderer.renderBitmapAnimation();

                            Bitmap[] finalAnim = new Bitmap[11];

                            finalAnim[0] = playerAnimation[1];  //creates an animation before calculating next move,
                            finalAnim[1] = playerAnimation[2];  //jankily combines that with the animation created after
                            finalAnim[2] = playerAnimation[4];
                            finalAnim[3] = playerAnimation[6];
                            finalAnim[4] = playerAnimation[8];
                            finalAnim[5] = playerAnimation[10]; 

                            finalAnim[6] = botAnimation[2];
                            finalAnim[7] = botAnimation[4];
                            finalAnim[8] = botAnimation[6];
                            finalAnim[9] = botAnimation[8];
                            finalAnim[10] = botAnimation[10];

                                Form1.animation = finalAnim;
                            newAnimation = true;
                            
                            whitesMove = true;
 }

                    }
                    else
                    {
                        whitesMove = true;
                    }

                    if (againstOnline)
                    {
                        beanchat.pushBoard();
                    }

                    //Debug.WriteLine(whitesMove);

                }



                intselX = 0;
                intselY = 0;
                firstSel = true;



            }


           // Debug.WriteLine(x + ", " + y);

        }

        public static int selX
        {

            set
            {
                intselX = selX;
            }
            get
            {
                return (intselX);
            }

        }

        public static int selY
        {

            set
            {
                intselY = selY;
            }
            get
            {
                return (intselY);
            }

        }

    }


}
