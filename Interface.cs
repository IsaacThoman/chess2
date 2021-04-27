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
        private static bool firstSel = false;

        public static void setSelection(int x, int y) //kill this.
        {
            if(x > 8 || y > 8|| x < 1 || y < 1)
            {
                return;
            }

            intselX = x;
            intselY = y;
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
