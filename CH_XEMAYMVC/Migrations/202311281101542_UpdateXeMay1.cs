namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateXeMay1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.XeMays", "Codesanpham", c => c.String(maxLength: 250));
            AlterColumn("dbo.XeMays", "alias", c => c.String(maxLength: 250));
            AlterColumn("dbo.XeMays", "seotieude", c => c.String(maxLength: 250));
            AlterColumn("dbo.XeMays", "seomota", c => c.String(maxLength: 250));
            AlterColumn("dbo.XeMays", "seotukhoa", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.XeMays", "seotukhoa", c => c.String());
            AlterColumn("dbo.XeMays", "seomota", c => c.String());
            AlterColumn("dbo.XeMays", "seotieude", c => c.String());
            AlterColumn("dbo.XeMays", "alias", c => c.String());
            DropColumn("dbo.XeMays", "Codesanpham");
        }
    }
}
