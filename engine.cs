using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class engine
    {

        


        public static void findLegalMove() {
            int[] myMap = new int[5];

            int counter = 0;
            int fromX = 5;
            int fromY = 5;
            int toX = 6;
            int toY = 6;
            int bestScore = -10000;
            int[] moveIndex = new int[1024];


            int bestTemp = 0-9999;
            int maxIndex = 0;




            for (int scannerSourceX = 1; scannerSourceX <= 8; scannerSourceX++)
            {
                for (int scannerSourceY = 1; scannerSourceY <= 8; scannerSourceY++)
                {
                    for (int scannerDestX = 1; scannerDestX <= 8; scannerDestX++)
                    {
                        for (int scannerDestY = 1; scannerDestY <= 8; scannerDestY++)
                        {

                            if (rulebook.checkLegality(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, board.boardSquareReversed(board.boardSquare)))
                            {//testing code
                                int thisMoveScore = getMoveTree(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, board.boardSquareReversed(board.boardSquare));
                                if (bestScore <= thisMoveScore)
                                {
                                    bestScore = thisMoveScore;
                                    fromX = scannerSourceX;
                                        fromY = scannerSourceY;
                                        toX = scannerDestX;
                                        toY = scannerDestY;
                                    Debug.WriteLine("Difference seen??"+ thisMoveScore);
                                }

                            }

                            

                        }
                    }
                }
            }





            
            int fromValue = board.boardSquare[9-fromX, 9-fromY];
            int toValue = board.boardSquare[9-toX, 9-toY];

            if (toValue > 0)
            {
                toValue = 0;
            }

            board.boardSquare[9-toX, 9-toY] = fromValue;
            board.boardSquare[9-fromX, 9-fromY] = toValue;
            Debug.WriteLine("move " + (9-fromX) + "," + (9-fromY)+"to " + (9-toX) + "," + (9-toY));




            var rand = new Random();
            //  int selection = rand.Next(counter);
            int selection = maxIndex;
        //    Debug.WriteLine("-------------------");
       //     Debug.WriteLine("Best index: "+ maxIndex);
       //     Debug.WriteLine("Moves checked: " + counter);
        //    Debug.WriteLine("Current Score: " + engine.boardEvaluation(board.boardSquare));



        }

        public static int getMoveTree(int sourceX,int SourceY, int destX, int destY, int[,]inputBoard)
        {
            int treeScore = 0;

            int[,] thisBranchBoard = new int[9, 9];
            for (int copyX = 1; copyX <= 8; copyX++)
            {
                for (int copyY = 1; copyY <= 8; copyY++)
                {
                    thisBranchBoard[copyX, copyY] = inputBoard[copyX, copyY];
                }
            }
            int fromValue2 = thisBranchBoard[sourceX, SourceY];
            int toValue2 = thisBranchBoard[destX, destY];

            if (toValue2 > 0)
            {
                toValue2 = 0;
            }

            thisBranchBoard[destX, destY] = fromValue2;
            thisBranchBoard[sourceX, SourceY] = toValue2;



            for (int currentDepth = 1; currentDepth <= 25; currentDepth++)
            {

                for (int scannerSourceX = 1; scannerSourceX <= 8; scannerSourceX++)
                {
                    for (int scannerSourceY = 1; scannerSourceY <= 8; scannerSourceY++)
                    {
                        for (int scannerDestX = 1; scannerDestX <= 8; scannerDestX++)
                        {
                            for (int scannerDestY = 1; scannerDestY <= 8; scannerDestY++)
                            {
                                if (currentDepth % 2 == 0)
                                {
                                    if (rulebook.checkLegality(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, thisBranchBoard))
                                    {
                                        int fromValue = thisBranchBoard[scannerSourceX, scannerSourceY];
                                        int toValue = thisBranchBoard[scannerDestX, scannerDestY];

                                        if (toValue > 0)
                                        {
                                            toValue = 0;
                                        }

                                        thisBranchBoard[scannerDestX, scannerDestY] = fromValue;
                                        thisBranchBoard[scannerSourceX, scannerSourceY] = toValue;
                                       // if (currentDepth == 25) { treeScore += engine.boardEvaluation(thisBranchBoard); }
                                       // Debug.WriteLine("white Moves" + scannerSourceX + "," + scannerSourceY + "to " + scannerDestX + "," + scannerDestY);

                                    }
                                }
                                else
                                {

                                    if (rulebook.checkLegality(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, board.boardSquareReversed(thisBranchBoard)))
                                    {
                                        int fromValue = thisBranchBoard[9-scannerSourceX, 9-scannerSourceY];
                                        int toValue = thisBranchBoard[9-scannerDestX, 9-scannerDestY];

                                        if (toValue > 0)
                                        {
                                            toValue = 0;
                                        }

                                        thisBranchBoard[9-scannerDestX, 9-scannerDestY] = fromValue;
                                        thisBranchBoard[9-scannerSourceX, 9-scannerSourceY] = toValue;
                                        if (currentDepth == 25) { treeScore += engine.boardEvaluation(thisBranchBoard); }
                                     //   Debug.WriteLine("black Moves" + scannerSourceX + "," + scannerSourceY + "to " + scannerDestX + "," + scannerDestY);
                                    }
                                }
                            }
                        }
                    }




                }






            }
                            return treeScore;
        }






        public static int testMove(int fromX,int fromY, int toX, int toY, int[,] boardToUse)
        {
            int[,] clearlyINeverLearnedC = new int[9, 9];
            for (int scannerSourceX = 1; scannerSourceX <= 8; scannerSourceX++)
            {
                for (int scannerSourceY = 1; scannerSourceY <= 8; scannerSourceY++)
                {
                    clearlyINeverLearnedC[scannerSourceX, scannerSourceY] = boardToUse[scannerSourceX, scannerSourceY];
                }
            }
                    int fromValue = clearlyINeverLearnedC[ fromX, fromY];
            int toValue = clearlyINeverLearnedC[ toX,  toY];

            if (toValue > 0)
            {
                toValue = 0;
            }

            clearlyINeverLearnedC[ toX,  toY] = fromValue;
            clearlyINeverLearnedC[ fromX,  fromY] = toValue;

            return (boardEvaluation(clearlyINeverLearnedC));
        }






        public static int boardEvaluation(int[,] board)
        {
            int counted = 0;
            for (int scannerSourceX = 1; scannerSourceX <= 8; scannerSourceX++)
            {
                for (int scannerSourceY = 1; scannerSourceY <= 8; scannerSourceY++)
                {
                    if (board[scannerSourceX, scannerSourceY] == 1)
                    {
                        counted += 1;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 2)
                    {
                        counted += 3;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 3)
                    {
                        counted += 3;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 4)
                    {
                        counted += 5;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 5)
                    {
                        counted += 9;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 6)
                    {
                        counted += 100;
                    }
                    //black
                    if (board[scannerSourceX, scannerSourceY] == 7)
                    {
                        counted += 0 - 1;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 8)
                    {
                        counted += 0 - 3;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 9)
                    {
                        counted += 0 - 3;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 10)
                    {
                        counted += 0 - 5;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 11)
                    {
                        counted += 0 - 9;
                    }
                    if (board[scannerSourceX, scannerSourceY] == 12)
                    {
                        counted += 0 - 100;
                    }

                }
            }

            return counted;
        }



    }
}
