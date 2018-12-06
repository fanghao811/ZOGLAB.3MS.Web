using System.Collections.Generic;
using ZOGLAB.S_3MS.Authorization.Users.Dto;
using ZOGLAB.S_3MS.Dto;

namespace ZOGLAB.S_3MS.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}