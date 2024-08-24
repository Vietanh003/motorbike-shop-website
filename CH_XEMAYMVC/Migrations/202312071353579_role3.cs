namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class role3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRoles", "nhanvien_idnhanvien", "dbo.NhanViens");
            DropIndex("dbo.UserRoles", new[] { "nhanvien_idnhanvien" });
            DropPrimaryKey("dbo.UserRoles");
            AddColumn("dbo.UserRoles", "id", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.UserRoles", new[] { "id", "RoleId" });
            CreateIndex("dbo.UserRoles", "id");
            AddForeignKey("dbo.UserRoles", "id", "dbo.TaiKhoans", "id", cascadeDelete: true);
            DropColumn("dbo.UserRoles", "UserId");
            DropColumn("dbo.UserRoles", "nhanvien_idnhanvien");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserRoles", "nhanvien_idnhanvien", c => c.Long());
            AddColumn("dbo.UserRoles", "UserId", c => c.Long(nullable: false));
            DropForeignKey("dbo.UserRoles", "id", "dbo.TaiKhoans");
            DropIndex("dbo.UserRoles", new[] { "id" });
            DropPrimaryKey("dbo.UserRoles");
            DropColumn("dbo.UserRoles", "id");
            AddPrimaryKey("dbo.UserRoles", new[] { "UserId", "RoleId" });
            CreateIndex("dbo.UserRoles", "nhanvien_idnhanvien");
            AddForeignKey("dbo.UserRoles", "nhanvien_idnhanvien", "dbo.NhanViens", "idnhanvien");
        }
    }
}
