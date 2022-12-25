using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
   internal class GSMCallHistoryTest
    {

        GSMCallHistoryTest(GSM gsmTest)
        {
            Call call1 = new Call("30/9/2001", "10AM", "0123456789", 2.5f);
            Call call2 = new Call("5/5/2000", "10AM", "0123456987", 3.5f);
            Call call3 = new Call("25/12/2000", "10AM", "0123456123", 5.5f);
            gsmTest.addHistory(call1);
            gsmTest.addHistory(call2);
            gsmTest.addHistory(call3);
            for (int i = 0; i < 3; i++)
            {
                gsmTest.CallHistory[i].displayCall();
            }
            gsmTest.calcuPrice(0.37f);
            gsmTest.deleteCall(call3);
            gsmTest.calcuPrice(0.37f);
            for (int i = 0; i < 3; i++)
            {
                gsmTest.CallHistory[i].displayCall();
            }
            gsmTest.clearCalls();
        }


    }
}
