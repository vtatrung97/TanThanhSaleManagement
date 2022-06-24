using System.Collections.Generic;
using Delta.SaleProject.Authorization.Users.Dto;
using Delta.SaleProject.Dto;

namespace Delta.SaleProject.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}