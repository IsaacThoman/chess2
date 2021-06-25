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
            int bestScore = 0;
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

                            if (rulebook.checkLegality(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, board.boardSquareReversed))
                            {//testing code
                                int[,] tester = board.boardSquareReversed;

                                int fromValuetest = tester[9 - fromX, 9 - fromY];
                                int toValuetest = tester[9 - toX, 9 - toY];

                                if (toValuetest > 0)
                                {
                                    toValuetest = 0;
                                }

                                tester[9 - toX, 9 - toY] = fromValuetest;
                                tester[9 - fromX, 9 - fromY] = toValuetest;
                                //bacf
                                if (engine.boardEvaluation(tester) <= bestScore)
                                {
                                    
                                    bestScore = (int)(engine.boardEvaluation(tester));
                                    Debug.WriteLine("Found new best: " + fromX + "," + fromY + "," + toX + "," + toY + " Score: " + bestScore);
                                    if (bestScore < 0)
                                    {
                                        fromX = scannerSourceX;
                                        fromY = scannerSourceY;
                                        toX = scannerDestX;
                                        toY = scannerDestY;
                                    }

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
            




            var rand = new Random();
            //  int selection = rand.Next(counter);
            int selection = maxIndex;
        //    Debug.WriteLine("-------------------");
       //     Debug.WriteLine("Best index: "+ maxIndex);
       //     Debug.WriteLine("Moves checked: " + counter);
        //    Debug.WriteLine("Current Score: " + engine.boardEvaluation(board.boardSquare));



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
