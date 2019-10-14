using DBus;
using GattServer.Interfaces;
using org.freedesktop.DBus;
using System;
using System.Collections.Generic;

namespace GattServer
{
    public class Descriptor : Properties, GattDescriptor1
    {

        private string UUID;
        private Characteristic parentCharacteristic;
        private byte[] value;
        private string[] flags;

        [return: Argument("value")]
        public object Get(string @interface, string propname)
        {
            throw new NotImplementedException();
        }

        [return: Argument("props")]
        public IDictionary<string, object> GetAll(string @interface)
        {
            throw new NotImplementedException();
        }

        public ObjectPath GetPath()
        {
            return new ObjectPath("");
        }

        public byte[] ReadValue()
        {
            throw new NotImplementedException();
        }

        public void Set(string @interface, string propname, object value)
        {
            throw new NotImplementedException();
        }

        public void WriteValue(byte[] value)
        {
            throw new NotImplementedException();
        }
    }
}
