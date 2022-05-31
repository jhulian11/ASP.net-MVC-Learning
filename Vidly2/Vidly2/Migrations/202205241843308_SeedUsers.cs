namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ac668cd0-2d88-480a-8d5e-58179f0151b3', N'admin@vidly2.com', 0, N'ALoHld0aeTFCrlF8uckoBehrXSR3gQaVmFA6IRP95L5FpSgWXt21hf3W2j2uj/UGQw==', N'fdd7f0bb-2d56-4d71-8a89-20bc0f5433ab', NULL, 0, 0, NULL, 1, 0, N'admin@vidly2.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b901f65b-3314-4c49-9254-86b170c002ab', N'guest@vidly2.com', 0, N'AONq6RPUId2/9JLpl3oXX5RtYlytSYGD3odOmSpiUZDw0fPb8fFMY8dYS8AJkXaWyQ==', N'43509579-b3b0-4e6d-8842-0ee87b45e469', NULL, 0, 0, NULL, 1, 0, N'guest@vidly2.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8be810b4-7776-4ce3-a869-83f876d13608', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ac668cd0-2d88-480a-8d5e-58179f0151b3', N'8be810b4-7776-4ce3-a869-83f876d13608')

");
        }
        
        public override void Down()
        {
        }
    }
}
