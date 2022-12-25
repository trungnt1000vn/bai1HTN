using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Call
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
            Console.WriteLine("Date : " + Date);
            Console.WriteLine("Time : " + Time);
            Console.WriteLine("PhoneNumber : " + Phonenumber);
            Console.WriteLine("Duration : " + Duration);
        }

    }
}
