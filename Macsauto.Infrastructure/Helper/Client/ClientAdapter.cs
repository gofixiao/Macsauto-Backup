namespace Macsauto.Infrastructure.Helper.Client
{
    public class ClientAdapter
    {
        private readonly MacAdapter _mac;

        public ClientAdapter(MacAdapter mac)
        {
            _mac = mac;
        }

        public string GetCurrentClientMacAddress()
        {
            return _mac.GetCurrentClientAddress();
        }
    }
}