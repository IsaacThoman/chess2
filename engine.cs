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
            int[] fromX = new int[1024];
            int[] fromY = new int[1024];
            int[] toX = new int[1024];
            int[] toY = new int[1024];
            int bestScore = 1000;
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

                            int[,] thingNotToBreak = new int[9, 9];
                            for (int copyX = 1; copyX <= 8; copyX++)
                            {
                                for (int copyY = 1; copyY <= 8; copyY++)
                                {

                                    thingNotToBreak[copyX, copyY] = board.boardSquare[copyX, copyY];
                                }
                            }

                            if (rulebook.checkLegality(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, board.boardSquareReversed)) //false used to be whites move, seems stupid
                            {



                                counter += 1;
                                fromX[counter] = 9-scannerSourceX;
                                fromY[counter] = 9-scannerSourceY;
                                toX[counter] = 9-scannerDestX;
                                toY[counter] = 9-scannerDestY;





                                int myfromValue = thingNotToBreak[scannerSourceX, scannerSourceY];
                                int mytoValue = thingNotToBreak[scannerDestX, scannerDestY];

                                if (mytoValue != 0)
                                {
                                    mytoValue = 0;
                                }

                                thingNotToBreak[scannerDestX, scannerDestY] = mytoValue;
                                thingNotToBreak[scannerSourceX, scannerSourceY] = myfromValue;


                                int myScore = engine.boardEvaluation(thingNotToBreak);

                                moveIndex[counter] = myScore;

                                if (bestTemp < myScore)
                                {
                                    bestTemp = myScore;
                                    maxIndex = counter;
                                }


                            }

                        }
                    }
                }
            }





            
            int fromValue = board.boardSquare[fromX[maxIndex], fromY[maxIndex]];
            int toValue = board.boardSquare[toX[maxIndex], toY[maxIndex]];

            if (toValue > 0)
            {
                toValue = 0;
            }

            board.boardSquare[toX[maxIndex], toY[maxIndex]] = fromValue;
            board.boardSquare[fromX[maxIndex], fromY[maxIndex]] = toValue;
            




            var rand = new Random();
            //  int selection = rand.Next(counter);
            int selection = maxIndex;
            Debug.WriteLine("-------------------");
            Debug.WriteLine("Best index: "+ maxIndex);
            Debug.WriteLine("Moves checked: " + counter);
            Debug.WriteLine("Current Score: " + engine.boardEvaluation(board.boardSquare));



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
