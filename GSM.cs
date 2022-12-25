using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class GSM
    {
        battery batterygsm;
        display displaygsm;
        float totalprice;
        public List<Call> CallHistory = new List<Call>();
        static MobileDevice iPhone4S;
        public GSM()
        {

        }
        public GSM(battery batterygsm, display displaygsm)
        {
            this.batterygsm = batterygsm;
            this.displaygsm = displaygsm;
        }
        public void GSMdisplay()
        {
            Console.WriteLine("Battery Model : " + batterygsm.BatteryModel);
            Console.WriteLine("Battery idle hours : " + batterygsm.IdleHours.ToString());
            Console.WriteLine("Battery talk hours : " + batterygsm.TalkHours.ToString());
            Console.WriteLine("Display size : " + displaygsm.Size);
            Console.WriteLine("Display Color : " + displaygsm.Colors);

        }
        public void stevejobs4s()
        {
            Console.WriteLine("Model : " + iPhone4S.Model);
            Console.WriteLine("Manufacturer : " + iPhone4S.Manufacturer);
            Console.WriteLine("Price : " + iPhone4S.Price);
            Console.WriteLine("Owner : " + iPhone4S.Owner);
            Console.WriteLine("BatteryModel : " + iPhone4S.BatteryModel);
            Console.WriteLine("IdleHours : " + iPhone4S.IdleHours);
            Console.WriteLine("TalkHours : " + iPhone4S.TalkHours);
            Console.WriteLine("Size : " + iPhone4S.Size);
            Console.WriteLine("Color : " + iPhone4S.Colors);
        }
        public void addHistory(Call call)
        {
            CallHistory.Add(call);
        }
        public void deleteCall(Call call)
        {
            CallHistory.Remove(call);
        }
        public void clearCalls()
        {
            CallHistory.Clear();
        }
        public float calcuPrice(float pricetocall)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                totalprice += (CallHistory[i].Duration / 60) * pricetocall;
            }
            return totalprice;
        }
    }
}
