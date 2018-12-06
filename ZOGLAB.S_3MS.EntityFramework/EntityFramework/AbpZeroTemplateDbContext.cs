﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using ZOGLAB.S_3MS.Authorization.Roles;
using ZOGLAB.S_3MS.Authorization.Users;
using ZOGLAB.S_3MS.Chat;
using ZOGLAB.S_3MS.Friendships;
using ZOGLAB.S_3MS.MultiTenancy;
using ZOGLAB.S_3MS.Storage;
using ZOGLAB.S_3MS.SD;

namespace ZOGLAB.S_3MS.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class AbpZeroTemplateDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        /* 新增三个系统实体 2018/12/06  */
        public virtual IDbSet<SdReport> SdReports { get; set; }
        public virtual IDbSet<SdSystem> SdSystem { get; set; }
        public virtual IDbSet<SdUtil> SdUtil { get; set; }

        public AbpZeroTemplateDbContext()
            : base("Default")
        {
            
        }

        public AbpZeroTemplateDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public AbpZeroTemplateDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public AbpZeroTemplateDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder);
    }
}