namespace Smart_Home_Control_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHome home = new SmartHome();

            home[DeviceType.Light].TurnOn();
            home[DeviceType.Fan].TurnOff();
            home[DeviceType.AC].TurnOn();
            home[DeviceType.Heater].TurnOff();
            home[DeviceType.Light].ShowStatus();
            home[DeviceType.Fan].ShowStatus();
            home[DeviceType.AC].ShowStatus();
            home[DeviceType.Heater].ShowStatus();
        }
    }
    enum DeviceType
    {
        Light,
        Fan,
        AC,
        Heater
    }
    interface ISmartDevice
    {
        void TurnOn();
        void TurnOff();
        void ShowStatus();
    }
    class Light : ISmartDevice
    {
        private bool On = false;

        public void TurnOn() => On = true;
        public void TurnOff() => On = false;

        public void ShowStatus() => Console.WriteLine("Light is " + (On ? "On" : "Off"));
    }
    class Fan : ISmartDevice
    {
        private bool On = false;

        public void TurnOn() => On = true;
        public void TurnOff() => On = false;

        public void ShowStatus() => Console.WriteLine("Fan is " + (On ? "On" : "Off"));
    }
    class AC : ISmartDevice
    {
        private bool On = false;

        public void TurnOn() => On = true;
        public void TurnOff() => On = false;

        public void ShowStatus() => Console.WriteLine("AC is " + (On ? "On" : "Off"));
    }
    class Heater : ISmartDevice
    {
        private bool On = false;

        public void TurnOn() => On = true;
        public void TurnOff() => On = false;

        public void ShowStatus() => Console.WriteLine("Heater is " + (On ? "On" : "Off"));
    }
    class SmartHome
    {
        private ISmartDevice[] devices = new ISmartDevice[4];

        public SmartHome()
        {
            devices[(int)DeviceType.Light] = new Light();
             devices[(int)DeviceType.Fan] = new Fan();
            devices[(int)DeviceType.AC] = new AC();
             devices[(int)DeviceType.Heater] = new Heater();
        }

        public ISmartDevice this[DeviceType type]
        {
            get { return devices[(int)type]; }
        }
    }
}
