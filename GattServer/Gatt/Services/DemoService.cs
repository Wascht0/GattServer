using DBus;

namespace GattServer
{
    public class DemoService : Service
    {
        public static string uuid = "00000001-1000-2000-3000-111122223333";
        public DemoService(Bus bus, int index) : base(bus, index, uuid, true)
        {
            AddCharacteristic(new DemoConfigurationCharacteristic(bus, 0, this));
            AddCharacteristic(new DemoValue1Characteristic(bus, 1, this));
            AddCharacteristic(new DemoValue2Characteristic(bus, 2, this));
        }
    }
}
