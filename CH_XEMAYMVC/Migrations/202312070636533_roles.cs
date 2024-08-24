namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        idnhanvien = c.Long(nullable: false, identity: true),
                        tennhanvien = c.String(),
                        SDT = c.String(),
                    })
                .PrimaryKey(t => t.idnhanvien);
            
            AddColumn("dbo.UserRoles", "nhanvien_idnhanvien", c => c.Long());
            CreateIndex("dbo.UserRoles", "nhanvien_idnhanvien");
            AddForeignKey("dbo.UserRoles", "nhanvien_idnhanvien", "dbo.NhanViens", "idnhanvien");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "nhanvien_idnhanvien", "dbo.NhanViens");
            DropIndex("dbo.UserRoles", new[] { "nhanvien_idnhanvien" });
            DropColumn("dbo.UserRoles", "nhanvien_idnhanvien");
            DropTable("dbo.NhanViens");
        }
    }
}
