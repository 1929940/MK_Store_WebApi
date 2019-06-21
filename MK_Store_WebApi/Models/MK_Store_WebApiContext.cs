using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MK_Store_WebApi.Models
{
    public class MK_Store_WebApiContext : DbContext
    {
    
        public MK_Store_WebApiContext() : base("name=MK_Store_WebApiContext")
        {
            Database.SetInitializer<MK_Store_WebApiContext>(new DBInitializer());
        }

        public virtual DbSet<MK_Store_WebApi.Models.Client> Clients { get; set; }

        public virtual DbSet<MK_Store_WebApi.Models.Product> Products { get; set; }

        public virtual DbSet<MK_Store_WebApi.Models.Order> Orders { get; set; }

        private class DBInitializer : CreateDatabaseIfNotExists<MK_Store_WebApiContext>
        {
            protected override void Seed(MK_Store_WebApi.Models.MK_Store_WebApiContext context)
            {
                // Clients

                IList<Client> clients = new List<Client>();
                IList<Order> orders = new List<Order>();
                IList<Product> products = new List<Product>();

                clients.Add(
                    new Client()
                    {
                        //Id = 1,
                        FirstName = "Elmer",
                        LastName = "Fudd",
                        Email = "thesupremehunter@looney.toons",
                        Login = "WarMachineRox",
                        Phone = "111 111 111"
                    });
                clients.Add(
                    new Client()
                    {
                        //Id = 2,
                        FirstName = "Bugs",
                        LastName = "Bunny",
                        Email = "whatsupdoc@looney.toons",
                        Login = "Carrot",
                        Phone = "+48 000 000 001 "
                    });
                clients.Add(
                    new Client()
                    {
                        //Id = 3,
                        FirstName = "Sam",
                        LastName = "Yosemite",
                        Email = "Blackbeard@looney.toons",
                        Login = "Blackbeard@looney.toons",
                        Phone = "+48 092 092 092"
                    });

                //context.Clients.AddRange(clients);
                //context.SaveChanges();


                // Products 

                products.Add(
                    new Product()
                    {
                        //Id = 1,
                        Name = "Carrot",
                        Price = 0.99m
                    });
                products.Add(
                    new Product()
                    {
                        //Id = 2,
                        Name = "Ammunition",
                        Price = 1.95m
                    });
                products.Add(
                    new Product()
                    {
                        //Id = 3,
                        Name = "Barber Shop",
                        Price = 222m
                    });

                //context.Products.AddRange(products);
                //context.SaveChanges();

                // Orders

                orders.Add(
                    new Order()
                    {
                        //Id = 1,
                        Client_Id = 2,
                        Product_Id = 1,
                        Client = clients[1],
                        Product = products[0],
                        Date = DateTime.Now.Date
                    }) ;
                orders.Add(
                     new Order()
                     {
                         //Id = 2,
                         Client_Id = 2,
                         Product_Id = 1,
                         Client = clients[1],
                         Product = products[0],
                         Date = DateTime.Now.Date
                     });
                orders.Add(
                    new Order()
                    {
                        //Id = 3,
                        Client_Id = 2,
                        Product_Id = 1,
                        Client = clients[1],
                        Product = products[0],
                        Date = DateTime.Now.Date
                    });
                orders.Add(
                    new Order()
                     {
                        //Id = 3,
                        Client_Id = 2,
                        Product_Id = 3,
                        Client = clients[1],
                        Product = products[2],
                        Date = DateTime.Now.Date.AddDays(-3)
                     });
                orders.Add(
                    new Order()
                    {
                        //Id = 4,
                        Client_Id = 1,
                        Product_Id = 2,
                        Client = clients[0],
                        Product = products[1],
                        Date = DateTime.Now.Date.AddYears(1)
                    });
                orders.Add(
                    new Order()
                    {
                        //Id = 5,
                        Client_Id = 3,
                        Product_Id = 2,
                        Client = clients[2],
                        Product = products[1],
                        Date = DateTime.Now.Date.AddDays(1)
                    });


                context.Clients.AddRange(clients);
                context.Products.AddRange(products);
                context.Orders.AddRange(orders);

                context.SaveChanges();

            }
        }
    }

}
