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


        public static void setSelection(int x, int y)
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

            }
            get
            {
                return (intselY);
            }

        }

    }


}
