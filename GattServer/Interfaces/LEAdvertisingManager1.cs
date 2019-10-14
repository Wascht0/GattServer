using DBus;
using System.Collections.Generic;

namespace GattServer.Interfaces
{
    [Interface("org.bluez.LEAdvertisingManager1")]
    interface LEAdvertisingManager1
    {
        void RegisterAdvertisement(ObjectPath advertisement, IDictionary<string, object> options);
        void UnregisterAdvertisement(ObjectPath service);
    }
}
