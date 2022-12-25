using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class MobileDevice
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
}
