using ZOGLAB.S_3MS.Dto;

namespace ZOGLAB.S_3MS.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}