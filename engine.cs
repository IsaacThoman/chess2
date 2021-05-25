using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class engine
    {

        


        public static int[] findLegalMove(bool whitesMove) {
            int[] myMap = new int[5];

            int counter = 0;
            int[] fromX = new int[1024];
            int[] fromY = new int[1024];
            int[] toX = new int[1024];
            int[] toY = new int[1024];
            int bestScore = -9999;
            int bestIndex = 0;

            for (int scannerSourceX = 1; scannerSourceX <= 8; scannerSourceX++)
            {
                for (int scannerSourceY = 1; scannerSourceY <= 8; scannerSourceY++)
                {
                    for (int scannerDestX = 1; scannerDestX <= 8; scannerDestX++)
                    {
                        for (int scannerDestY = 1; scannerDestY <= 8; scannerDestY++)
                        {
                            if (rulebook.checkLegality(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, whitesMove))
                            {
                                counter += 1;
                                fromX[counter] = scannerSourceX;
                                fromY[counter] = scannerSourceY;
                                toX[counter] = scannerDestX;
                                toY[counter] = scannerDestY;

                                int[,] testingBoard = new int[9,9];
                                testingBoard = board.boardSquareReversed;

                         

                                if (testingBoard[scannerDestX, scannerDestY] > 0)
                                {
                                    testingBoard[scannerDestX, scannerDestY] = 0;
                                }
                                int toPiece = testingBoard[scannerSourceX, scannerSourceY];
                                int fromPiece = testingBoard[scannerDestX, scannerDestY];

                                engine.boardEvaluation(testingBoard);

                                int myScore = 


                            }

                        }
                    }
                }
            }



            var rand = new Random();
            int selection = rand.Next(counter);

            myMap[1] = fromX[selection];
            myMap[2] = fromY[selection];
            myMap[3] = toX[selection];
            myMap[4] = toY[selection];

            return myMap;


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
