using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZOGLAB.S_3MS.SdReport
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

        //6.角色id
        public int Role_ID { get; set; }

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
        public SdReport()
        {
            CreationTime = DateTime.Now;
        }
    }
    public enum ReportType : byte
    {
        数据类报表 = 1,
        分析类报表 = 2
    }
}
