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
            int[,] myInternalBoard = new int[9, 9];

            if (whitesMove)
            {
                myInternalBoard = board.boardSquare;
            }
            else
            {
                myInternalBoard = board.boardSquareReversed;
                sourceX = 9 - sourceX;
                sourceY = 9 - sourceY;

                destinationX = 9-destinationX;
                destinationY = 9-destinationY;

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

                if(sourceX==destinationX && sourceY + 2 == destinationY)
                {
                    if (myInternalBoard[destinationX, sourceY + 2] == 0 && myInternalBoard[destinationX, sourceY + 1] == 0)
                    {
                        return true;

                    }

                }
            }//close pawns

            if (myInternalBoard[sourceX, sourceY] == 2)//bishops
            {
                int distance = Math.Abs(sourceX - destinationX);
                int scanDirX = 0;
                int scanDirY = 0;

                if(Math.Abs(sourceX-destinationX) != Math.Abs(sourceY - destinationY))
                {
                    return false;

                }

                if (sourceX > destinationX)
                {
                    scanDirX = 0 - 1;
                }
                else
                {
                    scanDirX = 1;
                }

                if (sourceY > destinationY)
                {
                    scanDirY = 0 - 1;
                }
                else
                {
                    scanDirY = 1;
                }

                for (int depth = 1; depth <= distance; depth++)
                {

                    if (myInternalBoard[sourceX + (depth * scanDirX), sourceY + (depth * scanDirY)]>0)
                    {
                        return false;

                    }

                    return true;
                }
            }//close bishops


                return false;
        }


    }
}
