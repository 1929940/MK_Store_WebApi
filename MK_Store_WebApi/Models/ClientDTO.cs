using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MK_Store_WebApi.Models
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}