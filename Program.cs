using System;
using System.Collections.Generic;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class MobileDevice
    {
        string model = null;
        string manufacturer = null;
        float price = 0;
        string owner = null;
        string batteryModel = null;
        float idleHours = 0;
        float talkHours = 0;
        float size = 0;
        int colors = 0;

        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public float Price { get => price; set => price = value; }
        public string Owner { get => owner; set => owner = value; }
        public string BatteryModel { get => batteryModel; set => batteryModel = value; }
        public float IdleHours { get => idleHours; set => idleHours = value; }
        public float TalkHours { get => talkHours; set => talkHours = value; }
        public float Size { get => size; set => size = value; }
        public int Colors { get => colors; set => colors = value; }

        public MobileDevice()
        {

        }
        public MobileDevice(string model, string manufacturer, float price, string owner, string batteryModel, float idleHours, float talkHours, float size, int colors)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.batteryModel = batteryModel;
            this.idleHours = idleHours;
            this.talkHours = talkHours;
            this.size = size;
            this.colors = colors;
        }
         public MobileDevice(string model, string manufacturer, float price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
         public MobileDevice(string model, string manufacturer, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
        }
        public MobileDevice(string model, string manufacturer, int colors)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.colors = colors;
        }

    }
    class battery
    {
        private string batteryModel;
        private float idleHours;
        private float talkHours;
        private string batterytype;
        public string BatteryModel { get => batteryModel; set => batteryModel = value; }
        public float IdleHours { get => idleHours; set => idleHours = value; }
        public float TalkHours { get => talkHours; set => talkHours = value; }
        public string Batterytype { get => batterytype; set => batterytype = value; }

        public battery()
        {

        }
        public battery(string batteryModel, float idleHours, float talkHours)
        {
            this.batteryModel = batteryModel;
            this.idleHours = idleHours;
            this.talkHours = talkHours;
        }
        public battery(string batteryModel, float idleHours)
        {
            this.batteryModel = batteryModel;
            this.idleHours = idleHours;
        }
    }
    class display
    {
        private float size;
        private int colors;

        public float Size { get => size; set => size = value; }
        public int Colors { get => colors; set => colors = value; }

        public display(float size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }
        public display()
        {

        }
        public display(float size)
        {
            this.size = size;
        }
        public display(int colors)
        {
            this.colors = colors;
        }
    }
    class GSM
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
            for(int i = 0; i < CallHistory.Count; i++)
            {
                totalprice+=(CallHistory[i].Duration/60) * pricetocall;
            }
            return totalprice;
        }
    }
    class GSMCallHistoryTest
    {   

        GSMCallHistoryTest(GSM gsmTest)
        {
            Call call1 = new Call("30/9/2001","10AM","0123456789", 2.5f);
            Call call2 = new Call("5/5/2000","10AM","0123456987", 3.5f);
            Call call3 = new Call("25/12/2000","10AM","0123456123", 5.5f);
            gsmTest.addHistory(call1);
            gsmTest.addHistory(call2);
            gsmTest.addHistory(call3);
            for(int i = 0; i < 3; i++)
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
    class Call
    {
        GSM gsmCalling;
        string date;
        string time;
        string phonenumber;
        float duration;

        public Call(string date, string time, string phonenumber, float duration)
        {
            this.date = date;
            this.time = time;
            this.phonenumber = phonenumber;
            this.duration = duration;
        }

        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public float Duration { get => duration; set => duration = value; }
        public void displayCall()
        {
            Console.WriteLine("Date : " +Date);
            Console.WriteLine("Time : "+ Time);
            Console.WriteLine("PhoneNumber : "+Phonenumber);
            Console.WriteLine("Duration : "+ Duration);
        }

    }
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }
}
