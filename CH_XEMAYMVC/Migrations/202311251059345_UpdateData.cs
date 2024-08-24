namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.XeMays", "alias", c => c.String());
            AddColumn("dbo.DanhMucs", "alias", c => c.String());
            AddColumn("dbo.Posts", "alias", c => c.String());
            AddColumn("dbo.TinTucs", "alias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TinTucs", "alias");
            DropColumn("dbo.Posts", "alias");
            DropColumn("dbo.DanhMucs", "alias");
            DropColumn("dbo.XeMays", "alias");
        }
    }
}
