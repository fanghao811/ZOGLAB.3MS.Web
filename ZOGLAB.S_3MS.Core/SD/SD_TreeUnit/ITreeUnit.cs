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




        //
        // 摘要:
        //     Appends a child code to a parent code. Example: if parentCode = "00001", childCode
        //     = "00042" then returns "00001.00042".
        //
        // 参数:
        //   parentCode:
        //     Parent code. Can be null or empty if parent is a root.
        //
        //   childCode:
        //     Child code.
        string AppendCode(string parentCode, string childCode);
        //
        // 摘要:
        //     Calculates next code for given code. Example: if code = "00019.00055.00001" returns
        //     "00019.00055.00002".
        //
        // 参数:
        //   code:
        //     The code.
        string CalculateNextCode(string code);
        //
        // 摘要:
        //     Creates code for given numbers. Example: if numbers are 4,2 then returns "00004.00002";
        //
        // 参数:
        //   numbers:
        //     Numbers
        string CreateCode(params int[] numbers);
        //
        // 摘要:
        //     Gets the last unit code. Example: if code = "00019.00055.00001" returns "00001".
        //
        // 参数:
        //   code:
        //     The code.
        string GetLastUnitCode(string code);
        //
        // 摘要:
        //     Gets parent code. Example: if code = "00019.00055.00001" returns "00019.00055".
        //
        // 参数:
        //   code:
        //     The code.
        string GetParentCode(string code);
        //
        // 摘要:
        //     Gets relative code to the parent. Example: if code = "00019.00055.00001" and
        //     parentCode = "00019" then returns "00055.00001".
        //
        // 参数:
        //   code:
        //     The code.
        //
        //   parentCode:
        //     The parent code.
        string GetRelativeCode(string code, string parentCode);
    }
}