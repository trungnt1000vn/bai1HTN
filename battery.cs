using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class battery
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
}
