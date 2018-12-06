using System.Collections.Generic;
using ZOGLAB.S_3MS.Auditing.Dto;
using ZOGLAB.S_3MS.Dto;

namespace ZOGLAB.S_3MS.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
