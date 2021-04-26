using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    public class board
    {
        private static int[,] boardSquaresInternal = new int[9, 9];

        public void resetBoard()
        {
            //white rooks
            boardSquare[1, 1] = 4;
            boardSquare[8, 1] = 4;
            //black rooks
            boardSquare[1, 8] = 10;
            boardSquare[8, 8] = 10;
            //white knights
            boardSquare[2, 1] = 3;
        boardSquare[7, 1] = 3;
            //black knights
            boardSquare[2, 8] = 9;
            boardSquare[7, 8] = 9;
            //white bishops
            boardSquare[3, 1] = 2;
            boardSquare[6, 1] = 2;
            //black bishops
            boardSquare[3, 8] = 8;
        boardSquare[6, 8] = 8;
            //kings
            boardSquare[4, 1] = 5;
        boardSquare[4, 8] = 11;
            //queens
            boardSquare[5, 1] = 6;
        boardSquare[5, 8] = 12;

        }

        public static int[,] boardSquare
        {
            get { return boardSquaresInternal; }
            set { boardSquaresInternal = value; }
        }


    }


}
