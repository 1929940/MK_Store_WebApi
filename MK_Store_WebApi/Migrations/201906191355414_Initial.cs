//namespace MK_Store_WebApi.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;
    
//    public partial class Initial : DbMigration
//    {
//        public override void Up()
//        {
//            CreateTable(
//                "dbo.Clients",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        FirstName = c.String(nullable: false, maxLength: 50),
//                        LastName = c.String(nullable: false, maxLength: 50),
//                        Login = c.String(nullable: false, maxLength: 50),
//                        Email = c.String(nullable: false, maxLength: 50),
//                        Phone = c.String(nullable: false, maxLength: 20),
//                    })
//                .PrimaryKey(t => t.Id);
            
//            CreateTable(
//                "dbo.Orders",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Date = c.DateTime(nullable: false),
//                        Archive = c.Boolean(nullable: false),
//                        Client_Id = c.Int(nullable: false),
//                        Product_Id = c.Int(nullable: false),
//                        Client_Id1 = c.Int(),
//                        Product_Id1 = c.Int(),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("dbo.Clients", t => t.Client_Id1)
//                .ForeignKey("dbo.Products", t => t.Product_Id1)
//                .Index(t => t.Client_Id1)
//                .Index(t => t.Product_Id1);
            
//            CreateTable(
//                "dbo.Products",
//                c => new
//                    {
//                        Id = c.Int(nullable: false, identity: true),
//                        Name = c.String(nullable: false),
//                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
//                    })
//                .PrimaryKey(t => t.Id);
            
//        }
        
//        public override void Down()
//        {
//            DropForeignKey("dbo.Orders", "Product_Id1", "dbo.Products");
//            DropForeignKey("dbo.Orders", "Client_Id1", "dbo.Clients");
//            DropIndex("dbo.Orders", new[] { "Product_Id1" });
//            DropIndex("dbo.Orders", new[] { "Client_Id1" });
//            DropTable("dbo.Products");
//            DropTable("dbo.Orders");
//            DropTable("dbo.Clients");
//        }
//    }
//}
