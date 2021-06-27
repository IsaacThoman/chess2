using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class rulebook
    {
        public static bool checkDetectionEnabled = false;
        public static bool checkLegality(int sourceX, int sourceY, int destinationX, int destinationY, int[,] boardToUse,bool checkDetection)
        {
            if (checkDetection&&checkDetectionEnabled)
            {
                int[,] thisBranchBoard = new int[9, 9];
                for (int copyX = 1; copyX <= 8; copyX++)
                {
                    for (int copyY = 1; copyY <= 8; copyY++)
                    {
                        thisBranchBoard[copyX, copyY] = boardToUse[copyX, copyY];
                    }
                }
                int fromValue2 = thisBranchBoard[sourceX, sourceY];
                int toValue2 = thisBranchBoard[destinationX, destinationY];

                if (toValue2 > 0)
                {
                    toValue2 = 0;
                }

                thisBranchBoard[destinationX, destinationY] = fromValue2;
                thisBranchBoard[sourceX, sourceY] = toValue2;

                for (int scannerSourceX = 1; scannerSourceX <= 8; scannerSourceX++)
                {
                    for (int scannerSourceY = 1; scannerSourceY <= 8; scannerSourceY++)
                    {
                        for (int scannerDestX = 1; scannerDestX <= 8; scannerDestX++)
                        {
                            for (int scannerDestY = 1; scannerDestY <= 8; scannerDestY++)
                            {
                                if (rulebook.checkOtherLegalities(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, board.boardSquareReversed(thisBranchBoard)))
                                {
                                    if (thisBranchBoard[9 - scannerDestX, 9 - scannerDestY] == 6)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }

            }
                                if (checkOtherLegalities(sourceX, sourceY, destinationX, destinationY, boardToUse))
            {
                return true;
            }
            return false;
        }


        public static bool checkOtherLegalities(int sourceX, int sourceY, int destinationX, int destinationY, int[,] boardToUse)
        {
            int[,] myInternalBoard = new int[9, 9];

            /*
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
            */

            myInternalBoard = boardToUse;


            if (sourceX == destinationX && sourceY == destinationY)
            {
                return false;

            }
            if (myInternalBoard[sourceX, sourceY] == 0)//pawns
            {
                return false;
            }

            if (myInternalBoard[sourceX, sourceY] == 1)//pawns
            {
                if ((sourceX + 1 == destinationX ^ sourceX - 1 == destinationX) && sourceY + 1 == destinationY) //pawn diagonal move
                {
                    if (myInternalBoard[destinationX, destinationY] > 6)
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

                if (sourceX == destinationX && 4 == destinationY && sourceY == 2)
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

                if (Math.Abs(sourceX - destinationX) != Math.Abs(sourceY - destinationY))
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

                for (int scanner = 1; scanner <= distance - 1; scanner++)
                {
                    int scannerPosX = sourceX + (scanner * scanDirX);
                    int scannerPosY = sourceY + (scanner * scanDirY);
                    if (myInternalBoard[scannerPosX, scannerPosY] > 0)
                    {
                        return false;
                    }

                }

                if (myInternalBoard[destinationX, destinationY] == 0 | myInternalBoard[destinationX, destinationY] > 6)
                {
                    return true;

                }



            }//close bishops

            if (myInternalBoard[sourceX, sourceY] == 6) //le king
            {
                if (Math.Abs(sourceX - destinationX) > 1 | Math.Abs(sourceY - destinationY) > 1)
                {
                    return false;
                }
                if (myInternalBoard[destinationX, destinationY] > 0 && myInternalBoard[destinationX, destinationY] < 7)
                {
                    return false;
                }
                return true;

            }//close king


            if (myInternalBoard[sourceX, sourceY] == 4)//do rooks
            {
                int scanDirX = 0;
                int scanDirY = 0;
                int distance = (Math.Abs(sourceX - destinationX) + Math.Abs(sourceY - destinationY));

                if (sourceX != destinationX && sourceY != destinationY)
                {
                    return false;
                }

                if (sourceX > destinationX)
                {
                    scanDirX = 0 - 1;
                }
                if (sourceX < destinationX)
                {
                    scanDirX = 1;
                }

                if (sourceY > destinationY)
                {
                    scanDirY = 0 - 1;
                }
                if (sourceY < destinationY)
                {
                    scanDirY = 1;
                }

                for (int scanner = 1; scanner <= distance - 1; scanner++)
                {
                    int scannerPosX = sourceX + (scanner * scanDirX);
                    int scannerPosY = sourceY + (scanner * scanDirY);
                    if (myInternalBoard[scannerPosX, scannerPosY] > 0)
                    {
                        return false;
                    }

                }
                if (myInternalBoard[destinationX, destinationY] > 6 | myInternalBoard[destinationX, destinationY] < 1)
                {
                    return true;
                }


                // return true;
            }
            if (myInternalBoard[sourceX, sourceY] == 5) //le queen
            {
                if (sourceX == destinationX | destinationY == sourceY)
                {
                    //rook
                    int scanDirX = 0;
                    int scanDirY = 0;
                    int distance = (Math.Abs(sourceX - destinationX) + Math.Abs(sourceY - destinationY));

                    if (sourceX != destinationX && sourceY != destinationY)
                    {
                        return false;
                    }

                    if (sourceX > destinationX)
                    {
                        scanDirX = 0 - 1;
                    }
                    if (sourceX < destinationX)
                    {
                        scanDirX = 1;
                    }

                    if (sourceY > destinationY)
                    {
                        scanDirY = 0 - 1;
                    }
                    if (sourceY < destinationY)
                    {
                        scanDirY = 1;
                    }

                    for (int scanner = 1; scanner <= distance - 1; scanner++)
                    {
                        int scannerPosX = sourceX + (scanner * scanDirX);
                        int scannerPosY = sourceY + (scanner * scanDirY);
                        if (myInternalBoard[scannerPosX, scannerPosY] > 0)
                        {
                            return false;
                        }

                    }
                    if (myInternalBoard[destinationX, destinationY] > 6 | myInternalBoard[destinationX, destinationY] < 1)
                    {
                        return true;
                    }


                    //return true;
                    //close rook
                }

                if (Math.Abs(sourceX - destinationX) == Math.Abs(sourceY - destinationY))
                {
                    //bishop
                    int distance = Math.Abs(sourceX - destinationX);
                    int scanDirX = 0;
                    int scanDirY = 0;

                    if (Math.Abs(sourceX - destinationX) != Math.Abs(sourceY - destinationY))
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

                    for (int scanner = 1; scanner <= distance - 1; scanner++)
                    {
                        int scannerPosX = sourceX + (scanner * scanDirX);
                        int scannerPosY = sourceY + (scanner * scanDirY);
                        if (myInternalBoard[scannerPosX, scannerPosY] > 0)
                        {
                            return false;
                        }

                    }

                    if (myInternalBoard[destinationX, destinationY] == 0 | myInternalBoard[destinationX, destinationY] > 6)
                    {
                        return true;

                    }
                    //close bishop inside queen
                }



                return false;
            }//close queen


            if (myInternalBoard[sourceX, sourceY] == 3)
            {
                int changeX = Math.Abs(sourceX - destinationX);
                int changeY = Math.Abs(sourceY - destinationY);

                if ((changeX == 1 && changeY == 2) | (changeX == 2 && changeY == 1))
                {
                    if (myInternalBoard[destinationX, destinationY] > 6 | myInternalBoard[destinationX, destinationY] == 0)
                    {
                        return true;

                    }

                }


            }




            return false;
        }
    }

    }

