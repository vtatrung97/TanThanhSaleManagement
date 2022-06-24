using System.Collections.Generic;
using Delta.SaleProject.Authorization.Users.Importing.Dto;
using Delta.SaleProject.Dto;

namespace Delta.SaleProject.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
