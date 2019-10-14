using DBus;

namespace GattServer.Interfaces
{
    [Interface("org.bluez.LEAdvertisement1")]
    public interface LEAdvertisement1
    {
        void Release();
    }
}
