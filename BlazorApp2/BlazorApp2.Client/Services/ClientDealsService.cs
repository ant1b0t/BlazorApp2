using BlazorApp2.Shared;

namespace BlazorApp2.Client.Services
{
    public class ClientDealsService : IDealsService
    {
        public Deal GetDeal()
        {
            return new Deal(1, "gj client");
        }

        public bool RunningOnClient()
        {
            return true;
        }
    }
}
