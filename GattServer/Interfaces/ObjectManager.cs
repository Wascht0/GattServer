using DBus;
using System.Collections.Generic;

namespace GattServer.Interfaces
{
    [Interface("org.freedesktop.DBus.ObjectManager")]
    interface ObjectManager
    {
        [return: Argument("objects")]
        IDictionary<ObjectPath, IDictionary<string, IDictionary<string, object>>> GetManagedObjects();
    }
}
