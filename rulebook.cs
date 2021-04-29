using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class rulebook
    {

        public static bool checkLegality(int sourceX, int sourceY, int destinationX,int destinationY)
        {
            if (board.boardSquare[sourceX, sourceY] == 0)
            {
        return false;
            }

            return true;

        }


    }
}
