using System.Collections.Generic;
using Delta.SaleProject.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Delta.SaleProject.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
