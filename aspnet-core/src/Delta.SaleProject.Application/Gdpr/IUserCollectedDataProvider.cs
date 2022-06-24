using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Delta.SaleProject.Dto;

namespace Delta.SaleProject.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
