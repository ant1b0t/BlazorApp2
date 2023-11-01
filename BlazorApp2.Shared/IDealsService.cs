
namespace BlazorApp2.Shared
{
    public interface IDealsService
    {
        Deal GetDeal();
        bool RunningOnClient();
    }
}