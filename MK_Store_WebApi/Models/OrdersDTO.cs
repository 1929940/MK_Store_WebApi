using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MK_Store_WebApi.Models
{
    public class OrdersDTO
    {
        public int Id { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}