using System.Collections.Generic;

namespace ZOGLAB.S_3MS.SD
{
    public interface ITreeUnit
    {
        ICollection<TreeUnit> Children { get; set; }
        string Code { get; set; }
        string DisplayName { get; set; }
        TreeUnit Parent { get; set; }
        long? ParentId { get; set; }
        int? TenantId { get; set; }
    }
}