using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class rulebook
    {
        
        public static bool checkLegality(int sourceX, int sourceY, int destinationX,int destinationY, bool whitesMove)
        {
            int[,] myInternalBoard = new int[9,9];

            if (whitesMove)
            {
                myInternalBoard = board.boardSquare; 
            }
            else
            {
                myInternalBoard = board.boardSquareReversede;
            }


            if (myInternalBoard[sourceX,sourceY] == 1)//pawns
            {
            if((sourceX+1==destinationX^ sourceX - 1 == destinationX) &&sourceY+1 == destinationY) //pawn diagonal move
                {
                    if (myInternalBoard[destinationX, destinationY]>6)
                    {

                        return true;
                    }
                }

                if (sourceX == destinationX && sourceY + 1 == destinationY) //pawn forward
                {
                    if (myInternalBoard[destinationX, destinationY] == 0)//make sure square is empty
                    {
                        return true;

                    }

                }
            }//close pawns




            return false;
        }


    }
}
