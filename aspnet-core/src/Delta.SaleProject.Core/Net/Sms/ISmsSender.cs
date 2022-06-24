using System.Threading.Tasks;

namespace Delta.SaleProject.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}