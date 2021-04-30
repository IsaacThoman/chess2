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
                                myMap[1] = scannerSourceX;
                                myMap[2] = scannerSourceY;
                                myMap[3] = scannerDestX;
                                myMap[4] = scannerDestY;
                            }

                        }
                    }
                }
            }
            return myMap;


        }


        }
}
