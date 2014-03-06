using System.Net.NetworkInformation;

namespace Macsauto.Infrastructure.Helper.Client
{
    public class MacAdapter
    {
        public string GetCurrentClientAddress()
        {
            var macAddress = string.Empty;

            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (macAddress == string.Empty)
                {
                    macAddress = networkInterface.GetPhysicalAddress().ToString();
                }
            }

            return macAddress;
        }
    }
}