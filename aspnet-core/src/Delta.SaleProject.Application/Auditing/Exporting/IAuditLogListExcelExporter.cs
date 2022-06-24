using System.Collections.Generic;
using Delta.SaleProject.Auditing.Dto;
using Delta.SaleProject.Dto;

namespace Delta.SaleProject.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
