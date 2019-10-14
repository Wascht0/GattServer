using DBus;
using System.Collections.Generic;

namespace GattServer.Interfaces
{
    [Interface("org.bluez.GattCharacteristic1")]
    public interface GattCharacteristic1
    {
        byte[] ReadValue(IDictionary<string, object> options);
        void WriteValue(byte[] value, IDictionary<string, object> options);
        void StartNotify();
        void StopNotify();
    }
}
