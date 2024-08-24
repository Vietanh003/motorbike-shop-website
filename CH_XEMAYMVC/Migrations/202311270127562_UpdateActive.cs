namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.XeMays", "IsHome", c => c.Boolean(nullable: false));
            AddColumn("dbo.XeMays", "IsSale", c => c.Boolean(nullable: false));
            AddColumn("dbo.XeMays", "IsFeature", c => c.Boolean(nullable: false));
            AddColumn("dbo.XeMays", "IsHot", c => c.Boolean(nullable: false));
            AddColumn("dbo.XeMays", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.DanhMucs", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.TinTucs", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TinTucs", "IsActive");
            DropColumn("dbo.Posts", "IsActive");
            DropColumn("dbo.DanhMucs", "IsActive");
            DropColumn("dbo.XeMays", "IsActive");
            DropColumn("dbo.XeMays", "IsHot");
            DropColumn("dbo.XeMays", "IsFeature");
            DropColumn("dbo.XeMays", "IsSale");
            DropColumn("dbo.XeMays", "IsHome");
        }
    }
}
