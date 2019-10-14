using DBus;
using System.Collections.Generic;

namespace GattServer
{
    public class DemoConfigurationCharacteristic : Characteristic
    {    
        private static string UUID = "00000002-1000-2000-3000-111122223333";
        public DemoConfigurationCharacteristic(Bus bus, int index, Service service) : base(bus, index, UUID, new[] { "read" }, service)
        {
            byte[] configFlags = { 0b00000000 };
            value = configFlags;
        }

        public override byte[] ReadValue(IDictionary<string, object> options)
        {
            return value;
        }
    }
}
