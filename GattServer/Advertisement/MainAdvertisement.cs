using DBus;

namespace GattServer
{
    class MainAdvertisement : Advertisement
    {

        public MainAdvertisement(Bus bus, int index) : base(bus, index, "peripheral")
        {
            AddServiceUUID("00000001-1000-2000-3000-111122223333");
            IncludeTxPower = false;
        }
    }
}
