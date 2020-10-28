namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6aa0fcb4-7f40-4408-8928-7b10c67433c5', N'987654321789', N'9876543210', N'admin@vidly.com', 0, N'AM61baXwyTRlgmyInD96+QEmR4hpnBR6KytKgVsUhd/U7w4RGdPzR9GNdyzKCvCMJg==', N'3ab7ebc9-bb7b-441f-b278-295a5e529213', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9a0d7929-54c3-49f3-9004-bfb84a3553a0', N'CanManageMovie')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6aa0fcb4-7f40-4408-8928-7b10c67433c5', N'9a0d7929-54c3-49f3-9004-bfb84a3553a0')
        ");
        }
        
        public override void Down()
        {
        }
    }
}
