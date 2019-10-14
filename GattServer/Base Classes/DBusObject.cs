using DBus;
using System.Collections.Generic;

namespace GattServer.Base_Classes
{
    public class DBusObject
    {
        public string basePath;

        public virtual ObjectPath GetPath()
        {
            return new ObjectPath(basePath);
        }

        public static ObjectPath[] GetChildPaths(IList<DBusObject> children)
        {
            List<ObjectPath> response = new List<ObjectPath>();

            foreach (DBusObject child in children)
            {
                response.Add(child.GetPath());
            }

            return response.ToArray();
        }
    }
}
