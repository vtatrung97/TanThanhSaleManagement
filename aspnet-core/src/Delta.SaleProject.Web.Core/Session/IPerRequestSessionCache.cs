using System.Threading.Tasks;
using Delta.SaleProject.Sessions.Dto;

namespace Delta.SaleProject.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
