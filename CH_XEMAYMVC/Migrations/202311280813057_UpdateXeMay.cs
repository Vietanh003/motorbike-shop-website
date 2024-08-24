namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateXeMay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.XeMays", "seotieude", c => c.String());
            AddColumn("dbo.XeMays", "seomota", c => c.String());
            AddColumn("dbo.XeMays", "seotukhoa", c => c.String());
            AddColumn("dbo.DanhMucSanPhams", "seotieude", c => c.String());
            AddColumn("dbo.DanhMucSanPhams", "seomota", c => c.String());
            AddColumn("dbo.DanhMucSanPhams", "seotukhoa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DanhMucSanPhams", "seotukhoa");
            DropColumn("dbo.DanhMucSanPhams", "seomota");
            DropColumn("dbo.DanhMucSanPhams", "seotieude");
            DropColumn("dbo.XeMays", "seotukhoa");
            DropColumn("dbo.XeMays", "seomota");
            DropColumn("dbo.XeMays", "seotieude");
        }
    }
}
