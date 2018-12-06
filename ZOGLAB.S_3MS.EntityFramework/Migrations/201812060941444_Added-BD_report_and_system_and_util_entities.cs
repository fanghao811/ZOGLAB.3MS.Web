namespace ZOGLAB.S_3MS.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBD_report_and_system_and_util_entities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SD_Report",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        ReportType = c.Int(nullable: false),
                        ReportPath = c.String(maxLength: 50),
                        ReportParams = c.Int(nullable: false),
                        RoleId = c.Long(),
                        RoleName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Description = c.String(maxLength: 200),
                        Memo = c.String(maxLength: 200),
                        CreationTime = c.DateTime(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SD_Report_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SD_System",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        Url = c.String(maxLength: 50),
                        DatabaseName = c.String(maxLength: 20),
                        UserName = c.String(maxLength: 50),
                        UserPwd = c.String(maxLength: 50),
                        IsShow = c.Boolean(nullable: false),
                        Memo = c.String(maxLength: 200),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SD_Util",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TableCode = c.String(maxLength: 50),
                        TableColumn = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        Prefix = c.String(maxLength: 10),
                        Length = c.Int(nullable: false),
                        KeyIndex = c.Int(nullable: false),
                        KeyValue = c.String(maxLength: 50),
                        Description = c.String(maxLength: 200),
                        Memo = c.String(maxLength: 200),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SD_Util");
            DropTable("dbo.SD_System");
            DropTable("dbo.SD_Report",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_SD_Report_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
