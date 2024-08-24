namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.XeMays", "Tenxe", c => c.String(maxLength: 150));
            AlterColumn("dbo.XeMays", "mota", c => c.String(maxLength: 150));
            AlterColumn("dbo.XeMays", "anh", c => c.String(maxLength: 250));
            AlterColumn("dbo.XeMays", "nguoitao", c => c.String(maxLength: 150));
            AlterColumn("dbo.XeMays", "nguoisua", c => c.String(maxLength: 150));
            AlterColumn("dbo.Posts", "alias", c => c.String(maxLength: 150));
            AlterColumn("dbo.Posts", "image", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "image", c => c.String());
            AlterColumn("dbo.Posts", "alias", c => c.String());
            AlterColumn("dbo.XeMays", "nguoisua", c => c.String());
            AlterColumn("dbo.XeMays", "nguoitao", c => c.String());
            AlterColumn("dbo.XeMays", "anh", c => c.String());
            AlterColumn("dbo.XeMays", "mota", c => c.String());
            AlterColumn("dbo.XeMays", "Tenxe", c => c.String());
        }
    }
}
