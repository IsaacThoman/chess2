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

        public static void setSelection(int x, int y) //kill this.
        {
            if(x > 8 || y > 8|| x < 1 || y < 1)
            {
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

                board.boardSquare[intselX, intselY] = toSquareValue;
                board.boardSquare[x, y] = fromSquareValue;



                intselX = 0;
                intselY = 0;
                firstSel = true;

            }


            Debug.WriteLine(x + ", " + y);

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
