namespace FTB
{
    enum type { Ethernet, token };
    internal class NetworkCard
    {
        int manufacture;
        string macAddress;
        type machineType;
         NetworkCard(int _manufact,string _address,int _type)
        {
            manufacture = _manufact;
            macAddress = _address;
            machineType = (type)_type;

        }

        public static NetworkCard NC { get; } = new NetworkCard(1,"123.56.5",0);

        public override string ToString()
        {
            return $"{manufacture}: {macAddress}: {machineType}";
        }
    }
}
