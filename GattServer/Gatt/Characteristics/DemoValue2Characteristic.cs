using DBus;
using System.Collections.Generic;

namespace GattServer
{
    public class DemoValue2Characteristic : Characteristic
    {    
        private static string UUID = "00000004-1000-2000-3000-111122223333";
        public DemoValue2Characteristic(Bus bus, int index, Service service) : base(bus, index, UUID, new[] { "read" }, service) { }

        public override byte[] ReadValue(IDictionary<string, object> options)
        {
            return value;
        }
    }
}
