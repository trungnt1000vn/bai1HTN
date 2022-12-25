using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class GSMTest
    {
        GSM[] gsmArray = new GSM[3];
        GSMTest()
        {
        }
        public void displayGSMtest()
        {
            for (int i = 0; i < 3; i++)
            {
                gsmArray[i].GSMdisplay();
            }
        }
        public void displayiPhone4s()
        {
            for (int i = 0; i < 3; i++)
            {
                gsmArray[i].stevejobs4s();
            }
        }
    }
}
