using DBus;
using System.Collections.Generic;

namespace GattServer.Interfaces
{
    [Interface("org.bluez.GattManager1")]
    interface GattManager1
    {
        void RegisterApplication(ObjectPath application, IDictionary<string, object> options);
        void UnregisterApplication(ObjectPath application);
    }
}
