namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roles2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanViens", "Username", c => c.String());
            AddColumn("dbo.NhanViens", "password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanViens", "password");
            DropColumn("dbo.NhanViens", "Username");
        }
    }
}
