namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yorum_notnull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Yorumlars", "KullaniciAdi", c => c.String(nullable: false));
            AlterColumn("dbo.Yorumlars", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Yorumlars", "Yorum", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yorumlars", "Yorum", c => c.String());
            AlterColumn("dbo.Yorumlars", "Mail", c => c.String());
            AlterColumn("dbo.Yorumlars", "KullaniciAdi", c => c.String());
        }
    }
}
