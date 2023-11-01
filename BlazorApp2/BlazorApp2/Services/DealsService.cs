using BlazorApp2.Shared;

namespace BlazorApp2.Services
{
    public class DealsService : IDealsService
    {
        public Deal GetDeal()
        {
            return new Deal(1, "gj");
        }

        public bool RunningOnClient()
        {
            return false;
        }
    }
}
