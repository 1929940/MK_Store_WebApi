//using MK_Store_WebApi.Models;

//namespace MK_Store_WebApi.Migrations
//{
//    using System;
//    using System.Data.Entity;
//    using System.Data.Entity.Migrations;
//    using System.Linq;

//    internal sealed class Configuration : DbMigrationsConfiguration<MK_Store_WebApi.Models.MK_Store_WebApiContext>
//    {
//        public Configuration()
//        {
//            AutomaticMigrationsEnabled = false;
//        }

//        protected override void Seed(MK_Store_WebApi.Models.MK_Store_WebApiContext context)
//        {
//            //  This method will be called after migrating to the latest version.

//            // Clients

//            context.Clients.AddOrUpdate(x => x.Id,
//                new Client()
//                {
//                    Id = 1,
//                    FirstName = "Elmer",
//                    LastName = "Fudd",
//                    Email = "thesupremehunter@looney.toons",
//                    Login = "WarMachineRox",
//                    Phone = "111 111 111"
//                },
//                new Client()
//                {
//                    Id = 2,
//                    FirstName = "Bugs",
//                    LastName = "Bunny",
//                    Email = "whatsupdoc@looney.toons",
//                    Login = "Carrot",
//                    Phone = "+48 000 000 001 "
//                },
//                new Client()
//                {
//                    Id = 3,
//                    FirstName = "Sam",
//                    LastName = "Yosemite",
//                    Email = "Blackbeard@looney.toons",
//                    Login = "Blackbeard@looney.toons",
//                    Phone = "+48 092 092 092"
//                });

//            // Products 

//            context.Products.AddOrUpdate(x => x.Id,
//                new Product()
//                {
//                    Id = 1,
//                    Name = "Carrot",
//                    Price = 0.99m
//                },
//                new Product()
//                {
//                    Id = 2,
//                    Name = "Ammunition",
//                    Price = 1.95m
//                },
//                new Product()
//                {
//                    Id = 3,
//                    Name = "Barber Shop",
//                    Price = 222m
//                });

//            // Orders

//            context.Orders.AddOrUpdate(x => x.Id,
//                new Order()
//                {
//                    Id = 1,
//                    Client_Id = 2,
//                    Product_Id = 1,
//                    Date = DateTime.Now
//                },
//                new Order()
//                {
//                    Id = 2,
//                    Client_Id = 2,
//                    Product_Id = 1,
//                    Date = DateTime.Now
//                },
//                new Order()
//                {
//                    Id = 3,
//                    Client_Id = 2,
//                    Product_Id = 1,
//                    Date = DateTime.Now
//                },
//                new Order()
//                {
//                    Id = 3,
//                    Client_Id = 2,
//                    Product_Id = 3,
//                    Date = DateTime.Now
//                },
//                new Order()
//                {
//                    Id = 4,
//                    Client_Id = 1,
//                    Product_Id = 2,
//                    Date = DateTime.Now
//                },
//                new Order()
//                {
//                    Id = 5,
//                    Client_Id = 3,
//                    Product_Id = 2,
//                    Date = DateTime.Now
//                });
//        }
//    }
//}
