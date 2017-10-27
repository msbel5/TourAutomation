namespace TurOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musteri", "Kullanıcı Adi", c => c.String(maxLength: 8, fixedLength: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Musteri", "Kullanıcı Adi", c => c.String(nullable: false, maxLength: 8, fixedLength: true));
        }
    }
}
