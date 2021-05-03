using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class Interface
    {
        private static int intselX = 0;
        private static int intselY = 0;
        private static bool firstSel = true;
        public static bool whitesMove = true;
        public static bool againstBot = false;
        public static bool againstLocal = false;
        public static bool againstOnline = false;
        

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

                if (rulebook.checkLegality(intselX, intselY, x, y,whitesMove))
                {
                    if (toSquareValue != 0)
                    {
                        toSquareValue = 0; //I wasn't paying attention when writing this, it seems to work but it might be awful
                    }
                    board.boardSquare[intselX, intselY] = toSquareValue;
                    board.boardSquare[x, y] = fromSquareValue;




                    if (whitesMove)
                    {
                        whitesMove = false;

                if(againstBot){
                                    //do engine stuff?
                        int[] poo = engine.findLegalMove(false);
        int fromValue = board.boardSquare[poo[1], poo[2]];
        int toValue = board.boardSquare[poo[3], poo[4]];

                        if (toValue != 0)
                        {
                            toValue = 0; //I wasn't paying attention when writing this, it seems to work but it might be awful
                        }
    board.boardSquare[poo[1], poo[2]] = toValue;
                        board.boardSquare[poo[3], poo[4]] = fromValue;
                        Debug.WriteLine(poo[1]);
                        Debug.WriteLine(poo[2]);
                        Debug.WriteLine(poo[3]);
                        Debug.WriteLine(poo[4]);
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
