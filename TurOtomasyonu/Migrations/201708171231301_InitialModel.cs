namespace TurOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullanıcıAdi = c.String(name: "Kullanıcı Adi", nullable: false, maxLength: 8, fixedLength: true),
                        Parola = c.String(nullable: false, maxLength: 12),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musteri_Profil",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Adınız = c.String(nullable: false),
                        SoyAdınız = c.String(nullable: false),
                        Hobileriniz = c.String(),
                        EPosta = c.String(name: "E-Posta", nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteri", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.CustomerTourHistories",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        TourId = c.Int(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                        OrderRefNumber = c.String(),
                        Customer = c.Int(nullable: false),
                        Tour = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Musteri", t => t.Customer, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.Tour, cascadeDelete: true)
                .Index(t => t.Customer)
                .Index(t => t.Tour);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TurAdi = c.String(nullable: false, maxLength: 50),
                        CategoryId = c.Int(nullable: false),
                        Description = c.String(),
                        Tur_Baslangic = c.DateTime(nullable: false, storeType: "date"),
                        Tur_Bitis = c.DateTime(nullable: false, storeType: "date"),
                        TurFiyati = c.Decimal(precision: 18, scale: 2),
                        Kota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tur_Kategori", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Tur_Kategori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tur_Kategorisi = c.String(nullable: false, maxLength: 50),
                        TopCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tur_Kategori", t => t.TopCategoryId)
                .Index(t => t.TopCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerTourHistories", "Tour", "dbo.Tours");
            DropForeignKey("dbo.Tours", "CategoryId", "dbo.Tur_Kategori");
            DropForeignKey("dbo.Tur_Kategori", "TopCategoryId", "dbo.Tur_Kategori");
            DropForeignKey("dbo.CustomerTourHistories", "Customer", "dbo.Musteri");
            DropForeignKey("dbo.Musteri_Profil", "Id", "dbo.Musteri");
            DropIndex("dbo.Tur_Kategori", new[] { "TopCategoryId" });
            DropIndex("dbo.Tours", new[] { "CategoryId" });
            DropIndex("dbo.CustomerTourHistories", new[] { "Tour" });
            DropIndex("dbo.CustomerTourHistories", new[] { "Customer" });
            DropIndex("dbo.Musteri_Profil", new[] { "Id" });
            DropTable("dbo.Tur_Kategori");
            DropTable("dbo.Tours");
            DropTable("dbo.CustomerTourHistories");
            DropTable("dbo.Musteri_Profil");
            DropTable("dbo.Musteri");
        }
    }
}
