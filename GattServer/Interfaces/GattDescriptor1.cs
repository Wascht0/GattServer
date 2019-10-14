using DBus;

namespace GattServer.Interfaces
{
    [Interface("org.bluez.GattDescriptor1")]
    public interface GattDescriptor1
    {
        byte[] ReadValue();
        void WriteValue(byte[] value);
    }
}
