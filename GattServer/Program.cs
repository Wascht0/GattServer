using System;
using System.Threading;
using GattServer.Interfaces;

namespace GattServer
{
    class Program
    {

        private static int tries = 5;

        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Random rnd = new Random();

            Console.WriteLine("######## Bluez Gatt-Server ############");
            Console.WriteLine("# Simple Gatt-Server for Raspberry Pi #");
            Console.WriteLine("#######################################");

            Console.WriteLine("[INFO] Create Connection to DBus and create new service \"org.GattServer\"");
            DBusConnection connection = new DBusConnection("org.GattServer");
            Application app = new Application(connection.System, "/org/bluez");
            app.AddService(new DemoService(connection.System, 0));

            MainAdvertisement ad = new MainAdvertisement(connection.System, 0);

            BluezServices bluezServices = new BluezServices(connection);

            if (bluezServices.IsLowEnergySupported())
            {
                Console.WriteLine("[INFO] Bluetooth LE supported");
                bluezServices.SetDiscoverable(true);
                bluezServices.RegisterApplication(app);

                Console.WriteLine("[INFO] Register advertisement");
                while (tries > 0)
                {
                    try
                    {
                        bluezServices.RegisterAdvertisement(ad);
                    }
                    catch
                    {
                        tries--;
                    }
                }
            }

            while (true)
            {
                var DemoValue1 = rnd.Next(1, 100).ToString();
                var DemoValue2 = rnd.Next(100, 1000).ToString();

                Characteristic demoVal1 = app.services[0].characteristics[1];
                Characteristic demoVal2 = app.services[0].characteristics[2];
                demoVal1.Set(typeof(GattCharacteristic1).DBusInterfaceName(), "Value", DemoValue1);
                demoVal2.Set(typeof(GattCharacteristic1).DBusInterfaceName(), "Value", DemoValue2);
                Console.WriteLine("DemoValue1: " + DemoValue1 + " DemoValue2: " + DemoValue2);

                Thread.Sleep(1000);
            }
        }
    }
}
