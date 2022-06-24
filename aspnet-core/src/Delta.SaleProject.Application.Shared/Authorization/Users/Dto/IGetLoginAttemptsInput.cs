using Abp.Application.Services.Dto;

namespace Delta.SaleProject.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}