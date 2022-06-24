using System.Collections.Generic;
using Abp;
using Delta.SaleProject.Chat.Dto;
using Delta.SaleProject.Dto;

namespace Delta.SaleProject.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
