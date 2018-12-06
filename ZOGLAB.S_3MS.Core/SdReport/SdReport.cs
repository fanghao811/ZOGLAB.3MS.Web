using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZOGLAB.S_3MS.Authorization.Roles;

namespace ZOGLAB.S_3MS.SD
{
    /// <summary>
    /// 共用信息配置表(SD_Utils)
    /// </summary>
    [Table("Report", Schema = "SD")]
    public class SdReport : Entity<long>, IHasCreationTime
    {
        public const int MaxLength_10 = 10;
        public const int MaxLength_50 = 50;
        public const int MaxLength_200 = 200;

        //1.报表编码
        [MaxLength(MaxLength_50)]
        public string Code { get; set; }

        //2.报表名称
        [MaxLength(MaxLength_50)]
        public string Name { get; set; }

        //3.报表类型
        public ReportType ReportType { get; set; }

        //4.报表文件路径
        [MaxLength(MaxLength_50)]
        public string ReportPath { get; set; }

        //5.报表参数
        [MaxLength(MaxLength_50)]
        public int ReportParams { get; set; }

        /// <summary>
        /// 6.角色id -->Role
        /// </summary>
        public long? RoleId { get; set; }
        public string RoleName { get; set; }

        //7.是否开启
        [MaxLength(MaxLength_50)]
        public bool IsActive { get; set; }

        //8.描述
        [MaxLength(MaxLength_200)]
        public string Description { get; set; }

        //9.备注
        [MaxLength(MaxLength_200)]
        public string Memo { get; set; }

        //10.录入日期
        public DateTime CreationTime { get; set; }
     
        //构造函数
        public SdReport(
            string code,
            string name,           
            ReportType type,
            string reportPath,
            int reportParams,
            Role role,
            bool isActive,        
            string description,
            string memo)
        {
            if (!Enum.IsDefined(typeof(ReportType), type))
            {
                throw new InvalidEnumArgumentException(nameof(type), (int)type, typeof(ReportType));
            }
            Code = code;
            Name = name;
            ReportType = type;
            ReportPath = reportPath;
            ReportParams = reportParams;
            RoleId = role.Id;
            RoleName = role.Name;
            IsActive = isActive;

            CreationTime = Clock.Now;
        }
        protected SdReport()
        {

        }

    }
    public enum ReportType : byte
    {
        数据类报表 = 1,
        分析类报表 = 2
    }
}
