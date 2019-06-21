using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MK_Store_WebApi.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public bool Archive { get; set; } = false;

        public int Client_Id { get; set; }
        public Client Client { get; set; }

        public int Product_Id { get; set; }
        public Product Product { get; set; }

    }
}