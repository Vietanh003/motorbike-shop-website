namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatepayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DonHangs", "TypePayment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DonHangs", "TypePayment");
        }
    }
}
