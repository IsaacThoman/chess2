using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class engine
    {

        public static bool[,,,] mapLegalMoves(bool whitesMove) //sorry there's no input for this, can't really pass anything into the rulebook :/
        {
            bool[,,,] myMap = new bool[9, 9, 9, 9];

            for (int scannerSourceX = 1; scannerSourceX <= 8; scannerSourceX++)
            {
                for (int scannerSourceY = 1; scannerSourceY <= 8; scannerSourceY++)
                {
                    for (int scannerDestX = 1; scannerDestX <= 8; scannerDestX++)
                    {
                        for (int scannerDestY = 1; scannerDestY <= 8; scannerDestY++)
                        {

    myMap[scannerSourceX, scannerSourceY, scannerDestX, scannerDestY] = rulebook.checkLegality(scannerSourceX, scannerSourceY, scannerDestX, scannerDestY, whitesMove);

                        }

                    }
                }
            }


            return myMap;
        }


        public static int[] findLegalMove(bool whitesMove) {
            int[] myMap = new int[5];

            int counter = 0;
            int[] fromX = new int[1024];
            int[] fromY = new int[1024];
            int[] toX = new int[1024];
            int[] toY = new int[1024];


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

     




        }
}
